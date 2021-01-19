using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DrugFormulary
    {
        public int FormulationId { get; set; }
        public string FormulationName { get; set; }
        public string FormulationShortName { get; set; }
        public bool? Iscalculated { get; set; }
        public int? ProviderId { get; set; }
        public bool? Isactive { get; set; }
        public int? EncodedBy { get; set; }
        public DateTime? EncodedDate { get; set; }
        public int? LastChangeBy { get; set; }
        public DateTime? LastChangeDate { get; set; }
        public int? DefaultRouteId { get; set; }

        public virtual AccountManager Provider { get; set; }
    }
}
