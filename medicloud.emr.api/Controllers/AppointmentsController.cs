using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using medicloud.emr.api.DTOs;
using medicloud.emr.api.Helpers;
using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Mvc;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentRepository _repository;

        public AppointmentsController(IAppointmentRepository repository) => _repository = repository;
      

        [HttpGet("schedules/{locationid}")]
        public async Task<IActionResult> GetGenSchedules(int locationid) => Ok(await _repository.GetGeneralSchedules(locationid));

        [HttpGet("schedules/multipleproviders/({provids})")]
        public async Task<IActionResult> GetActiveGenSchedule([FromRoute] 
        [ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<int> provids) 
        {
            if (provids is null || provids.Count() < 1)
                return BadRequest(new ErrorResponse { ErrorMessage = "Invalid Ids Passed" });
            
            return Ok(await _repository.GetMultipleProviderSchedules(provids));
        }


        [HttpPost("schedules/")]
        public async Task<IActionResult> AddGenSchedules(GenSchCreate model)
        {
            await _repository.AddGeneralSchedule(model);
            return NoContent();
        }

        [HttpGet("schedules/{locationid}/specialization/{specid}")]
        public async Task<IActionResult> GetSpecSchedules(int locationid, int specid)
            => Ok(await _repository.GetSpecializationSchedules(locationid, specid));


        [HttpPost("schedules/{locationid}/specialization")]
        public async Task<IActionResult> AddSpecSchedules(int locationid, SpecSchCreate model)
        {
            if (locationid != model.LocationId) return BadRequest(new ErrorResponse { ErrorMessage = "LocationId does not match" });
            
            await _repository.AddSpecializationSchedule(model);
            return NoContent();
        }

        [HttpGet("schedules/{locationid}/specialization/{specid}/provider/{provid}")]
        public async Task<IActionResult> GetProvSchedules(int locationid, int specid, int provid)
            => Ok(await _repository.GetProviderSchedules(locationid, specid, provid));


        [HttpPost("schedules/{locationid}/specialization/{specid}/provider")]
        public async Task<IActionResult> AddProvSchedules(int locationid, int specid, ProvSchCreate model)
        {
            if (locationid != model.LocationId || specid != model.SpecId) 
                return BadRequest(new ErrorResponse { ErrorMessage = "LocationId/SpecializationId does not match" });

            await _repository.AddProviderSchedule(model);
            return NoContent();
        }

        [HttpGet("statuses")]
        public async Task<IActionResult> GetAppointmentStatuses() => Ok(await _repository.GetStatuses());

        [HttpGet("blocks/{locationid}/provider/{provid}")]
        public async Task<IActionResult> GetBlockSchedules(int locationid, int provid)
            => Ok(await _repository.GetBlockSchedules(locationid, provid));


        [HttpPost("blocks/{locationid}/provider")]
        public async Task<IActionResult> AddBlockSchedules(int locationid, BlockScheduleCreate model)
        {
            if (locationid != model.LocationId)
                return BadRequest(new ErrorResponse { ErrorMessage = "LocationId does not match" });

            await _repository.AddBlockSchedule(model);
            return NoContent();
        }

        [HttpPut("blocks/{blockid}/break")]
        public async Task<IActionResult> BreakBlockSchedule(int blockid)
        {
            bool scheduleRemoved = await _repository.RemoveBlockSchedule(blockid);
            if (!scheduleRemoved)
                return BadRequest(new ErrorResponse { ErrorMessage = "Invalid ID" });

            return NoContent();
        }
    }
}
