using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class PaRequestViewModel
    {
        public int parequestid { get; set; }
        public int accountid { get; set; }
        public int locationid { get; set; }
        public string pastatus { get; set; }
        public string panumber { get; set; }
        public string procedurecode { get; set; }
        public string proceduredesc { get; set; }
        public string diagnosiscode { get; set; }
        public string diagnosisdesc { get; set; }
        public decimal unitcharge { get; set; }
        public decimal quantity { get; set; }
        public string issuercomment { get; set; }
        public DateTime? requestdate { get; set; }
        public string patientid { get; set; }
        public string patientname { get; set; }
        public string enrolleenumber { get; set; }
    }


    public class PaRequestHistorApiViewModel
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public DateTime? DateAdded { get; set; }
        public string RequestParameters { get; set; }
        public long? PANumber { get; set; }
        public double? AmountGranted { get; set; }
        public double? AmountRequested { get; set; }
        public string ProcedureCode { get; set; }
        public string ProcedureDesc { get; set; }
        public string DiagnosisCode { get; set; }
        public string DiagnosisDesc { get; set; }
        public int? Units { get; set; }
        public string Status { get; set; }
        public string IssuerComment { get; set; }
        public string ProviderComment { get; set; }
        public string RequestTracker { get; set; }
        public string DenialReasons { get; set; }
        public DateTime? Requestdate { get; set; }
        public DateTime? EncounterDate { get; set; }
        public DateTime? TimePicked { get; set; }
        public DateTime? ResolutionTime { get; set; }
        public string EnrolleeNumber { get; set; }
        public string EnrolleeName { get; set; }
        public string Adjuster { get; set; }
        public bool IsOpen { get; set; }
        public bool IsPicked { get; set; }
        public bool ReceivedByProvider { get; set; }
    }
}
