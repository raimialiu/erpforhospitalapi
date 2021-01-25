using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class PatientTariffByPayorResponse
    {
        public bool Status { get; set; }
        public string ResponseMessage { get; set; }
        public decimal? TariffAmount { get; set; }
    }
}
