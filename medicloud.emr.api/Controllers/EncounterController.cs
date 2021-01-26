using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using medicloud.emr.api.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncounterController : ControllerBase
    {

        private DataContext _context;
        [HttpGet]
        public IActionResult GetLastestEncounter(string Reg, int FacilityId)
        {
            try
            {
                return Ok(_context.CheckIn.Where(s => s.Patientid == Reg && s.Locationid == FacilityId).OrderBy(s => s.CheckInDate).ToList());

            }
            catch (Exception ex)
            {
                //_logger.LogError($"Something went wrong inside CreateOwner action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
