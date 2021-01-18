using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public partial class DepartmentSub
    {
        public DepartmentSub()
        {
            DiagSampleOplabMain = new HashSet<DiagSampleOplabMain>();
        }

        public int SubDeptId { get; set; }
        public int? Departmenttypeid { get; set; }
        public string Type { get; set; }
        public int? ProviderId { get; set; }
        public int? Departmentid { get; set; }
        public string Subname { get; set; }
        public bool? Isactive { get; set; }
        public int? Encodedby { get; set; }
        public DateTime? Encodeddate { get; set; }
        public bool? Excludeservicedoctorinreport { get; set; }

        public virtual Store Department { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual ICollection<DiagSampleOplabMain> DiagSampleOplabMain { get; set; }
    }
}
