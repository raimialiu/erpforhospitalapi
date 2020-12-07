using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class PaRequestViewModel
    {
        public int parequestid { get; set; }
        public int accountid { get; set; }
        public int locationid { get; set; }
        public string pastatus { get; set; }
        public string panumber { get; set; }
        public int procedureid { get; set; }
        public string procedurename { get; set; }
        public int diagnosisid { get; set; }
        public string diagnosisname { get; set; }
        public decimal unitcharge { get; set; }
        public decimal quantity { get; set; }
        public string issuercomment { get; set; }
        public DateTime? requestdate { get; set; }
        public string patientid { get; set; }
        public string patientname { get; set; }
    }
}
