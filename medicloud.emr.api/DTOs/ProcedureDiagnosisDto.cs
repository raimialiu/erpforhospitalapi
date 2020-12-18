using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class ProcedureDto
    {
        public string ProcedureCode { get; set; }
        public string ProcedureDesc { get; set; }
    }
    
    public class DiagnosisDto
    {
        public string DiagnosisCode { get; set; }
        public string DiagnosisDesc { get; set; }
    }
}
