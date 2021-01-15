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
    public class PatientQueueController : ControllerBase
    {
        private readonly IPatientQueueRepository _patientQueueRepository;
        public PatientQueueController(IPatientQueueRepository patientQueueRepository)
        {
            _patientQueueRepository = patientQueueRepository;
        }

        [HttpGet, Route("GetPatientQueueListToday")]
        public async Task<IActionResult> GetPatientQueueListToday (int locationId, int accountId)
        {
            try
            {
                var queueList = await _patientQueueRepository.PatientQueuesToday(locationId, accountId);
                return Ok(queueList);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet, Route("DeleteFromQueue")]
        public async Task<IActionResult> DeleteFromQueue (int locationId, int accountId, string patientId)
        {
            try
            {
                await _patientQueueRepository.RemoveFromQueue(patientId, locationId, accountId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet, Route("UpdatePatientQueueLocation")]
        public async Task<IActionResult> UpdatePatientQueueLocation(string patientId, int locationId, int accountId, int hospitalUnitId, int newHospitalUnitId, int encounterId)
        {
            try
            {
                await _patientQueueRepository.UpdatePatientLocation(patientId, locationId, accountId, hospitalUnitId, newHospitalUnitId, encounterId);

                MiniResponseBase response = new MiniResponseBase
                {
                    ErrorMessage = "Success",
                    status = true
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                MiniResponseBase response = new MiniResponseBase
                {
                    ErrorMessage = "failed",
                    status = false
                };
                return BadRequest(response);
            }
        }
    }
}
