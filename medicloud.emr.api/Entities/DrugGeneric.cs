using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DrugGeneric
    {
        public int Genericid { get; set; }
        public string Genericname { get; set; }
        public int? CimscategoryId { get; set; }
        public int? CimssubcategoryId { get; set; }
        public bool? Isactive { get; set; }
        public int? Encodedby { get; set; }
        public int? Lastchangeby { get; set; }
        public DateTime? Lastchangedate { get; set; }
        public DateTime? Encodeddate { get; set; }

        public virtual ICollection<ConsultationPrescriptionDetails> ConsultationPrescriptionDetails { get; set; }
    }
}
