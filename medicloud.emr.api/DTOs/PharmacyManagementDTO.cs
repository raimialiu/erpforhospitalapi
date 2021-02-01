using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class PharmacyManagementPrescriptionDetailsDTO
    {
        public PharmacyManagementPrescriptionDetailsDTO()
        {
        }

        public PharmacyManagementPrescriptionDetailsDTO(string drugName, string prescriptionDetail, int prescriptionQuantity, int issuedQuantity, int dispensedQuantity, int paNo, string status)
        {
            DrugName = drugName;
            PrescriptionDetail = prescriptionDetail;
            PrescriptionQuantity = prescriptionQuantity;
            IssuedQuantity = issuedQuantity;
            DispensedQuantity = dispensedQuantity;
            PaNo = paNo;
            this.status = status;
        }

        public string DrugName { get; set; }
        public string PrescriptionDetail { get; set; }
        public int PrescriptionQuantity { get; set; }
        public int IssuedQuantity { get; set; }
        public int DispensedQuantity { get; set; }
        public int PaNo { get; set; }
        public string status { get; set; }
    }

    public class PharmacyManagementDTO
    {
        public PharmacyManagementDTO()
        {
        }

        public PharmacyManagementDTO(string facility, int? pescriptionNo, DateTime? prescriptionDate, string patientName, int? age, string gender, string planType, string company, int? alert, string doctorName, string seenByDoctor, string store)
        {
            Facility = facility;
            PescriptionNo = pescriptionNo;
            PrescriptionDate = prescriptionDate;
            PatientName = patientName;
            Age = age;
            Gender = gender;
            PlanType = planType;
            Company = company;
            Alert = alert;
            DoctorName = doctorName;
            SeenByDoctor = seenByDoctor;
            Store = store;
        }

        public string Facility { get; set; }
        public int? PescriptionNo { get; set; }
        public DateTime? PrescriptionDate { get; set; }
        public string PatientName { get; set; }

        public int? Age { get; set; }
        public string Gender { get; set; }

        public string PlanType { get; set; }
        public string Company { get; set; }
        public int? Alert { get; set; }
        public string DoctorName { get; set; }
        public string SeenByDoctor { get; set; }

        public string Store { get; set; }

    }

    public class PrescriptionListWithCount
    {
        public List<PharmacyManagementDTO> PrescriptionList { get; set; }
        public int Count;

        public PrescriptionListWithCount(List<PharmacyManagementDTO> preseciptionList, int count)
        {
            PrescriptionList = preseciptionList;
            Count = count;
        }
    }
    public class PrescriptionDetailsListWithCount
    {
        public List<PharmacyManagementPrescriptionDetailsDTO> PrescriptionDetailsList { get; set; }
        public int Count;

        public PrescriptionDetailsListWithCount(List<PharmacyManagementPrescriptionDetailsDTO> prescriptionDetailsList, int count)
        {
            PrescriptionDetailsList = prescriptionDetailsList;
            Count = count;
        }
    }


}
