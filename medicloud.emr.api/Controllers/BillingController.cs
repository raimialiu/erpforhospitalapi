using Dapper;
using medicloud.emr.api.DTOs;
using medicloud.emr.api.Entities;
using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillingController : ControllerBase
    {
        private readonly IBillingRepository _billingRepository;
        private SqlConnection _conn;
        private IConfiguration _config;

        public BillingController(IBillingRepository billingRepository, IConfiguration _config)
        {
            this._config = _config;
            _billingRepository = billingRepository;
            string connectionString = _config["ConnectionStrings:lagoonDB"];
            _conn = new SqlConnection(connectionString);
            _conn.Open();
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
        
        [HttpGet("GetPatientDrugTarriff")]
        public async Task<IActionResult> GetPatientDrugTarriff(int accountId, string patientId, int drugid, int locationId)
        {
            try
            {
                var patienttariff = await _billingRepository.getPatientDrugTarriff(accountId, patientId, drugid, locationId);

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
        
        [HttpGet("GetDrugTarriffByDrugId")]
        public async Task<IActionResult> GetDrugTarriffByDrugId(int accountId, int tariffId, int drugid, int locationId)
        {
            try
            {
                var patienttariff = await _billingRepository.getDrugTarrifByDrugId(accountId, tariffId, drugid, locationId);

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
        
        [HttpGet("GetTarrifByServiceCode")]
        public async Task<IActionResult> GetTarrifByServiceCode(int accountId, int tariffid, int servicecode, int locationId)
        {
            try
            {
                //patientId = "1011302952"; servicecode = 145; accountId = 1;

                var patienttariff = await _billingRepository.getTarrifByServiceCode(accountId, tariffid, servicecode, locationId);

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
        
        [Route("GetPatientBillingInvoiceHistory")]
        [HttpGet]
        public async Task<IActionResult> GetPatientBillingInvoiceHistory([FromQuery]int accountId, [FromQuery]string patientId, [FromQuery]int? encounterId)
        {
            //if(encounterId.HasValue)
            //{
            //    var patientBillingHistory = _conn.Query($"select a.*, b.serviceid, b.servicename, b.servicecategoryid, c.servicecategoryname, " +
            //    $"c.servicecategorydesc from Billing_Invoice a join ServiceCode b on a.servicecode = b.serviceid join servicecategory " +
            //    $"c on b.servicecategoryid = c.servicecategoryid where a.patientid = '{patientId}' and a.providerid = {accountId} and encounterid = {encounterId}");
            //    //   var bills = await _billingRepository.GetPatientEncounterBill(accountId, patientId, encounterId);

            //    return Ok(patientBillingHistory);
            //}



            var patientBillingViewHistory = _conn.Query($"select a.*, b.serviceid, b.servicename, b.servicecategoryid, c.servicecategoryname, ck.checkindate,ck.encounterno,ck.encounterid checkinencounterid," +
                $"c.servicecategorydesc from Billing_Invoice a join checkin ck on a.encounterid = ck.encounterid join ServiceCode b on a.servicecode = b.serviceid join servicecategory " +
                $"c on b.servicecategoryid = c.servicecategoryid where a.patientid = '{patientId}' and a.providerid = {accountId}");
          //   var bills = await _billingRepository.GetPatientEncounterBill(accountId, patientId, encounterId);

             return Ok(patientBillingViewHistory);
          
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
        
        [HttpPost("AddBillingInvoice")]
        public async Task<IActionResult> AddBillingInvoice(BillingInvoice billingInvoice)
        {
            try
            {
                var result = await _billingRepository.AddBillInvoice(billingInvoice, null);

                PatientTariffByPayorResponse response = new PatientTariffByPayorResponse()
                {
                    TariffAmount = null,
                    ResponseMessage = result.Item2,
                    Status = result.Item1
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
        
        [HttpPost("AddDrugBillingInvoice")]
        public async Task<IActionResult> AddDrugBillingInvoice(BillingInvoice billingInvoice)
        {
            try
            {
                var result = await _billingRepository.AddDrugBillInvoice(billingInvoice);

                PatientTariffByPayorResponse response = new PatientTariffByPayorResponse()
                {
                    TariffAmount = null,
                    ResponseMessage = result.Item2,
                    Status = result.Item1
                };
                return Ok(response);
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
        

        [HttpGet("PatientBillPayment")]
        public async Task<IActionResult> PatientBillPayment(int accountId, int encounterid, string patientid, decimal amountPaid, int locationid)
        {
            try
            {
                await _billingRepository.ClearPatientEncounterBill(accountId, encounterid, patientid, amountPaid, locationid);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        
        [HttpPost("PatientBillPaymentByPaNumber")]
        public async Task<IActionResult> PatientBillPaymentByPaNumber(BillingInvoicePaymentByPaDto invoicePayment)
        {
            try
            {
                await _billingRepository.ClearPatientEncounterBillByPaCode(invoicePayment);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }



    }
}
