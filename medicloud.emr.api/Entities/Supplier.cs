using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Supplier
    {
        public Supplier()
        {
            Asset = new HashSet<Asset>();
            Drug = new HashSet<Drug>();
            DrugOrders = new HashSet<DrugOrders>();
        }

        public int Supplierid { get; set; }
        public string Suppliername { get; set; }
        public int? Suppliertypeid { get; set; }
        public string Contactname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Bankname { get; set; }
        public string Bankaccountno { get; set; }
        public string Specialty { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? Providerid { get; set; }

        public virtual AccountManager Provider { get; set; }
        public virtual SupplierType Suppliertype { get; set; }
        public virtual ICollection<Asset> Asset { get; set; }
        public virtual ICollection<Drug> Drug { get; set; }
        public virtual ICollection<DrugOrders> DrugOrders { get; set; }
    }
}
