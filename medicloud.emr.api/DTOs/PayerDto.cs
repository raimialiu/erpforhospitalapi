using medicloud.emr.api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class PayerDto
    {
        public int PayerId { get; set; }
        public string PayerType { get; set; }
        public bool IsinsuranceCompany { get; set; }
        public DateTime? dateadded { get; set; }
        public int? AccountCatId { get; set; }
        public AccountCategory AccountCategory { get; set; }
    }
}
