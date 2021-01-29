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


    }
    public class PharmacyManagementRepository : IPharmacyManagementRepository
    {
        private int CalculateAge(DateTime Dob)
        {
            DateTime Now = DateTime.Now;
            int Years = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;
            return Years;
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
            var details = new List<PharmacyManagementPrescriptionDetails>();
            details.Add(
               new PharmacyManagementPrescriptionDetails
               {
                   DrugName = "drugname",
                   PrescriptionDetail = "detail",
                   PrescriptionQuantity = 1,
                   IssuedQuantity = 1,
                   DispensedQuantity = 1,
                   PaNo = 0,
                   status = "staus"
               });


            List<PharmacyManagementDTO> preseciptionList = new List<PharmacyManagementDTO>();

            var pd = new PharmacyManagementDTO
            {

                // Facility = _context.ConsultationPrescription.FromSqlRaw("Select TOP 10 remarks from Consultation_Prescription Where Prescriptionid=1 ").FirstOrDefault().ToString(),

                PescriptionNo = 1,
                PrescriptionDate = DateTime.Now,
                PatientName = "name",
                Age = 10,
                Gender = "f",
                PlanType = "plantype",
                Company = "spontye",
                Alert = 0,
                DoctorName = "docname",
                SeenByDoctor = "docname",
                Store = "storename",
                PrescriptionDetails = details
            };
            preseciptionList.Add(pd);
            return preseciptionList;

            //List<PharmacyManagementDTO> preseciptionList = await (
            //    _context.ConsultationPrescription.AsNoTracking()
            //    .Include(l => l.Locationid)
            //    .Include(p => p.Patient)
            //        .ThenInclude(g => new
            //        {
            //            g = g.Gender,
            //            c = g.Spons
            //        })
            //    .Include(s => s.Store)
            //    .Include(pd => pd.ConsultationPrescriptionDetails)
            //    .Select(presc => new PharmacyManagementDTO
            //    {

            //Facility = presc.Location.Locationname,
            //PescriptionNo = presc.PrescriptionId,
            //PrescriptionDate = presc.Prescriptiondate,
            //PatientName = presc.Patient.Firstname + " " + presc.Patient.Lastname,
            //Age = CalculateAge((DateTime)presc.Patient.Dob),
            //Gender = presc.Patient.Gender.Gendername,
            //PlanType = _context.Plan.SingleOrDefault(pl => pl.Id == Int32.Parse(presc.Patient.Plantype)).Name,                    
            //Company = presc.Patient.Spons.Sponsortype,
            //Alert = 0,
            //DoctorName = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
            //SeenByDoctor = _context.ApplicationUser.Where(o => o.Appuserid == presc.Doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
            //Store = presc.Store.Departmentname
            //    PrescriptionDetails = presc.ConsultationPrescriptionDetails.Select(pd => new PharmacyManagementPrescriptionDetails
            //    {
            //        DrugName = pd.DrugGeneric.Genericname,
            //        PrescriptionDetail = pd.PrescriptionDetail,
            //        PrescriptionQuantity = (int)pd.Qty,
            //        IssuedQuantity = (int)pd.Qty,
            //        DispensedQuantity = (int)pd.Qty,
            //        PaNo = 0
            //        status = pd.Status.Status
            //    }).ToList()
            //}
            //        ).ToListAsync()); ; ;

            //    return preseciptionList;
        }

        public Task removePrescriptionDetailsItem(int prescriptionDetailsId)
        {
            throw new NotImplementedException();
        }


    }


}


