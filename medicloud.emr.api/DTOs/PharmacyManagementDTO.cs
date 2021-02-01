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

 
        public string Name { get; set; }
        public string Prescdetails { get; set; }
        public int Prescriptionquantity { get; set; }
        public int Issuedquantity { get; set; }
        public int disensedQuantity { get; set; }
        public int PAno { get; set; }
        public string Instructions { get; set; }
        public string Status { get; set; }
    }

    public class PharmacyManagementDTO
    {
        public PharmacyManagementDTO()
        {
        }

   
        public string Facility { get; set; }
        public int? Prescno { get; set; }
        public DateTime? Prescdate { get; set; }
        public UInt32 Regno { get; set; }
        public string Patientname { get; set; }
        public string Plantype { get; set; }
        public string Agegender { get; set; }
        
        public string Company { get; set; }
        public int? Alert { get; set; }
        public string Doctorname { get; set; }
        public string Seenbydoctor { get; set; }

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

    public class PrescriptionWithDetailsDTO
    {
        public string Facility { get; set; }
        public int? Prescno { get; set; }
        public DateTime? Prescdate { get; set; }
        public UInt32 Regno { get; set; }
        public string Patientname { get; set; }
        public string Plantype { get; set; }
        public string Agegender { get; set; }

        public string Company { get; set; }
        public int? Alert { get; set; }
        public string Doctorname { get; set; }
        public string Seenbydoctor { get; set; }

        public string Store { get; set; }
        public List<PrescriptionDetailsDTO> PrescriptionDetails { get; set; }
    }

}
