using System.Linq;
using System.Threading.Tasks;
using medicloud.emr.api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly DataContext _context;

        public LocationsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetLocations()
        {
            var locations = await _context.Location.Where(l => l.Locationid > 2).Select(x => new { x.Locationid, x.Locationname })
                                                    .ToListAsync();
            return Ok(locations);
        }

    }
}
