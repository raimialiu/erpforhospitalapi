using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class PatientOrderDetails
    {
        public int Patientorderdetailsid { get; set; }
        public string Patientid { get; set; }
        public int? Patientorderid { get; set; }
        public int? Ordertypeid { get; set; }
        public int? Orderlistid { get; set; }
        public int? Orderstatusid { get; set; }
        public string Result { get; set; }
        public string Ordercomment { get; set; }
        public int? Raisedby { get; set; }
        public int? Completedby { get; set; }
        public string Docpath { get; set; }
        public byte[] Docimage { get; set; }
        public DateTime? Orderdate { get; set; }
        public int? Ordercategoryid { get; set; }
        public int? ProviderId { get; set; }

        public virtual PatientOrder Patientorder { get; set; }
    }
}
