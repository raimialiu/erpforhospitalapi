using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities

{
    public partial class StatusMaster
    {
        public StatusMaster()
        {
            ConsultationPrescriptionDetails = new HashSet<ConsultationPrescriptionDetails>();
        }

        public int Statusid { get; set; }
        public string Statustype { get; set; }
        public string Status { get; set; }
        public string Statuscolor { get; set; }
        public string Colorname { get; set; }
        public string Code { get; set; }
        public int? Sequenceno { get; set; }
        public bool? Isactive { get; set; }

        public virtual ICollection<ConsultationPrescriptionDetails> ConsultationPrescriptionDetails { get; set; }
    }
}
