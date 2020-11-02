using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class AssetType
    {
        public AssetType()
        {
            Asset = new HashSet<Asset>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public int? Providerid { get; set; }

        public virtual AccountManager Provider { get; set; }
        public virtual ICollection<Asset> Asset { get; set; }
    }
}
