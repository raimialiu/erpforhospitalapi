using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class PatientPayorTypesDto
    {
        public int Id { get; set; }
        public string Patientid { get; set; }
        public string Payor { get; set; }
        public int? Payerid { get; set; }
        public string accountcategory { get; set; }
        public string plantype { get; set; }
        public string sponsor { get; set; }
        public string PayerType { get; set; }
        public int? accountid { get; set; }
    }
}
