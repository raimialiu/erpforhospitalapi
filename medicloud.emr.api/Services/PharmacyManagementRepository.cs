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

        Task<PrescriptionListWithCount> getConsultationPrescriptionsList(PrescriptionListFilterModel prescriptionListFilterModel);
        Task<bool> UpdateConsultationPrescriptionDetails(int id, PharmacyManagementPrescriptionDetailsDTO phar);
        Task<List<PharmacyManagementPrescriptionDetailsDTO>> getAllPrescriptionsDetails();
        PharmacyManagementDTO getConsultationPrescriptionByPrescriptionId(int prescriptionId);

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
               .Where(p => (p.Patientid != null) && 
                       (((p.Prescriptiondate == prescriptionListFilterModel.Date) ||
                       (p.Locationid == prescriptionListFilterModel.LocationId) ||
                       (p.ProviderId == prescriptionListFilterModel.ProviderId))) && 
                       (_context.ConsultationPrescriptionDetails.Any(pd => pd.Prescriptionid == p.Prescriptionid)))
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
               .Where(p => (p.Patientid != null) && (
                       ((p.Prescriptiondate == prescriptionListFilterModel.Date) ||
                       (p.Locationid == prescriptionListFilterModel.LocationId))) &&
                       (_context.ConsultationPrescriptionDetails.Any(pd => pd.Prescriptionid == p.Prescriptionid)))
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
               .Where(p => (p.Patientid != null) && (
                       ((p.Prescriptiondate == prescriptionListFilterModel.Date) ||
                       (p.ProviderId == prescriptionListFilterModel.ProviderId))) &&
                       (_context.ConsultationPrescriptionDetails.Any(pd => pd.Prescriptionid == p.Prescriptionid)))
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

                  .Where(p => (p.Patientid != null) && (
                      (p.Locationid == prescriptionListFilterModel.LocationId) ||
                      (p.ProviderId == prescriptionListFilterModel.ProviderId)) &&
                      (_context.ConsultationPrescriptionDetails.Any(pd => pd.Prescriptionid == p.Prescriptionid)))
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

                  .Where(p => (p.Patientid != null) && 
                          ((p.Locationid == prescriptionListFilterModel.LocationId))
                          && (_context.ConsultationPrescriptionDetails.Any(pd => pd.Prescriptionid == p.Prescriptionid)))
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
               .Where(p => (p.Patientid != null) && 
                            (p.Locationid == prescriptionListFilterModel.LocationId) && 
                            (_context.ConsultationPrescriptionDetails.Any(pd => pd.Prescriptionid == p.Prescriptionid)))
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
               .Where(p => (p.Patientid != null) &&
                       (p.Prescriptiondate == prescriptionListFilterModel.Date) && 
                       (_context.ConsultationPrescriptionDetails.Any(pd => pd.Prescriptionid == p.Prescriptionid)))
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
              .Where(p => p.Patientid != null && 
                     ( _context.ConsultationPrescriptionDetails.Any(pd => pd.Prescriptionid == p.Prescriptionid))
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



        public async Task<bool> UpdateConsultationPrescriptionDetails(int id, PharmacyManagementPrescriptionDetailsDTO prescriptionDetailsDTO) {
    
            if (id == prescriptionDetailsDTO.Id)
            {
                var prescriptionDetail = await _context.ConsultationPrescriptionDetails.FindAsync(id);
                if (prescriptionDetail == null)
                {
                    return false;
                }
                prescriptionDetail.Isactive = prescriptionDetailsDTO.isActive;
                prescriptionDetail.Comments = prescriptionDetailsDTO.Comments;
                prescriptionDetail.Statusid = prescriptionDetailsDTO.StatusId;

                try
                {
                    _context.Entry(prescriptionDetail).State = EntityState.Modified;
                    var update = await _context.SaveChangesAsync();
                    if (update < 0) { return false; }
                    return true;
                }
                catch (DbUpdateConcurrencyException) when (!PrescriptionDetailsExist(id))
                {
                    return false;
                }
            }
            else return false;
           

        }
        

        public async Task<List<PharmacyManagementPrescriptionDetailsDTO>> getAllPrescriptionsDetails()
        {
            var list = await _context.ConsultationPrescriptionDetails.AsNoTracking()
                   .Select(s => new PharmacyManagementPrescriptionDetailsDTO
                   {
                       Name = _context.Drug.Where(d => d.Id == s.ItemId).Select(e => e.Name).FirstOrDefault(),
                       Prescdetails = s.PrescriptionDetail,
                       Prescriptionquantity = (s.Qty).HasValue ? (int)s.Qty : 0,
                       Issuedquantity = (s.Qty).HasValue ? (int)s.Qty : 0,
                       disensedQuantity = (s.Qty).HasValue ? (int)s.Qty : 0,
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
                 .Where(e => e.Prescriptionid.Equals(prescriptionId) && e.ItemId!=null)
                    .Select(s => new PharmacyManagementPrescriptionDetailsDTO
                    {   Name = _context.Drug.Where(d => d.Id == s.ItemId).Select(e => e.Name).FirstOrDefault(),
                        Prescdetails = s.PrescriptionDetail,
                        Prescriptionquantity = (s.Qty).HasValue ? (int)s.Qty : 0,
                        Issuedquantity = (s.Qty).HasValue ? (int)s.Qty : 0,
                        disensedQuantity = (s.Qty).HasValue ? (int)s.Qty : 0,
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
                .Where(s=> s.Status =="pending" || s.Status=="dispensed" || s.Status=="partially dispensed")
                .Select(s => new OptionsDTO
            {
                Id = s.Statusid,
                Name = s.Status            })
            .AsNoTracking().OrderBy(p => p.Name).ToListAsync();
            return prov;
        }

    }


}


