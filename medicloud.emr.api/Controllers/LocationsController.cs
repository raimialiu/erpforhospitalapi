using System.Linq;
using System.Threading.Tasks;
using medicloud.emr.api.Data;
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


    }
}
