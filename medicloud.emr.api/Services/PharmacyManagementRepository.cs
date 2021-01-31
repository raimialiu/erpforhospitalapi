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
        
        Task<List<PharmacyManagementDTO>> getConsultationPrescriptionsList(PrescriptionListFilterModel prescriptionListFilterModel);       
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
        

        public async Task<List<PharmacyManagementDTO>> getConsultationPrescriptionsList(PrescriptionListFilterModel prescriptionListFilterModel)
        {
            var preseciptionList = new List<PharmacyManagementDTO>();
            preseciptionList = await (_context.ConsultationPrescription.AsNoTracking()             
              .Where(p =>
              (p.Prescriptiondate >= prescriptionListFilterModel.Date) ||
              //this is such that search items can include items without prescriptiondate
              (p.Prescriptiondate == null) ||
              (p.Locationid == prescriptionListFilterModel.LocationId) ||
              (p.ProviderId == prescriptionListFilterModel.ProviderId) 
              )
              .Include(p => p.Patient)
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
                 //PlanType = _context.Plan.SingleOrDefault(pl => pl.Id == Int32.Parse(presc.Patient.Plantype)).Name,

                 Company = presc.Patient.Spons.Sponsortype,
                 Alert = 0,
                 DoctorName = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                 SeenByDoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),

                 Store = presc.Indentstore.Departmentname
              
             })).ToListAsync();         

            return preseciptionList;      


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
                       DrugName = s.DrugGeneric.Genericname,
                       PrescriptionDetail = s.PrescriptionDetail,
                       PrescriptionQuantity = (s.Qty).HasValue ? s.Qty : 0,
                       IssuedQuantity = (s.Qty).HasValue ? s.Qty : 0,
                       DispensedQuantity = (s.Qty).HasValue ? s.Qty : 0,
                       PaNo = 0,
                       status = s.Status.Status
                   }).ToListAsync();
            return list;
        }

        public async Task<List<PharmacyManagementPrescriptionDetailsDTO>> getConsultationPrescriptionsDetailsByPrescriptionId(int prescriptionId)
        {
            var list = await _context.ConsultationPrescriptionDetails.AsNoTracking()
                .Where(e => e.Prescriptionid.Equals(prescriptionId))
                .Where(e=> e.Isactive==true)
                .Select(s => new PharmacyManagementPrescriptionDetailsDTO
                   {
                       DrugName = s.DrugGeneric.Genericname,
                       PrescriptionDetail = s.PrescriptionDetail,
                       PrescriptionQuantity = (s.Qty).HasValue ? s.Qty : 0,
                       IssuedQuantity = (s.Qty).HasValue ? s.Qty : 0,
                       DispensedQuantity = (s.Qty).HasValue ? s.Qty : 0,
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


