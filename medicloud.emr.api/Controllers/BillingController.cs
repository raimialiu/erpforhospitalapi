using medicloud.emr.api.DTOs;
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
    public class BillingController : ControllerBase
    {
        private readonly IBillingRepository _billingRepository;
        public BillingController(IBillingRepository billingRepository)
        {
            _billingRepository = billingRepository;
        }

        [HttpGet("GetPatientTarrifByPayor")]
        public async Task<IActionResult> GetPatientTarrifByPayor(int accountId, string patientId, int servicecode)
        {
            try
            {
                //patientId = "1011302952"; servicecode = 145; accountId = 1;

                var patienttariff = await _billingRepository.getPatientTarrifByPayor(accountId, patientId, servicecode);

                PatientTariffByPayorResponse response = new PatientTariffByPayorResponse()
                {
                    TariffAmount = patienttariff.Item3,
                    ResponseMessage = patienttariff.Item2,
                    Status = patienttariff.Item1
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
    }
}
