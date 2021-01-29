using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillingReceiptController : ControllerBase
    {
        private readonly IBillingRepository _billingRepository;
        public BillingReceiptController(IBillingRepository billingRepository)
        {
            _billingRepository = billingRepository;
        }
    }
}
