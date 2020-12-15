using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class ReferenceMaterial
    {
        public int Id { get; set; }
        public string Patientid { get; set; }
        public int ProviderId { get; set; }
        public string Title { get; set; }
        public string Filepath { get; set; }
        public DateTime? Dateadded { get; set; }
        public string Type { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual AccountManager Provider { get; set; }
    }
}
