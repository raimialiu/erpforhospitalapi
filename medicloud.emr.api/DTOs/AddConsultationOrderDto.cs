using medicloud.emr.api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class AddConsultationOrderDto
    {
        public List<ConsultationOrderDetails> consultationOrderDetails { get; set; }
        public ConsultationOrders consultationOrder { get; set; }
    }
}
