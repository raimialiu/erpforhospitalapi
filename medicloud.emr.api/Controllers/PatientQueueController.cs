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
    }
}
