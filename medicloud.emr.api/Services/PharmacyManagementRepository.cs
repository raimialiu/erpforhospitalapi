using medicloud.emr.api.Controllers;
using medicloud.emr.api.Data;
using medicloud.emr.api.DTOs;
using medicloud.emr.api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace medicloud.emr.api.Services
{
    public interface IPharmacyManagementRepository
    {
        Task<bool> AddPrescriptionDetails(FullPrescriptionDetailsDTO prescDetails);
        Task<PrescriptionListWithCount> getConsultationPrescriptionsList(PrescriptionListFilterModel prescriptionListFilterModel);
        Task<List<PharmacyManagementPrescriptionDetailsDTO>> getAllPrescriptionsDetails();
        PharmacyManagementDTO getConsultationPrescriptionByPrescriptionId(int prescriptionId);
        Task<bool> UpdatePrescriptionDetails(PrescriptionDetailsUpdateDTO prescriptionDetailsUpdateDTO);
        Task<bool> RemovePrescriptionDetails(PrescriptionDetailsRemoveDTO prescriptionDetailsRemoveDTO);
        Task<List<PharmacyManagementPrescriptionDetailsDTO>> getConsultationPrescriptionsDetailsByPrescriptionId(int prescriptionId);
        bool PrescriptionDetailsExist(int prescriptionDetailsId);
        bool ConsultationPrescriptionExists(int ConsultationPrescriptionId);
        Task<IEnumerable<ProviderDTO>> GetProviders();
        Task<IEnumerable<LocationDTO>> GetLocations();
        Task<IEnumerable<OptionsDTO>> GetStatus();
        
    }
    public class PharmacyManagementRepository : IPharmacyManagementRepository
    {
        private static int CalculateAge(DateTime Dob)
        {
            int yearToday = DateTime.Now.Year;
            int dateYear = Dob.Year;
            return (yearToday - dateYear);
        }

        private readonly DataContext _context;
        public PharmacyManagementRepository(DataContext context)
        {
            _context = context;
        }


        public async Task<PrescriptionListWithCount> getConsultationPrescriptionsList(PrescriptionListFilterModel prescriptionListFilterModel)
        {
            var preseciptionList = new List<PharmacyManagementDTO>();          

            if (prescriptionListFilterModel.Date.HasValue && prescriptionListFilterModel.LocationId.HasValue && prescriptionListFilterModel.ProviderId.HasValue)
            {
                preseciptionList = await (_context.ConsultationPrescription.AsNoTracking()
               .Where(p => (p.Patientid != null) && p.Isactive == true &&
                       (((p.Prescriptiondate == prescriptionListFilterModel.Date) ||
                       (p.Locationid == prescriptionListFilterModel.LocationId) ||
                       (p.ProviderId == prescriptionListFilterModel.ProviderId))) && 
                       (_context.ConsultationPrescriptionDetails.Any(pd => pd.Prescriptionid == p.Prescriptionid && pd.Isactive == true)))
               .Skip((prescriptionListFilterModel.PageNumber - 1) * prescriptionListFilterModel.PageSize)
               .Take(prescriptionListFilterModel.PageSize)
              .Select(presc => new PharmacyManagementDTO
              {
                  Facility = presc.Location.Locationname,
                  Prescno = presc.Prescriptionid,
                  Prescdate = presc.Prescriptiondate,
                  Patientname = presc.Patient.Firstname + " " + presc.Patient.Lastname,
                  Agegender = CalculateAge((DateTime)presc.Patient.Dob) + "/Yrs" + presc.Patient.Gender.Gendername,
                  Regno = UInt32.Parse(presc.Patientid),
                  //Plantype = _context.PlanType.Where(pl=>pl.planid==Int32.Parse(presc.Patient.Plantype)).Select(pl=>pl.planname).FirstOrDefault(),
                  //Plantype = _context.PlanType.FromSqlInterpolated($"SELECT planname from PlanType where planid = {presc.Patient.Plantype}").FirstOrDefault().ToString(),
                  Company = presc.Patient.Spons.Sponsortype,
                  Alert = 0,
                  Doctorname = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                  Seenbydoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                  Store = presc.Indentstore.Departmentname
              })).OrderBy(p => p.Prescdate).ToListAsync();
                int count = _context.ConsultationPrescription.FromSqlInterpolated($"SELECT prescriptionid AS pid FROM Consultation_Prescription WHERE  patientid is not null  AND (locationid = {prescriptionListFilterModel.LocationId}  OR ProviderID = {prescriptionListFilterModel.ProviderId} OR prescriptiondate == {prescriptionListFilterModel.Date})").Count();
                var prescriptionListWithCount = new PrescriptionListWithCount(preseciptionList, count);
                return prescriptionListWithCount;
            }               
            else if (prescriptionListFilterModel.Date.HasValue && prescriptionListFilterModel.LocationId.HasValue && !prescriptionListFilterModel.ProviderId.HasValue)
            {
                preseciptionList = await (_context.ConsultationPrescription.AsNoTracking()
               .Where(p => (p.Patientid != null) && (p.Isactive == true) && (
                       ((p.Prescriptiondate == prescriptionListFilterModel.Date) ||
                       (p.Locationid == prescriptionListFilterModel.LocationId))) &&
                       (_context.ConsultationPrescriptionDetails.Any(pd => pd.Prescriptionid == p.Prescriptionid && pd.Isactive == true)))
               .Skip((prescriptionListFilterModel.PageNumber - 1) * prescriptionListFilterModel.PageSize)
               .Take(prescriptionListFilterModel.PageSize)
              .Select(presc => new PharmacyManagementDTO
              {
                  Facility = presc.Location.Locationname,
                  Prescno = presc.Prescriptionid,
                  Prescdate = presc.Prescriptiondate,
                  Patientname = presc.Patient.Firstname + " " + presc.Patient.Lastname,
                  Agegender = CalculateAge((DateTime)presc.Patient.Dob) + "/Yrs" + presc.Patient.Gender.Gendername,
                  Regno = UInt32.Parse(presc.Patientid),
                  //Plantype = _context.PlanType.Where(pl=>pl.planid==Int32.Parse(presc.Patient.Plantype)).Select(pl=>pl.planname).FirstOrDefault(),
                  //Plantype = _context.PlanType.FromSqlInterpolated($"SELECT planname from PlanType where planid = {presc.Patient.Plantype}").FirstOrDefault().ToString(),
                  Company = presc.Patient.Spons.Sponsortype,
                  Alert = 0,
                  Doctorname = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                  Seenbydoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                  Store = presc.Indentstore.Departmentname
              })).OrderBy(p => p.Prescdate).ToListAsync();

                int count = _context.ConsultationPrescription.FromSqlInterpolated($"SELECT prescriptionid AS pid FROM Consultation_Prescription WHERE  patientid is not null  AND (locationid = {prescriptionListFilterModel.LocationId} OR prescriptiondate = {prescriptionListFilterModel.Date})").Count();
                var prescriptionListWithCount = new PrescriptionListWithCount(preseciptionList, count);
                return prescriptionListWithCount;
            }
            else if (prescriptionListFilterModel.Date.HasValue && prescriptionListFilterModel.ProviderId.HasValue && !prescriptionListFilterModel.LocationId.HasValue)
            {
                preseciptionList = await (_context.ConsultationPrescription.AsNoTracking()
               .Where(p => (p.Patientid != null)  && (p.Isactive == true)  && (
                       ((p.Prescriptiondate == prescriptionListFilterModel.Date) ||
                       (p.ProviderId == prescriptionListFilterModel.ProviderId))) &&
                       (_context.ConsultationPrescriptionDetails.Any(pd => pd.Prescriptionid == p.Prescriptionid && pd.Isactive == true)))
               .Skip((prescriptionListFilterModel.PageNumber - 1) * prescriptionListFilterModel.PageSize)
               .Take(prescriptionListFilterModel.PageSize)
              .Select(presc => new PharmacyManagementDTO
              {
                  Facility = presc.Location.Locationname,
                  Prescno = presc.Prescriptionid,
                  Prescdate = presc.Prescriptiondate,
                  Patientname = presc.Patient.Firstname + " " + presc.Patient.Lastname,
                  Agegender = CalculateAge((DateTime)presc.Patient.Dob) + "/Yrs" + presc.Patient.Gender.Gendername,
                  Regno = UInt32.Parse(presc.Patientid),
                  //Plantype = _context.PlanType.Where(pl=>pl.planid==Int32.Parse(presc.Patient.Plantype)).Select(pl=>pl.planname).FirstOrDefault(),
                  //Plantype = _context.PlanType.FromSqlInterpolated($"SELECT planname from PlanType where planid = {presc.Patient.Plantype}").FirstOrDefault().ToString(),
                  Company = presc.Patient.Spons.Sponsortype,
                  Alert = 0,
                  Doctorname = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                  Seenbydoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                  Store = presc.Indentstore.Departmentname
              })).OrderBy(p => p.Prescdate).ToListAsync();

                int count = _context.ConsultationPrescription.FromSqlInterpolated($"SELECT prescriptionid AS pid FROM Consultation_Prescription WHERE  patientid is not null  AND (ProviderID = {prescriptionListFilterModel.ProviderId} OR prescriptiondate = {prescriptionListFilterModel.Date})").Count();
                var prescriptionListWithCount = new PrescriptionListWithCount(preseciptionList, count);
                return prescriptionListWithCount;
            }
            else if (!prescriptionListFilterModel.Date.HasValue && prescriptionListFilterModel.ProviderId.HasValue && prescriptionListFilterModel.LocationId.HasValue)
            {
                //date filtering wasn't selected but both providerid and location selected
                preseciptionList = await (_context.ConsultationPrescription.AsNoTracking()

                  .Where(p => (p.Patientid != null) && (p.Isactive == true) && (
                      (p.Locationid == prescriptionListFilterModel.LocationId) ||
                      (p.ProviderId == prescriptionListFilterModel.ProviderId)) &&
                      (_context.ConsultationPrescriptionDetails.Any(pd => pd.Prescriptionid == p.Prescriptionid && pd.Isactive == true)))
                  .Skip((prescriptionListFilterModel.PageNumber - 1) * prescriptionListFilterModel.PageSize)
                  .Take(prescriptionListFilterModel.PageSize)
                 .Select(presc => new PharmacyManagementDTO
                 {
                     Facility = presc.Location.Locationname,
                     Prescno = presc.Prescriptionid,
                     Prescdate = presc.Prescriptiondate,
                     Patientname = presc.Patient.Firstname + " " + presc.Patient.Lastname,
                     Agegender = (CalculateAge((DateTime)presc.Patient.Dob)).ToString() + "/Yrs" + presc.Patient.Gender.Gendername,
                     Regno = UInt32.Parse(presc.Patientid),
                     //PlanType = presc.Patient.PlanType.planname,
                     Company = presc.Patient.Spons.Sponsortype,
                     Alert = 0,
                     Doctorname = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                     Seenbydoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                     Store = presc.Indentstore.Departmentname
                 })).ToListAsync();
                int count = _context.ConsultationPrescription.FromSqlInterpolated($"SELECT prescriptionid AS pid FROM Consultation_Prescription WHERE  patientid is not null  AND (locationid = {prescriptionListFilterModel.LocationId}  OR ProviderID = {prescriptionListFilterModel.ProviderId})").Count();
                var prescriptionListWithCount = new PrescriptionListWithCount(preseciptionList, count);
                return prescriptionListWithCount;
            }
            else if (!prescriptionListFilterModel.Date.HasValue && !prescriptionListFilterModel.ProviderId.HasValue && prescriptionListFilterModel.LocationId.HasValue)
            {
                preseciptionList = await (_context.ConsultationPrescription.AsNoTracking()

                  .Where(p => (p.Patientid != null) && (p.Isactive == true) && 
                          ((p.Locationid == prescriptionListFilterModel.LocationId))
                          && (_context.ConsultationPrescriptionDetails.Any(pd => pd.Prescriptionid == p.Prescriptionid && pd.Isactive == true)))
                  .Skip((prescriptionListFilterModel.PageNumber - 1) * prescriptionListFilterModel.PageSize)
                  .Take(prescriptionListFilterModel.PageSize)
                 .Select(presc => new PharmacyManagementDTO
                 {
                     Facility = presc.Location.Locationname,
                     Prescno = presc.Prescriptionid,
                     Prescdate = presc.Prescriptiondate,
                     Patientname = presc.Patient.Firstname + " " + presc.Patient.Lastname,
                     Agegender = (CalculateAge((DateTime)presc.Patient.Dob)).ToString() + "/Yrs" + presc.Patient.Gender.Gendername,
                     Regno = UInt32.Parse(presc.Patientid),
                     //PlanType = presc.Patient.PlanType.planname,
                     Company = presc.Patient.Spons.Sponsortype,
                     Alert = 0,
                     Doctorname = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                     Seenbydoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                     Store = presc.Indentstore.Departmentname
                 })).ToListAsync();
                int count = _context.ConsultationPrescription.FromSqlInterpolated($"SELECT prescriptionid AS pid FROM Consultation_Prescription WHERE  patientid is not null  AND locationid = {prescriptionListFilterModel.LocationId}").Count();
                var prescriptionListWithCount = new PrescriptionListWithCount(preseciptionList, count);
                return prescriptionListWithCount;
            }
            else if (!prescriptionListFilterModel.Date.HasValue && prescriptionListFilterModel.ProviderId.HasValue && !prescriptionListFilterModel.LocationId.HasValue)
            {
                preseciptionList = await (_context.ConsultationPrescription.AsNoTracking()
               .Where(p => (p.Patientid != null) && (p.Isactive == true) && 
                            (p.Locationid == prescriptionListFilterModel.LocationId) && 
                            (_context.ConsultationPrescriptionDetails.Any(pd => pd.Prescriptionid == p.Prescriptionid && pd.Isactive == true)))
               .Skip((prescriptionListFilterModel.PageNumber - 1) * prescriptionListFilterModel.PageSize)
               .Take(prescriptionListFilterModel.PageSize)
              .Select(presc => new PharmacyManagementDTO
              {
                  Facility = presc.Location.Locationname,
                  Prescno = presc.Prescriptionid,
                  Prescdate = presc.Prescriptiondate,
                  Patientname = presc.Patient.Firstname + " " + presc.Patient.Lastname,
                  Agegender = CalculateAge((DateTime)presc.Patient.Dob) + "/Yrs" + presc.Patient.Gender.Gendername,
                  Regno = UInt32.Parse(presc.Patientid),
                  //Plantype = _context.PlanType.Where(pl=>pl.planid==Int32.Parse(presc.Patient.Plantype)).Select(pl=>pl.planname).FirstOrDefault(),
                  //Plantype = _context.PlanType.FromSqlInterpolated($"SELECT planname from PlanType where planid = {presc.Patient.Plantype}").FirstOrDefault().ToString(),
                  Company = presc.Patient.Spons.Sponsortype,
                  Alert = 0,
                  Doctorname = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                  Seenbydoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                  Store = presc.Indentstore.Departmentname
              })).OrderBy(p => p.Prescdate).ToListAsync();

                int count = _context.ConsultationPrescription.FromSqlInterpolated($"SELECT prescriptionid AS pid FROM Consultation_Prescription WHERE patientid is not null  AND ProviderID = {prescriptionListFilterModel.ProviderId}").Count();
                var prescriptionListWithCount = new PrescriptionListWithCount(preseciptionList, count);
                return prescriptionListWithCount;
            }
            else if (prescriptionListFilterModel.Date.HasValue && !prescriptionListFilterModel.LocationId.HasValue && !prescriptionListFilterModel.ProviderId.HasValue)
            {
                preseciptionList = await (_context.ConsultationPrescription.AsNoTracking()
               .Where(p => (p.Patientid != null) && (p.Isactive == true) &&
                       (p.Prescriptiondate == prescriptionListFilterModel.Date) && 
                       (_context.ConsultationPrescriptionDetails.Any(pd => pd.Prescriptionid == p.Prescriptionid && pd.Isactive == true)))
               .Skip((prescriptionListFilterModel.PageNumber - 1) * prescriptionListFilterModel.PageSize)
               .Take(prescriptionListFilterModel.PageSize)
              .Select(presc => new PharmacyManagementDTO
              {
                  Facility = presc.Location.Locationname,
                  Prescno = presc.Prescriptionid,
                  Prescdate = presc.Prescriptiondate,
                  Patientname = presc.Patient.Firstname + " " + presc.Patient.Lastname,
                  Agegender = CalculateAge((DateTime)presc.Patient.Dob) + "/Yrs" + presc.Patient.Gender.Gendername,
                  Regno = UInt32.Parse(presc.Patientid),
                  //Plantype = _context.PlanType.Where(pl=>pl.planid==Int32.Parse(presc.Patient.Plantype)).Select(pl=>pl.planname).FirstOrDefault(),
                  //Plantype = _context.PlanType.FromSqlInterpolated($"SELECT planname from PlanType where planid = {presc.Patient.Plantype}").FirstOrDefault().ToString(),
                  Company = presc.Patient.Spons.Sponsortype,
                  Alert = 0,
                  Doctorname = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                  Seenbydoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                  Store = presc.Indentstore.Departmentname
              })).OrderBy(p => p.Prescdate).ToListAsync();
                int count = _context.ConsultationPrescription.FromSqlInterpolated($"SELECT prescriptionid AS pid FROM Consultation_Prescription WHERE  patientid is not null  AND prescriptiondate = {prescriptionListFilterModel.Date}").Count();
                var prescriptionListWithCount = new PrescriptionListWithCount(preseciptionList, count);
                return prescriptionListWithCount;
            }
            else
            {
                preseciptionList = await (_context.ConsultationPrescription.AsNoTracking()
              .Where(p => p.Patientid != null && (p.Isactive == true) && 
                     ( _context.ConsultationPrescriptionDetails.Any(pd => pd.Prescriptionid == p.Prescriptionid && pd.Isactive == true))
              )
              .Skip((prescriptionListFilterModel.PageNumber - 1) * prescriptionListFilterModel.PageSize)
              .Take(prescriptionListFilterModel.PageSize)
             .Select(presc => new PharmacyManagementDTO
             {
                 Facility = presc.Location.Locationname,
                 Prescno = presc.Prescriptionid,
                 Prescdate = presc.Prescriptiondate,
                 Patientname = presc.Patient.Firstname + " " + presc.Patient.Lastname,
                 Agegender = CalculateAge((DateTime)presc.Patient.Dob) + "/Yrs" + presc.Patient.Gender.Gendername,
                 Regno = UInt32.Parse(presc.Patientid),
                  //Plantype = _context.PlanType.Where(pl=>pl.planid==Int32.Parse(presc.Patient.Plantype)).Select(pl=>pl.planname).FirstOrDefault(),
                  //Plantype = _context.PlanType.FromSqlInterpolated($"SELECT planname from PlanType where planid = {presc.Patient.Plantype}").FirstOrDefault().ToString(),
                  Company = presc.Patient.Spons.Sponsortype,
                 Alert = 0,
                 Doctorname = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                 Seenbydoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                 Store = presc.Indentstore.Departmentname
             })).OrderBy(p => p.Prescdate).ToListAsync();

                int count = _context.ConsultationPrescription.Count();
                var prescriptionListWithCount = new PrescriptionListWithCount(preseciptionList, count);
                return prescriptionListWithCount;
            }
               
            }

               

        public async Task<List<PharmacyManagementPrescriptionDetailsDTO>> getAllPrescriptionsDetails()
        {
            var list = await _context.ConsultationPrescriptionDetails.AsNoTracking()
                   .Select(s => new PharmacyManagementPrescriptionDetailsDTO
                   {
                       Name = _context.Drug.Where(d => d.Id == s.ItemId).Select(e => e.Name).FirstOrDefault(),
                       Prescdetails = s.PrescriptionDetail,
                       Prescriptionquantity = (s.Qty).HasValue ? (int)s.Qty : 0,
                       Issuedquantity =  0,
                       disensedQuantity =  0,
                       PAno = 0,
                       Status= s.Status.Status,
                       Instructions = s.Medicationinstructions,
                       Id = s.Id,
                       Comments = s.Comments,
                       StatusId = s.Statusid,
                       isActive = (bool)s.Isactive
                   }).OrderBy(p=>p.Name).ToListAsync();
            return list;
        }

        public async Task<List<PharmacyManagementPrescriptionDetailsDTO>> getConsultationPrescriptionsDetailsByPrescriptionId(int prescriptionId)
        {
            var list = await _context.ConsultationPrescriptionDetails.AsNoTracking()
                 .Where(e => e.Prescriptionid.Equals(prescriptionId) && e.ItemId!=null && e.Isactive == true)
                    .Select(s => new PharmacyManagementPrescriptionDetailsDTO
                    {   Name = _context.Drug.Where(d => d.Id == s.ItemId).Select(e => e.Name).FirstOrDefault(),
                        Prescdetails = s.PrescriptionDetail,
                        Prescriptionquantity = (s.Qty).HasValue ? (int)s.Qty : 0,
                        Issuedquantity =  0,
                        disensedQuantity =  0,
                        PAno = 0,
                        Status = s.Status.Status,
                        Instructions = s.Medicationinstructions,
                        Id = s.Id,
                        StatusId =s.Statusid,
                        Comments = s.Comments,
                        isActive = (bool)s.Isactive
                    }).OrderBy(p => p.Name).ToListAsync();
            return list;

        }

        public bool PrescriptionDetailsExist(int prescriptionDetailsId)
        {
            return _context.ConsultationPrescriptionDetails.Any(e => e.Id == prescriptionDetailsId);            
        }

        public bool ConsultationPrescriptionExists(int ConsultationPrescriptionId)
        {
            return _context.ConsultationPrescription.Any(e => e.Consultationid == ConsultationPrescriptionId);
        }

        public PharmacyManagementDTO getConsultationPrescriptionByPrescriptionId(int prescriptionId)
        {
            var preseciption = (_context.ConsultationPrescription.AsNoTracking()
            .Where(p => p.Prescriptionid == prescriptionId)
             .Include(p => p.Patient)
             .Select(presc => new PharmacyManagementDTO
             {
                 Facility = presc.Location.Locationname,
                 Prescno = presc.Prescriptionid,
                 Prescdate = presc.Prescriptiondate,
                 Patientname = presc.Patient.Firstname + " " + presc.Patient.Lastname,
                 Agegender = (CalculateAge((DateTime)presc.Patient.Dob)).ToString() + "/Yrs" + presc.Patient.Gender.Gendername,
                 Regno = UInt32.Parse(presc.Patientid),
                 //PlanType = _context.Plan.SingleOrDefault(pl => pl.Id == Int32.Parse(presc.Patient.Plantype)).Name,
                 //PlanType = presc.Patient.PlanType.planname,
                 Company = presc.Patient.Spons.Sponsortype,
                 Alert = 0,
                 Doctorname = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                 Seenbydoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                 Store = presc.Indentstore.Departmentname,
             })).FirstOrDefault();
            return preseciption;
        }
        public async Task<IEnumerable<LocationDTO>> GetLocations()
        {
            return await _context.Location
                .Select(l => new LocationDTO { Id = l.Locationid, Name = l.Locationname })
                .AsNoTracking().OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<IEnumerable<ProviderDTO>> GetProviders()
        {
            var prov = await _context.ApplicationUser.Select(p => new ProviderDTO
            {
                Id = p.Appuserid,
                Name = p.Lastname+" "+p.Firstname
            })
            .AsNoTracking().OrderBy(p => p.Name).ToListAsync();
            return prov;
        }

        public async Task<IEnumerable<OptionsDTO>> GetStatus()
        {
            var prov = await _context.StatusMaster
                .Where(s=> s.Statustype.Contains("PrescriptionPosting"))
                .Select(s => new OptionsDTO
            {
                Id = s.Statusid,
                Name = s.Status            })
            .AsNoTracking().OrderBy(p => p.Name).ToListAsync();
            return prov;
        }

        public async Task<bool> AddPrescriptionDetails(FullPrescriptionDetailsDTO prescDetails)
        {
            var validPatient = _context.Patient.FromSqlInterpolated($"select * from Patient where patientid = {prescDetails.Patientid}").FirstOrDefault();


            var consultationPresc = _context.ConsultationPrescription
                .FromSqlInterpolated($"select * from Consultation_Prescription where patientid = {prescDetails.Patientid} and prescriptionid = {prescDetails.Prescriptionid}")
                .FirstOrDefault();

            if (validPatient != null && consultationPresc != null)
            {
                var prescDetailObj = new ConsultationPrescriptionDetails
                {
                    EncounterId = consultationPresc.Encounterid,
                    Frequencyid = prescDetails.Frequencyid,
                    Doseformid = prescDetails.Doseformid,
                    Routeid = prescDetails.Routeid,
                    Unitid = prescDetails.Unitid,
                    Icdcode = prescDetails.Icdcode,
                    EmrPrescription = prescDetails.EmrPrescription,
                    Encodeddate = DateTime.Now,
                    Encodedby = prescDetails.Encodedby,
                    ItemId = prescDetails.Itemid,
                    Isapprovedrequired = prescDetails.Isapprovedrequired,
                    Locationid = prescDetails.Locationid,
                    ProviderId = prescDetails.Providerid,
                    Patientid = prescDetails.Patientid,
                    Genericid = prescDetails.Genericid,
                    Strength = prescDetails.Strength,
                    Startdate = prescDetails.Startdate,
                    Refill = prescDetails.Refill,
                    Statusid = _context.StatusMaster.Where(s => s.Statustype == "PrescriptionPosting" && s.Status == "Pending").Select(s => s.Statusid).FirstOrDefault(),
                    PrescriptionDetail = prescDetails.Prescdetail,
                    Prescriptionid = prescDetails.Prescriptionid,
                    Qty = prescDetails.Qty,
                    Strengthvalue = prescDetails.Strengthvalue,
                    Dose = prescDetails.Dose,
                    Durationtype = prescDetails.Durationtype,
                    Medicationinstructions = prescDetails.Medicationinstructions,
                    Formularyid = prescDetails.Formularyid,
                    Doctorid = prescDetails.Doctorid,
                    Dosetime = prescDetails.Dosetime,
                    Issubstitutenotallowed = prescDetails.Issubstitutenotallowed,
                    Isactive = true,
                };

                _context.ConsultationPrescriptionDetails.Add(prescDetailObj);
                await _context.SaveChangesAsync();
                return true;
            }
            else return false;



        }

        public async Task<bool> UpdatePrescriptionDetails(PrescriptionDetailsUpdateDTO prescriptionDetailsUpdateDTO)
        {
            var details = await _context.ConsultationPrescriptionDetails.FindAsync(prescriptionDetailsUpdateDTO.Id);
            details.Statusid = prescriptionDetailsUpdateDTO.Statusid;
            details.Lastchangeby = prescriptionDetailsUpdateDTO.Lastchangeby;
            details.Lastchangedate = DateTime.Now;
            try
            {                var update = await _context.SaveChangesAsync();
                if (update >= 1)
                {
                    return true;
                }
                else return false;
            }
            catch (DbUpdateConcurrencyException) when (!PrescriptionDetailsExist(prescriptionDetailsUpdateDTO.Id))
            {
                return false;
            }
        }

        public async Task<bool> RemovePrescriptionDetails(PrescriptionDetailsRemoveDTO prescriptionDetailsRemoveDTO)
        {
            var details = await _context.ConsultationPrescriptionDetails.FindAsync(prescriptionDetailsRemoveDTO.Id);
            details.Isactive = false;
            details.Lastchangeby = prescriptionDetailsRemoveDTO.Lastchangeby;
            details.Lastchangedate = DateTime.Now;
            if (prescriptionDetailsRemoveDTO.Comment != null)
            {
                details.Comments = prescriptionDetailsRemoveDTO.Comment;

            }

            try
            {
                var update = await _context.SaveChangesAsync();
                if (update >= 1)
                {
                    return true;
                }
                else return false;
            }
            catch (DbUpdateConcurrencyException) when (!PrescriptionDetailsExist(prescriptionDetailsRemoveDTO.Id))
            {
                return false;
            }

        }

    }

   
}


