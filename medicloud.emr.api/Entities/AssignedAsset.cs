using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class AssignedAsset
    {
        public int Id { get; set; }
        public int? Staffid { get; set; }
        public int? Assetid { get; set; }
        public int? Approverid { get; set; }
        public DateTime? DateAssigned { get; set; }
        public DateTime? DateReturned { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? Providerid { get; set; }

        public virtual Personnel Approver { get; set; }
        public virtual Asset Asset { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual Personnel Staff { get; set; }
    }
}
