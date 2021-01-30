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
        //Task<List<Pres>>
        //getPrescriptionsList

        //getFilteredPrescriptions
        //removePrescriptionDetailsItem
        //addPrescriptionDetailsItem ?
        Task<List<PharmacyManagementDTO>> getPrescriptionsList(QueryListParameters prescriptionListParameters);

        Task<List<PharmacyManagementDTO>> getFilteredPrescriptionsList();
        Task<ConsultationPrescriptionDetails>removePrescriptionDetailsItem(int prescriptionDetailsId);
        Task<List<PharmacyManagementDTO>> getPrescriptions();
        Task<List<PharmacyManagementPrescriptionDetailsDTO>> getPatientPrescriptionsList(string patientId);
        Task<List<PharmacyManagementPrescriptionDetailsDTO>> getAllPrescriptionsDetails();
        Task<List<PharmacyManagementDTO>> getPrescriptionByPrescriptionId(int prescriptionId);
        Task<List<ConsultationPrescriptionDetails>> getPatientPrescriptionsListAll(string patientId);
        Task<List<PharmacyManagementPrescriptionDetailsDTO>> getPrescriptionsDetailsByPrescriptionId(int prescriptionId);
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
        public Task<List<PharmacyManagementDTO>> getFilteredPrescriptionsList()
        {

            throw new NotImplementedException();



        }

        public async Task<List<PharmacyManagementDTO>> getPrescriptionsList(QueryListParameters prescriptionListParameters)
        {
            var preseciptionList = new List<PharmacyManagementDTO>();
            preseciptionList = await (_context.ConsultationPrescription.AsNoTracking()
             .Include(p => p.Patient)
              .Skip((prescriptionListParameters.PageNumber - 1) * prescriptionListParameters.PageSize)
              .Take(prescriptionListParameters.PageSize)
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
                 PrescriptionDetails = (presc.ConsultationPrescriptionDetails.Select(pd => new PharmacyManagementPrescriptionDetailsDTO
                 {
                     DrugName = pd.DrugGeneric.Genericname,
                     PrescriptionDetail = pd.PrescriptionDetail,
                     PrescriptionQuantity = (int)pd.Qty,
                     IssuedQuantity = (int)pd.Qty,
                     DispensedQuantity = (int)pd.Qty,
                     PaNo = 0,
                     status = pd.Status.Status
                 })).ToList()
             })).ToListAsync();

            //var preseciptionList = new List<PharmacyManagementDTO>();
            //var preseciptionListF =  (_context.ConsultationPrescription.AsNoTracking()
            //   .Include(p => p.Patient)
            //   .Take(10)
            //   .Select(presc => new
            //   {
            //       Facility = presc.Location.Locationname,
            //       PescriptionNo = presc.Prescriptionid,
            //       PrescriptionDate = presc.Prescriptiondate,
            //       PatientName = presc.Patient.Firstname + " " + presc.Patient.Lastname,
            //       Age = CalculateAge((DateTime)presc.Patient.Dob),

            //       Gender = presc.Patient.Gender.Gendername,
            //       //PlanType = _context.Plan.SingleOrDefault(pl => pl.Id == Int32.Parse(presc.Patient.Plantype)).Name,

            //       Company = presc.Patient.Spons.Sponsortype,
            //       Alert = 0,
            //       DoctorName = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
            //       SeenByDoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),

            //       Store = presc.Indentstore.Departmentname,
            //       PrescriptionDetails = (presc.ConsultationPrescriptionDetails.Select(pd => new PharmacyManagementPrescriptionDetailsDTO
            //       {
            //           DrugName = pd.DrugGeneric.Genericname,
            //           PrescriptionDetail = pd.PrescriptionDetail,
            //           PrescriptionQuantity = (int)pd.Qty,
            //           IssuedQuantity = (int)pd.Qty,
            //           DispensedQuantity = (int)pd.Qty,
            //           PaNo = 0,
            //           status = pd.Status.Status
            //       }))
            //   })).AsEnumerable();
            //preseciptionList= preseciptionListF.Select(pl => new PharmacyManagementDTO
            //    {
            //        Facility = pl.Facility,
            //        PescriptionNo = pl.PescriptionNo,
            //        PrescriptionDate = pl.PrescriptionDate,
            //        PatientName = pl.PatientName,
            //        Age = pl.Age,

            //        Gender = pl.Gender,
            //        //PlanType = _context.Plan.SingleOrDefault(pl => pl.Id == Int32.Parse(presc.Patient.Plantype)).Name,

            //        Company = pl.Company,
            //        Alert = 0,
            //        DoctorName = pl.DoctorName,
            //        SeenByDoctor = pl.SeenByDoctor,

            //        Store = pl.Store,
            //        PrescriptionDetails = pl.PrescriptionDetails.ToList()
            //    }).ToList();

            return preseciptionList;
            //var details = new List<PharmacyManagementPrescriptionDetailsDTO>();
            //details.Add(
            //   new PharmacyManagementPrescriptionDetailsDTO
            //   {
            //       DrugName = "drugname",
            //       PrescriptionDetail = "detail",
            //       PrescriptionQuantity = 1,
            //       IssuedQuantity = 1,
            //       DispensedQuantity = 1,
            //       PaNo = 0,
            //       status = "staus"
            //   });


            //List<PharmacyManagementDTO> preseciptionList = new List<PharmacyManagementDTO>();

            ////var pd = new PharmacyManagementDTO
            ////{

            //var list = await _context.ConsultationPrescription.Where(e => e.Prescriptionid < 10).ToListAsync();



            //Facility = _context.ConsultationPrescription.Where(e=> e.Prescriptionid==1).Select(e => e.Patient.Firstname).ToString(),

            //    PescriptionNo = 1,
            //    PrescriptionDate = DateTime.Now,
            //    PatientName = "name",
            //    Age = 10,
            //    Gender = "f",
            //    PlanType = "plantype",
            //    Company = "spontye",
            //    Alert = 0,
            //    DoctorName = "docname",
            //    SeenByDoctor = "docname",
            //    Store = "storename",
            //    PrescriptionDetails = details
            //};
            //preseciptionList.Add(pd);
            //return preseciptionList;


        }

        public async Task<ConsultationPrescriptionDetails> removePrescriptionDetailsItem(int prescriptionDetailsId)
        {
            var prescriptionDetail = _context.ConsultationPrescriptionDetails.Find(prescriptionDetailsId);
            prescriptionDetail.Isactive = false;            
            await _context.SaveChangesAsync();
            return prescriptionDetail;
        }

        public Task<List<PharmacyManagementDTO>> getPrescriptions()
        {
            //var preseciptionList = new List<PharmacyManagementDTO>();
            //preseciptionList = await (_context.ConsultationPrescription.AsNoTracking()
            // //.Include(pd => pd.ConsultationPrescriptionDetails)
            // .Take(10)
            // .Select(presc => new PharmacyManagementDTO
            // {    Facility = presc.Location.Locationname,
            //     PescriptionNo = presc.Prescriptionid,
            //     PrescriptionDate = presc.Prescriptiondate,
            //     PatientName = presc.Patient.Firstname + " " + presc.Patient.Lastname,
            //     Age = CalculateAge((DateTime)presc.Patient.Dob),
            //     Gender = presc.Patient.Gender.Gendername,
            //     PlanType = _context.Plan.SingleOrDefault(pl => pl.Id == Int32.Parse(presc.Patient.Plantype)).Name,
            //     Company = presc.Patient.Spons.Sponsortype,
            //     Alert = 0,
            //     DoctorName = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
            //     SeenByDoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
            //     //Store = presc.Store.Departmentname
            //     Store = presc.Indentstore.Departmentname,
            //     PrescriptionDetails = (presc.ConsultationPrescriptionDetails.Select(pd => new PharmacyManagementPrescriptionDetailsDTO
            //     {
            //         DrugName = pd.DrugGeneric.Genericname,
            //         PrescriptionDetail = pd.PrescriptionDetail,
            //         PrescriptionQuantity = (int)pd.Qty,
            //         IssuedQuantity = (int)pd.Qty,
            //         DispensedQuantity = (int)pd.Qty,
            //         PaNo = 0,
            //         //status = pd.Status.Status
            //         status = "status"
            //     })).ToList()
            // })).ToListAsync();

            //return preseciptionList;

            return null;


        }

        public async Task<List<PharmacyManagementPrescriptionDetailsDTO>> getPatientPrescriptionsList(string patientId)
        {
            var list = await _context.ConsultationPrescriptionDetails.AsNoTracking()
                .Where(e => e.Patientid.Equals(patientId))
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

        public async Task<List<ConsultationPrescriptionDetails>> getPatientPrescriptionsListAll(string patientId)
        {
            var list = await _context.ConsultationPrescriptionDetails.AsNoTracking()
                .Where(e => e.Patientid.Equals(patientId))
                   .ToListAsync();
            return list;
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

        public async Task<List<PharmacyManagementPrescriptionDetailsDTO>> getPrescriptionsDetailsByPrescriptionId(int prescriptionId)
        {
            var list = await _context.ConsultationPrescriptionDetails.AsNoTracking()
                .Where(e => e.Prescriptionid.Equals(prescriptionId))
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

       

        bool IPharmacyManagementRepository.PrescriptionDetailsExist(int prescriptionDetailsId)
        {
            return _context.ConsultationPrescriptionDetails.Any(e => e.Id == prescriptionDetailsId);
        }

        bool IPharmacyManagementRepository.ConsultationPrescriptionExists(int ConsultationPrescriptionId)
        {
            return _context.ConsultationPrescription.Any(e => e.Consultationid == ConsultationPrescriptionId);
        }

        public async Task<List<PharmacyManagementDTO>> getPrescriptionByPrescriptionId(int prescriptionId)
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
                 PrescriptionDetails = (_context.ConsultationPrescriptionDetails.Where(e=> e.Prescriptionid== presc.Prescriptionid)
                .Select(pd => new PharmacyManagementPrescriptionDetailsDTO
                 {
                     DrugName = pd.DrugGeneric.Genericname,
                     PrescriptionDetail = pd.PrescriptionDetail,
                     PrescriptionQuantity = (int)pd.Qty,
                     IssuedQuantity = (int)pd.Qty,
                     DispensedQuantity = (int)pd.Qty,
                     PaNo = 0,
                     status = pd.Status.Status
                 })).ToList()
             })).ToListAsync();
            return preseciptionList;
        }
    }
}


