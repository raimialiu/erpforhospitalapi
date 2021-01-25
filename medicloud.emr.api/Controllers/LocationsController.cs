using System;
using System.Linq;
using System.Threading.Tasks;
using medicloud.emr.api.Data;
using medicloud.emr.api.Entities;
using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationRepository _repository;

        public LocationsController(ILocationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetLocations() => Ok(await _repository.GetLocations());

        [HttpGet("{locationid}/specializations")]
        public async Task<IActionResult> GetSpecializations(int locationid) => Ok(await _repository.GetSpecializations(locationid));

        [HttpGet("{locationid}/specializations/{specid}/providers")]
        public async Task<IActionResult> GetProviders(int locationid, int specid) => Ok(await _repository.GetProviders(locationid, specid));

        [HttpGet("referraltypes")]
        public async Task<IActionResult> GetReferralTypes() => Ok(await _repository.GetReferralTypes());

        [HttpGet("referringphysicians")]
        public async Task<IActionResult> GetReferringPhysicians() => Ok(await _repository.GetReferringPhysicians());

        [HttpGet("reminderoptions")]
        public async Task<IActionResult> GetReminderOptions()
        {
            try
            {
                var reminder = await _repository.GetReminderOptions();
                return Ok(reminder);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }
        
        [HttpGet("GetAllLocationDetails")]
        public async Task<IActionResult> GetAllLocationDetails()
        {
            try
            {
                var locations = await _repository.GetAllLocationDetails();
                return Ok(locations);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }

        [HttpGet("visittypes")]
        public async Task<IActionResult> GetVisitTypes() => Ok(await _repository.GetVisitTypes());
    }
}
