using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class PaRequestExternalDto
    {
        public string EnrolleeName {get; set;}
        public string ProcedureCode {get; set;}
        public string ProcedureDesc {get; set;}
        public string DiagnosisCode {get; set;}
        public string DiagnosisDesc {get; set;}
        public double AmountRequested {get; set;}
        public string ProviderId {get; set;}
        public DateTime EncounterDate { get; set; }
        public string ProviderComment {get; set;}
        public string EnrolleeNumber { get; set;}
        public int Units { get; set; }
    }
    
    public class PaRequestEx
    {
        public List<PaRequestExternalDto> PaRequests { get; set; }

    }

    public class parequest
    {
        public string EnrolleeNumber { get; set; }
        public string ProcedureCode { get; set; }
        public string ProcedureDesc { get; set; }
        public string DiagnosisCode { get; set; }
        public string DiagnosisDesc { get; set; }
        public double AmountRequested { get; set; }
        public int Units { get; set; }
        public string ProviderComment { get; set; }
        public string EnrolleeName { get; set; }
        public string EncounterDate { get; set; }
    }

    public class paRequestResponse
    {
        public int Status_Code { get; set; }
        public string Message { get; set; }
        public int Total { get; set; }
        public string CountSuccess { get; set; }
        public string CountFailed { get; set; }
        public string Errors { get; set; }
    }
}
