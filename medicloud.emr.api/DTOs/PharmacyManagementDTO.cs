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
        public int Id { get; set; }
        public string Prescdetails { get; set; }
        public int? Prescriptionquantity { get; set; }
        public int? Issuedquantity { get; set; }
        public int? disensedQuantity { get; set; }
        public int? PAno { get; set; }
        public string Instructions { get; set; }
        public int? StatusId { get; set; }
        public string Status { get; set; }
        public bool? isActive { get; set; }
        public string Comments { get; set; }
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
        public int Encounterid { get; set; }
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

    public class PrescriptionDetailsUpdateDTO
    {
        public int Id { get; set; }
        public int Statusid { get; set; }
        public int Lastchangeby { get; set; }
    }
    public class PrescriptionDetailsRemoveDTO
    {
        public int Id { get; set; }
        public String Comment { get; set; }        
        public int Lastchangeby { get; set; }
    }

    public class FullPrescriptionDetailsDTO
    {     
        public int Frequencyid { get; set; }
        public int Doseformid { get; set; }
        public int Routeid { get; set; }
        public int Unitid { get; set; }
        public string Icdcode { get; set; }
        public bool EmrPrescription { get; set; }       
        public bool Isactive { get; set; }
        public DateTime Encodeddate { get; set; }
        public int Itemid { get; set; }        
        public bool Issubstitutenotallowed { get; set; }
        public int Locationid { get; set; }
        public int Providerid { get; set; }
        public string Patientid { get; set; }
        public int? Genericid { get; set; }
        public string Strength { get; set; }
        public DateTime Startdate { get; set; }
        public int Refill { get; set; }
        public bool Isapprovedrequired { get; set; }
        public int Prescriptionid { get; set; }
        public int Qty { get; set; }
        public string Prescriptiondetail { get; set; }
        public string Strengthvalue { get; set; }
        public int Dose { get; set; }
        public int Durationtype { get; set; }
        public string Medicationinstructions { get; set; }
        public int Formularyid { get; set; }
        public int Doctorid { get; set; }
        public int Dosetime { get; set; }
        public int Drugid { get; set; }
        public string Prescdetail { get; set; }
        public int Encodedby { get; set; }

    }

}
