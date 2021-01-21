using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class OrderPriority
    {
        public OrderPriority()
        {
            //ConsultationPrescription = new HashSet<ConsultationPrescription>();
        }

        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public int? Locationid { get; set; }
        public string Indenttype { get; set; }
        public int? Isactive { get; set; }
        public int? Encodedby { get; set; }
        public DateTime? Encodeddate { get; set; }
        public int? Lastchangeby { get; set; }
        public DateTime? Lastchangedate { get; set; }
        public string Indentcode { get; set; }

        public virtual Location Location { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual ICollection<ConsultationPrescription> ConsultationPrescription { get; set; }
    }
}
