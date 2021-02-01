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
        Task<ConsultationPrescriptionDetails> removeConsultationPrescriptionDetailsItem(int prescriptionDetailsId);

        Task<List<PharmacyManagementPrescriptionDetailsDTO>> getAllPrescriptionsDetails();
        Task<List<PharmacyManagementDTO>> getConsultationPrescriptionByPrescriptionId(int prescriptionId);

        Task<List<PharmacyManagementPrescriptionDetailsDTO>> getConsultationPrescriptionsDetailsByPrescriptionId(int prescriptionId);
        bool PrescriptionDetailsExist(int prescriptionDetailsId);
        bool ConsultationPrescriptionExists(int ConsultationPrescriptionId);
        Task<IEnumerable<ProviderDTO>> GetProviders();
        Task<IEnumerable<LocationDTO>> GetLocations();
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

            //if date filtering is selected

            if (prescriptionListFilterModel.Date != prescriptionListFilterModel.defaultDate)
            {
                preseciptionList = await (_context.ConsultationPrescription.AsNoTracking()
              .Where(p =>
              (p.Prescriptiondate == prescriptionListFilterModel.Date) ||
              (p.Locationid == prescriptionListFilterModel.LocationId) ||
              (p.ProviderId == prescriptionListFilterModel.ProviderId)
              )
              //.Include(p => p.Patient).ThenInclude(pt=>pt.PlanType)
              .Skip((prescriptionListFilterModel.PageNumber - 1) * prescriptionListFilterModel.PageSize)
              .Take(prescriptionListFilterModel.PageSize)
             .Select(presc => new PharmacyManagementDTO
             {
                 Facility = presc.Location.Locationname,
                 Prescno = presc.Prescriptionid,
                 Prescdate = presc.Prescriptiondate,
                 Patientname = presc.Patient.Firstname + " " + presc.Patient.Lastname,
                 //Agegender = CalculateAge((DateTime)presc.Patient.Dob) + "/Yrs" + presc.Patient.Gender.Gendername,
                 //Regno = Int16.Parse(presc.Patientid),
                 //PlanType = presc.Patient.PlanType.planname,
                 Company = presc.Patient.Spons.Sponsortype,
                 Alert = 0,
                 Doctorname = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                 Seenbydoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),

                 Store = presc.Indentstore.Departmentname

             })).ToListAsync();

                if (!prescriptionListFilterModel.LocationId.HasValue && !prescriptionListFilterModel.ProviderId.HasValue)
                {
                    int count = _context.ConsultationPrescription.FromSqlInterpolated($"SELECT prescriptionid AS pid FROM Consultation_Prescription WHERE prescriptiondate = {prescriptionListFilterModel.Date}").Count();
                    var prescriptionListWithCount = new PrescriptionListWithCount(preseciptionList, count);
                    return prescriptionListWithCount;
                }
                else if (!prescriptionListFilterModel.LocationId.HasValue && prescriptionListFilterModel.ProviderId.HasValue)
                {
                    int count = _context.ConsultationPrescription.FromSqlInterpolated($"SELECT prescriptionid AS pid FROM Consultation_Prescription WHERE ProviderID = {prescriptionListFilterModel.ProviderId} OR prescriptiondate = {prescriptionListFilterModel.Date}").Count();
                    var prescriptionListWithCount = new PrescriptionListWithCount(preseciptionList, count);
                    return prescriptionListWithCount;
                }
                else if (prescriptionListFilterModel.LocationId.HasValue && !prescriptionListFilterModel.ProviderId.HasValue)
                {
                    int count = _context.ConsultationPrescription.FromSqlInterpolated($"SELECT prescriptionid AS pid FROM Consultation_Prescription WHERE locationid = {prescriptionListFilterModel.LocationId} OR prescriptiondate = {prescriptionListFilterModel.Date}").Count();
                    var prescriptionListWithCount = new PrescriptionListWithCount(preseciptionList, count);
                    return prescriptionListWithCount;
                }
                else
                {
                    int count = _context.ConsultationPrescription.FromSqlInterpolated($"SELECT prescriptionid AS pid FROM Consultation_Prescription WHERE locationid = {prescriptionListFilterModel.LocationId}  OR ProviderID = {prescriptionListFilterModel.ProviderId} OR prescriptiondate == {prescriptionListFilterModel.Date}").Count();
                    var prescriptionListWithCount = new PrescriptionListWithCount(preseciptionList, count);
                    return prescriptionListWithCount;
                }
            }
            else
            {
                //date filtering wasn't selected
                preseciptionList = await (_context.ConsultationPrescription.AsNoTracking()
                    
                  .Where(p =>
                  (p.Locationid == prescriptionListFilterModel.LocationId) ||
                  (p.ProviderId == prescriptionListFilterModel.ProviderId)                   
                  )
                  .Skip((prescriptionListFilterModel.PageNumber - 1) * prescriptionListFilterModel.PageSize)
                  .Take(prescriptionListFilterModel.PageSize)
                 .Select(presc => new PharmacyManagementDTO
                 {
                     Facility = presc.Location.Locationname,
                     Prescno = presc.Prescriptionid,
                     Prescdate = presc.Prescriptiondate,
                     Patientname = presc.Patient.Firstname + " " + presc.Patient.Lastname,
                     //Agegender = CalculateAge((DateTime)presc.Patient.Dob) + "/Yrs" + presc.Patient.Gender.Gendername,
                     //Regno = Int16.Parse(presc.Patientid),
                     //PlanType = presc.Patient.PlanType.planname,

                     Company = presc.Patient.Spons.Sponsortype,
                     Alert = 0,
                     Doctorname = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                     Seenbydoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),

                     Store = presc.Indentstore.Departmentname

                 })).ToListAsync();

                if (!prescriptionListFilterModel.LocationId.HasValue && !prescriptionListFilterModel.ProviderId.HasValue)
                {
                    int count = _context.ConsultationPrescription.Count();
                    var prescriptionListWithCount = new PrescriptionListWithCount(preseciptionList, count);
                    return prescriptionListWithCount;
                }
                else if (!prescriptionListFilterModel.LocationId.HasValue && prescriptionListFilterModel.ProviderId.HasValue)
                {
                    int count = _context.ConsultationPrescription.FromSqlInterpolated($"SELECT prescriptionid AS pid FROM Consultation_Prescription WHERE ProviderID = {prescriptionListFilterModel.ProviderId}").Count();
                    var prescriptionListWithCount = new PrescriptionListWithCount(preseciptionList, count);
                    return prescriptionListWithCount;
                }
                else if (prescriptionListFilterModel.LocationId.HasValue && !prescriptionListFilterModel.ProviderId.HasValue)
                {
                    int count = _context.ConsultationPrescription.FromSqlInterpolated($"SELECT prescriptionid AS pid FROM Consultation_Prescription WHERE locationid = {prescriptionListFilterModel.LocationId}").Count();
                    var prescriptionListWithCount = new PrescriptionListWithCount(preseciptionList, count);
                    return prescriptionListWithCount;
                }
                else
                {
                    int count = _context.ConsultationPrescription.FromSqlInterpolated($"SELECT prescriptionid AS pid FROM Consultation_Prescription WHERE locationid = {prescriptionListFilterModel.LocationId}  OR ProviderID = {prescriptionListFilterModel.ProviderId}").Count();
                    var prescriptionListWithCount = new PrescriptionListWithCount(preseciptionList, count);
                    return prescriptionListWithCount;
                }
            }

        }

        public async Task<ConsultationPrescriptionDetails> removeConsultationPrescriptionDetailsItem(int prescriptionDetailsId)
        {
            var prescriptionDetail = _context.ConsultationPrescriptionDetails.Find(prescriptionDetailsId);
            prescriptionDetail.Isactive = false;
            await _context.SaveChangesAsync();
            return prescriptionDetail;
        }


        public async Task<List<PharmacyManagementPrescriptionDetailsDTO>> getAllPrescriptionsDetails()
        {
            var list = await _context.ConsultationPrescriptionDetails.AsNoTracking()
                   .Select(s => new PharmacyManagementPrescriptionDetailsDTO
                   {
                       Name = _context.DrugGeneric.Where(d => d.Genericid == s.Genericid).Select(e => e.Genericname).FirstOrDefault(),
                       Prescdetails = s.PrescriptionDetail,
                       Prescriptionquantity = (s.Qty).HasValue ? (int)s.Qty : 0,
                       Issuedquantity = (s.Qty).HasValue ? (int)s.Qty : 0,
                       disensedQuantity = (s.Qty).HasValue ? (int)s.Qty : 0,
                       PAno = 0,
                       Status = s.Status.Status,
                       Instructions = s.Medicationinstructions,
                   }).ToListAsync();
            return list;
        }

        public async Task<List<PharmacyManagementPrescriptionDetailsDTO>> getConsultationPrescriptionsDetailsByPrescriptionId(int prescriptionId)
        {
            var list = await _context.ConsultationPrescriptionDetails.AsNoTracking()
                 .Where(e => e.Prescriptionid.Equals(prescriptionId))
                    .Select(s => new PharmacyManagementPrescriptionDetailsDTO
                    {

                        Name = _context.DrugGeneric.Where(d => d.Genericid == s.Genericid).Select(e => e.Genericname).FirstOrDefault(),
                        Prescdetails = s.PrescriptionDetail,
                        Prescriptionquantity = (s.Qty).HasValue ? (int)s.Qty : 0,
                        Issuedquantity = (s.Qty).HasValue ? (int)s.Qty : 0,
                        disensedQuantity = (s.Qty).HasValue ? (int)s.Qty : 0,
                        PAno = 0,
                        Status = s.Status.Status,
                        Instructions = s.Medicationinstructions,
                    }).ToListAsync();
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

        public async Task<List<PharmacyManagementDTO>> getConsultationPrescriptionByPrescriptionId(int prescriptionId)
        {
            var preseciptionList = new List<PharmacyManagementDTO>();
            preseciptionList = await (_context.ConsultationPrescription.AsNoTracking()
            .Where(p => p.Prescriptionid == prescriptionId)
             .Include(p => p.Patient)
             .Select(presc => new PharmacyManagementDTO
             {
                 Facility = presc.Location.Locationname,
                 Prescno = presc.Prescriptionid,
                 Prescdate = presc.Prescriptiondate,
                 Patientname = presc.Patient.Firstname + " " + presc.Patient.Lastname,
                 //Agegender = CalculateAge((DateTime)presc.Patient.Dob) + "/Yrs" + presc.Patient.Gender.Gendername,
                 //Regno = Int16.Parse(presc.Patientid),
                 //PlanType = _context.Plan.SingleOrDefault(pl => pl.Id == Int32.Parse(presc.Patient.Plantype)).Name,
                 //PlanType = presc.Patient.PlanType.planname,
                 Company = presc.Patient.Spons.Sponsortype,
                 Alert = 0,
                 Doctorname = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                 Seenbydoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),

                 Store = presc.Indentstore.Departmentname,

             })).ToListAsync();
            return preseciptionList;
        }
        public async Task<IEnumerable<LocationDTO>> GetLocations()
        {
            return await _context.Location
                .Select(l => new LocationDTO { Id = l.Locationid, Name = l.Locationname })
                .AsNoTracking().OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<IEnumerable<ProviderDTO>> GetProviders()
        {
            var prov = await _context.Provider.Select(p => new ProviderDTO
            {
                Id = p.Id,
                Name = p.Name
            })
            .AsNoTracking().OrderBy(p => p.Name).ToListAsync();
            return prov;

        }

    }


}


