using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class ConsultationOrderDto
    {
        public int Id { get; set; }
        public string Patientid { get; set; }
        public int? Locationid { get; set; }
        public int? ProviderId { get; set; }
        public string orderno { get; set; }
        public int? EncounterId { get; set; }
        public int? BedCategoryId { get; set; }
        public int? BillCategoryId { get; set; }
        public string Remarks { get; set; }
        public bool IsActive { get; set; }
        public int? EncodedBy { get; set; }
        public DateTime? EncodedDate { get; set; }
        public DateTime? orderDate { get; set; }
        public int? ordertypeid { get; set; }
        public int? ordercategoryid { get; set; }
        public string LocationName { get; set; }
        public string OrderCategoryName { get; set; }
        public string OrderTypeName { get; set; }
    }
}
