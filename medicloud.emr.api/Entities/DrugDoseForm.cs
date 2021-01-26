using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class DrugDoseForm
    {
        public int DoseFormid { get; set; }
        public string FormulationName { get; set; }
        public string FormulationShortName { get; set; }
        public bool? Iscalculated { get; set; }
        public int? ProviderId { get; set; }
        public int? Isactive { get; set; }
        public int? Encodedby { get; set; }
        public DateTime? EncodedDate { get; set; }
        public int? LastchangedBy { get; set; }
        public DateTime? LastchangedDate { get; set; }
        public int? DefaultRouteId { get; set; }
    }
}
