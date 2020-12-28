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
    public class PayorInsuranceController: ControllerBase
    {
        private readonly IPayerInsuranceRepository _payerInsuranceRepository;
        public PayorInsuranceController(IPayerInsuranceRepository payerInsuranceRepository)
        {
            _payerInsuranceRepository = payerInsuranceRepository;
        }


        [HttpGet, Route("GetPayerInsuranceInfo")]
        public async Task<IActionResult> GetPayerInsuranceInfo(string payerId)
        {
            try
            {
                var result = await _payerInsuranceRepository.GetPatientPayerInfo(payerId);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
