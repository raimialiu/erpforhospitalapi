using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public partial class Store
    {
        public Store()
        {
            ConsultationPrescription = new HashSet<Entities.ConsultationPrescription>();
            DepartmentSub = new HashSet<DepartmentSub>();
            DiagSampleOplabMain = new HashSet<DiagSampleOplabMain>();
        }

        public int DepartmentId { get; set; }
        public string Departmentname { get; set; }
        public int? Locationid { get; set; }
        public bool? Isactive { get; set; }
        public int? Encodedby { get; set; }
        public DateTime? Encodeddate { get; set; }
        public bool? Isallowdisplayinotherstore { get; set; }
        public bool? Isconsumablestore { get; set; }
        public int? ProviderId { get; set; }

        public virtual Location Location { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual ICollection<Entities.ConsultationPrescription> ConsultationPrescription { get; set; }
        public virtual ICollection<DepartmentSub> DepartmentSub { get; set; }
        public virtual ICollection<DiagSampleOplabMain> DiagSampleOplabMain { get; set; }
    }
}
