using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class ConsultationDiagnosisFavouriteDto
    {
        public int Id { get; set; }
        public int? ProviderID { get; set; }
        public int? ICDID { get; set; }
        public string diagnosisName { get; set; }
        public int? doctorid { get; set; }
        public int? encodedby { get; set; }
        public int? lastchangeby { get; set; }
        public bool isactive { get; set; }
        public DateTime encodeddate { get; set; }
        public DateTime lastchangedate { get; set; }
    }
}
