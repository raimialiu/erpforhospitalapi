using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Asset
    {
        public Asset()
        {
            AssignedAsset = new HashSet<AssignedAsset>();
        }

        public int Id { get; set; }
        public DateTime? Dateadded { get; set; }
        public string Name { get; set; }
        public int? Supplierid { get; set; }
        public string Details { get; set; }
        public int? Typeid { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public int? Locationid { get; set; }
        public string ReceiptNum { get; set; }
        public string Comment { get; set; }
        public int? Providerid { get; set; }

        public virtual Location Location { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual AssetType Type { get; set; }
        public virtual ICollection<AssignedAsset> AssignedAsset { get; set; }
    }
}
