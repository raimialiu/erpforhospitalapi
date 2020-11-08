using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using medicloud.emr.api.DTOs;
using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentRepository _repository;

        public AppointmentsController(IAppointmentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("schedules/{locationid}")]
        public async Task<IActionResult> GetGenSchedules(int locationid)
        {
            var schedules = await _repository.GetGeneralSchedules(locationid);
            return Ok(schedules);
        }

        [HttpPost("schedules/")]
        public async Task<IActionResult> AddGenSchedules(GenSchCreate model)
        {
            await _repository.AddGeneralSchedule(model);
            return NoContent();
        }

        [HttpGet("schedules/{locationid}/specialization/{specid}")]
        public async Task<IActionResult> GetSpecSchedules(int locationid, int specid)
        {
            var schedules = await _repository.GetSpecializationSchedules(locationid, specid);
            return Ok(schedules);
        }

    }
}
