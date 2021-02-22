using medicloud.emr.api.DataContextRepo;
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
    public class CheckInController : ControllerBase
    {
        private readonly ICheckInRepository _checkInRepository;
        private readonly IBillingRepository _billingRepository;
        private readonly IPatientRepo _patientRepo;

        public CheckInController(ICheckInRepository checkInRepository, IPatientRepo patientRepo, IBillingRepository billingRepository)
        {
            _checkInRepository = checkInRepository;
            _billingRepository = billingRepository;
            _patientRepo = patientRepo;
        }

        [HttpGet, Route("GetCheckedInList")]
        public async Task<IActionResult> GetCheckedInList(int locationId, int accountId, string searchword)
        {
            try
            {
                var checkin = await _checkInRepository.GetCheckInList(locationId, searchword, accountId);
                return Ok(checkin);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
            
        }
        
        [HttpGet, Route("GetCheckedInPatient")]
        public async Task<IActionResult> GetCheckedInPatient(int locationId, int accountId, string patientId)
        {
            var checkin = await _checkInRepository.GetCheckedInPatient(locationId, patientId, accountId);
            return Ok(checkin);
        }

        [HttpGet, Route("CheckPatientIn")]
        public async Task<IActionResult> CheckPatientIn(int locationId, int providerId, string patientId, int userid)
        {
            try
            {
                var result = await _checkInRepository.CreaateCheckIn(patientId, providerId, locationId, userid);

                // check that check-In was successfull
                if (result.Item2)
                {
                    var patient = await _patientRepo.GetPatientById(patientId, providerId);

                    var plantype = await _patientRepo.GetPatientPlantype(patient.Plantype);

                    if (plantype != null)
                    {
                        // checks if its a private patient
                        if (plantype.payerid == 1162 && plantype.plantypeid == 32)
                        {
                            // check if this private patient has ever been billed for registration
                            var regBill = await _billingRepository.CheckPrivatePatientBillForRegistration(patientId, providerId);

                            if (regBill == null)
                            {
                                // if there is no registration bill record for this private
                                // patient a reg bill is added for him or her
                                // add bill
                                BillingInvoice regBillingInvoice = new BillingInvoice()
                                {
                                    patientid = patientId,
                                    ProviderID = providerId,
                                    locationid = locationId,
                                    encodedby = userid,
                                    encounterId = result.Item3
                                };

                                var regBillResult = await _billingRepository.WritePatientRegistrationBill(regBillingInvoice);
                            }

                            // add bill
                            BillingInvoice billingInvoice = new BillingInvoice()
                            {
                                patientid = patientId,
                                ProviderID = providerId,
                                locationid = locationId,
                                encodedby = userid,
                                encounterId = result.Item3
                            };

                            // adds consultation bill for this private patieny
                            var billResult = await _billingRepository.WritePatientConsultationBill(billingInvoice);
                        }

                    }
                }

               
                MiniResponseBase response = new MiniResponseBase
                {
                    ErrorMessage = result.Item1,
                    status = result.Item2
                };

                return Ok(response);
                
            }
            catch (Exception ex)
            {
                MiniResponseBase response = new MiniResponseBase
                {
                    ErrorMessage = "An Error Occured patient check-In failed",
                    status = false
                };

                return BadRequest(response);
            }
            
        }
        

        [HttpGet, Route("CheckOutPatient")]
        public async Task<IActionResult> CheckOutPatient(string patientId, int locationId, int accountId)
        {
            await _checkInRepository.CheckOutPatient(patientId, locationId, accountId);
            return NoContent();
        }
        
        [HttpGet, Route("TotalCheckInToday")]
        public async Task<IActionResult> TotalCheckInToday(int locationId, int accountId)
        {
            try
            {
                var result = await _checkInRepository.GetTotalCheckInTodayCount(locationId, accountId);

                TotalsPercentDto response = new TotalsPercentDto
                {
                    isIncrease = result.Item3,
                    TodayTotals = result.Item1,
                    PercentIncrease = result.Item2
                };
                return Ok(response);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }
        
        [HttpGet, Route("GetPatientLatestEncounter")]
        public async Task<IActionResult> GetPatientLatestEncounter(string patientId, int accountId)
        {
            try
            {
                var result = await _checkInRepository.GetPatientLatestEncounter(patientId, accountId);
                
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

    }
}
