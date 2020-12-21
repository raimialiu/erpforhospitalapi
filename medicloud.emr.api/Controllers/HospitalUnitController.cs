using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    public class HospitalUnitController : ControllerBase
    {
        private readonly IHospitalUnitRepository _hospitalUnitRepository;
        public HospitalUnitController(IHospitalUnitRepository hospitalUnitRepository)
        {
            _hospitalUnitRepository = hospitalUnitRepository;
        }

        [HttpGet, Route("GetHospitalUnits")]
        public async Task<IActionResult> GetHospitalUnits(int locationId, int accountId)
        {
            try
            {
                var hospitalUnits = await _hospitalUnitRepository.getHospitalUnitList(locationId, accountId);
                return Ok(hospitalUnits);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
