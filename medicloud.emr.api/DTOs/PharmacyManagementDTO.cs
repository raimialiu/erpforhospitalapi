using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class PharmacyManagementPrescriptionDetailsDTO
    {
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

        public List<PharmacyManagementPrescriptionDetailsDTO> PrescriptionDetails { get; set; }
    }


}
