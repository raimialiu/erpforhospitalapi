using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Procedure
    {
        public Procedure()
        {
            ProcedureUtilization = new HashSet<ProcedureUtilization>();
        }

        public int Id { get; set; }
        public string Procedurename { get; set; }
        public string Procedurecode { get; set; }
        public string Procedurepa { get; set; }
        public string Procedurepp { get; set; }
        public string Procedurereferral { get; set; }
        public string Procedurepr { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public int? Genderconstraint { get; set; }
        public int? Procedurecatid { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? ProviderId { get; set; }

        public virtual AccountManager Provider { get; set; }
        public virtual ICollection<ProcedureUtilization> ProcedureUtilization { get; set; }
    }
}
