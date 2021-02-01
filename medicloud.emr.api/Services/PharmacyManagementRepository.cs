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
        
        Task <PrescriptionListWithCount> getConsultationPrescriptionsList(PrescriptionListFilterModel prescriptionListFilterModel);       
        Task<ConsultationPrescriptionDetails>removeConsultationPrescriptionDetailsItem(int prescriptionDetailsId);        
        
        Task<List<PharmacyManagementPrescriptionDetailsDTO>> getAllPrescriptionsDetails();
        Task<List<PharmacyManagementDTO>> getConsultationPrescriptionByPrescriptionId(int prescriptionId);
       
        Task<List<PharmacyManagementPrescriptionDetailsDTO>> getConsultationPrescriptionsDetailsByPrescriptionId(int prescriptionId);
        bool PrescriptionDetailsExist(int prescriptionDetailsId);
        bool ConsultationPrescriptionExists(int ConsultationPrescriptionId);
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

            if (prescriptionListFilterModel.Date > prescriptionListFilterModel.defaultDate)
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
                 PescriptionNo = presc.Prescriptionid,
                 PrescriptionDate = presc.Prescriptiondate,
                 PatientName = presc.Patient.Firstname + " " + presc.Patient.Lastname,
                 Age = CalculateAge((DateTime)presc.Patient.Dob),
                 Gender = presc.Patient.Gender.Gendername,
                 //PlanType = presc.Patient.PlanType.planname,
                 Company = presc.Patient.Spons.Sponsortype,
                 Alert = 0,
                 DoctorName = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                 SeenByDoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),

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
                     PescriptionNo = presc.Prescriptionid,
                     PrescriptionDate = presc.Prescriptiondate,
                     PatientName = presc.Patient.Firstname + " " + presc.Patient.Lastname,
                     Age = CalculateAge((DateTime)presc.Patient.Dob),

                     Gender = presc.Patient.Gender.Gendername,
                     //PlanType = presc.Patient.PlanType.planname,

                     Company = presc.Patient.Spons.Sponsortype,
                     Alert = 0,
                     DoctorName = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                     SeenByDoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),

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
                       DrugName = _context.DrugGeneric.Where(d => d.Genericid == s.Genericid).Select(e => e.Genericname).FirstOrDefault(),
                       PrescriptionDetail = s.PrescriptionDetail,
                       PrescriptionQuantity = (s.Qty).HasValue ? (int)s.Qty : 0,
                       IssuedQuantity = (s.Qty).HasValue ? (int)s.Qty : 0,
                       DispensedQuantity = (s.Qty).HasValue ? (int)s.Qty : 0,
                       PaNo = 0,
                       status = s.Status.Status
                   }).ToListAsync();
            return list;
        }

        public async Task<List<PharmacyManagementPrescriptionDetailsDTO>> getConsultationPrescriptionsDetailsByPrescriptionId(int prescriptionId)
        {
            var list = await _context.ConsultationPrescriptionDetails.AsNoTracking()
                 .Where(e => e.Prescriptionid.Equals(prescriptionId))
                    .Select(s => new PharmacyManagementPrescriptionDetailsDTO
                    {
                        
                        DrugName = _context.DrugGeneric.Where(d => d.Genericid == s.Genericid).Select(e => e.Genericname).FirstOrDefault(),
                        PrescriptionDetail = s.PrescriptionDetail,
                        PrescriptionQuantity = (s.Qty).HasValue ?(int)s.Qty : 0,
                        IssuedQuantity = (s.Qty).HasValue ? (int)s.Qty : 0,
                        DispensedQuantity = (s.Qty).HasValue ? (int)s.Qty : 0,
                        PaNo = 0,
                        status = s.Status.Status
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
            preseciptionList = await(_context.ConsultationPrescription.AsNoTracking()
            .Where(p=> p.Prescriptionid ==prescriptionId)
             .Include(p => p.Patient)
             .Select(presc => new PharmacyManagementDTO
             {
                 Facility = presc.Location.Locationname,
                 PescriptionNo = presc.Prescriptionid,
                 PrescriptionDate = presc.Prescriptiondate,
                 PatientName = presc.Patient.Firstname + " " + presc.Patient.Lastname,
                 Age = CalculateAge((DateTime)presc.Patient.Dob),

                 Gender = presc.Patient.Gender.Gendername,
                 //PlanType = _context.Plan.SingleOrDefault(pl => pl.Id == Int32.Parse(presc.Patient.Plantype)).Name,
                 //PlanType = presc.Patient.PlanType.planname,
                 Company = presc.Patient.Spons.Sponsortype,
                 Alert = 0,
                 DoctorName = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                 SeenByDoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),

                 Store = presc.Indentstore.Departmentname,
                 
             })).ToListAsync();
            return preseciptionList;
        }
    }
}


