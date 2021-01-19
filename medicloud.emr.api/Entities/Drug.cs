using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Drug
    {
        public Drug()
        {
            DispensingStore = new HashSet<DispensingStore>();
            DrugOrders = new HashSet<DrugOrders>();
        }

        public int Id { get; set; }
        public string Drugcode { get; set; }
        public string Name { get; set; }
        public int? Drugcategoryid { get; set; }

        public int? Classid{get; set;}
        public string Brandname { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public string Dispensingrate { get; set; }
        public string Indication { get; set; }
        public string Dosage { get; set; }
        public string Contrindications { get; set; }
        public string Adverseeffect { get; set; }
        public int? Supplierid { get; set; }
        public int? Stock { get; set; }
        public DateTime? Expirydate { get; set; }
        public DateTime? Productiondate { get; set; }
        public decimal? Unitprice { get; set; }
        public string Comment { get; set; }
        public DateTime? UploadedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? Providerid { get; set; }
        public int? ReorderQuantity { get; set; }
        public int? LastNotificationId { get; set; }
        public string Drugtype { get; set; }
        public DateTime? Dateadded { get; set; }
        public string Unitofstorage { get; set; }

        public virtual DrugCategory Drugcategory { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<DispensingStore> DispensingStore { get; set; }
        public virtual ICollection<DrugOrders> DrugOrders { get; set; }
    }
}
