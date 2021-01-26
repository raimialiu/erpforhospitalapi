using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class ConsultationOrderDetailsDto
    {
        public int Id { get; set; }
        public int? serviceId { get; set; }
        public string serviceName { get; set; }
        public int? orderId { get; set; }
        public string orderno { get; set; }
        public string patientid { get; set; }
        public string patientName { get; set; }
        public int? encounterid { get; set; }
        public int? serviceType { get; set; }
        public int? ordertypeid { get; set; }
        public string? OrderTypeName { get; set; }
        public int? ordercategoryid { get; set; }
        public string OrderCategoryName { get; set; }
        public int? DoctorId { get; set; }
        public string DoctorName { get; set; }
        public int? ProviderID { get; set; }
        public int? UnderPackage { get; set; }
        public DateTime? investigationdate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? InvoiceId { get; set; }
        public int? DiagnosisId { get; set; }
        public string DiagnosisName { get; set; }
        public bool IsApprovalRequest { get; set; }
        public bool IsExcluded { get; set; }
        public bool Isactive { get; set; }
        public int? LastChangedBy { get; set; }
        public DateTime? LastChangedDate { get; set; }
        public int? EncodedBy { get; set; }
        public bool IsSupplementary { get; set; }
        public string Remark { get; set; }
        public string PreAuthorizeNo { get; set; }
        public string ApprovalCode { get; set; }
        public bool IsCapitatedService { get; set; }
        public string unit { get; set; }
        public string chargeamount { get; set; }
        public int? tariffid { get; set; }
        public int? plantypeid { get; set; }
        public int? LocationId { get; set; }
        public string LocationName { get; set; }

    }
}
