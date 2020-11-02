using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class PatientOrder
    {
        public PatientOrder()
        {
            ConsultationLaboratory = new HashSet<ConsultationLaboratory>();
            PatientOrderDetails = new HashSet<PatientOrderDetails>();
        }

        public int Patientorderid { get; set; }
        public string Patientid { get; set; }
        public int? Ordertypeid { get; set; }
        public int? Orderlistid { get; set; }
        public int? Orderstatusid { get; set; }
        public string Ordercomment { get; set; }
        public int? Raisedby { get; set; }
        public int? Completedby { get; set; }
        public string Docpath { get; set; }
        public byte[] Docimage { get; set; }
        public DateTime? Orderdate { get; set; }
        public int? Ordercategoryid { get; set; }
        public int? ProviderId { get; set; }

        public virtual Personnel CompletedbyNavigation { get; set; }
        public virtual OrderCategory Ordercategory { get; set; }
        public virtual OrderListing Orderlist { get; set; }
        public virtual OrderStatus Orderstatus { get; set; }
        public virtual OrderType Ordertype { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual Personnel RaisedbyNavigation { get; set; }
        public virtual ICollection<ConsultationLaboratory> ConsultationLaboratory { get; set; }
        public virtual ICollection<PatientOrderDetails> PatientOrderDetails { get; set; }
    }
}
