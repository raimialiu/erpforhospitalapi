using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class TotalsPercentDto
    {
        public int TodayTotals { get; set; }
        public decimal PercentIncrease { get; set; }
        public bool isIncrease { get; set; }

    }
}
