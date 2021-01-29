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
        Task<List<PharmacyManagementDTO>> getPrescriptionsList();

        Task<List<PharmacyManagementDTO>> getFilteredPrescriptionsList();
        Task removePrescriptionDetailsItem(int prescriptionDetailsId);
        Task<List<PharmacyManagementDTO>> getPrescriptions();



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

        public async Task<List<PharmacyManagementDTO>> getPrescriptionsList()
        {
            var preseciptionList = new List<PharmacyManagementDTO>();
            preseciptionList = await (_context.ConsultationPrescription.AsNoTracking()
             //.Include(pd => pd.ConsultationPrescriptionDetails)
             .Take(10)
             .Select(presc => new PharmacyManagementDTO
             {    Facility = presc.Location.Locationname,
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
                     //status = pd.Status.Status
                     status = "status"
                 })).ToList()
             })).ToListAsync();

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

        public Task removePrescriptionDetailsItem(int prescriptionDetailsId)
        {
            throw new NotImplementedException();
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




    }
}


