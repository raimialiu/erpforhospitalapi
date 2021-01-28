using medicloud.emr.api.DTOs;
using medicloud.emr.api.Entities;
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
        public async Task<IActionResult> GetPatientTarrifByPayor(int accountId, string patientId, int servicecode, int locationId)
        {
            try
            {
                //patientId = "1011302952"; servicecode = 145; accountId = 1;

                var patienttariff = await _billingRepository.getPatientTarrifByPayor(accountId, patientId, servicecode, locationId);

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
        
        [HttpGet("GetPatientEncounterBill")]
        public async Task<IActionResult> GetPatientEncounterBill(int accountId, string patientId, int? encounterId)
        {
            try
            {
                var bills = await _billingRepository.GetPatientEncounterBill(accountId, patientId, encounterId);

                return Ok(bills);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        
        [HttpGet]
        public async Task<IActionResult> GetPatientBillingInvoiceHistory(int accountId, string patientId, int? encounterId)
        {
          
             var bills = await _billingRepository.GetPatientEncounterBill(accountId, patientId, encounterId);

             return Ok(bills);
          
        }

        [HttpGet("GetTariffs")]
        public async Task<IActionResult> GetTariffs(int accountId)
        {
            try
            {
                var tariffs = await _billingRepository.GetTariffs(accountId);

                return Ok(tariffs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        
        [HttpGet("GetBillingTypes")]
        public async Task<IActionResult> GetBillingTypes(int accountId)
        {
            try
            {
                var billtypes = await _billingRepository.GetBillingTypes(accountId);

                return Ok(billtypes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        
        [HttpGet("GetServiceCodes")]
        public async Task<IActionResult> GetServiceCodes(int accountId, int tariffId, int serviceId)
        {
            try
            {
                var billtypes = await _billingRepository.GetServiceCodes(accountId, tariffId, serviceId);

                return Ok(billtypes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPost("AddPrivatePatientRegistrationBillingInvoice")]
        public async Task<IActionResult> AddPrivatePatientRegistrationBillingInvoice (BillingInvoice billingInvoice)
        {
            try
            {
                //patientId = "1011302952"; servicecode = 145; accountId = 1;

                var _billingInvoice = await _billingRepository.WritePatientRegistrationBill(billingInvoice);

                PatientTariffByPayorResponse response = new PatientTariffByPayorResponse()
                {
                    TariffAmount = _billingInvoice.Item3,
                    ResponseMessage = _billingInvoice.Item2,
                    Status = _billingInvoice.Item1
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
        
        [HttpPost("UpdateBillingInvoice")]
        public async Task<IActionResult> UpdateBillingInvoice (BillingInvoice billingInvoice)
        {
            try
            {
                await _billingRepository.UpdateBillInvoice(billingInvoice);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPost("AddPrivatePatientConsultationBillingInvoice")]
        public async Task<IActionResult> AddPrivatePatientConsultationBillingInvoice (BillingInvoice billingInvoice)
        {
            try
            {
                //patientId = "1011302952"; servicecode = 145; accountId = 1;

                var _billingInvoice = await _billingRepository.WritePatientConsultationBill(billingInvoice);

                PatientTariffByPayorResponse response = new PatientTariffByPayorResponse()
                {
                    TariffAmount = _billingInvoice.Item3,
                    ResponseMessage = _billingInvoice.Item2,
                    Status = _billingInvoice.Item1
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }


        [HttpGet("GetPatientBillingInvoice")]
        public async Task<IActionResult> GetPatientBillingInvoice(int accountId, int billId, string patientId)
        {
            try
            {
                var billtypes = await _billingRepository.GetPatientBillingInvoice(accountId, billId, patientId);

                return Ok(billtypes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        
        [HttpGet("CheckIfInvoicePaymentHasBeenMade")]
        public async Task<IActionResult> CheckIfInvoicePaymentHasBeenMade(int accountId, int billId, decimal billamount)
        {
            try
            {
                var result = await _billingRepository.GetBillingInvoiceOutstanding(billId, accountId, billamount);

                if (result.Item2 > 0)
                {
                    return Ok(true);
                }
                else
                {
                    return Ok(false);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }



    }
}
