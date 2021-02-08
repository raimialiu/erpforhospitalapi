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

        public CheckInController(ICheckInRepository checkInRepository)
        {
            _checkInRepository = checkInRepository;
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
