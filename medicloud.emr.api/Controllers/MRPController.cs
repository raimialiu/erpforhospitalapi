using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MRPController : ControllerBase
  {
    private readonly IMRPRepository _mrpRepository;

    public MRPController(IMRPRepository repository)
    {
      _mrpRepository = repository;
    }

    [HttpGet("GetLatestPrice")]
    public async Task<IActionResult> getLatestPrice(int itemid)
    {
      try
      {
        var latestPrice = await _mrpRepository.getLatestPrice(itemid);       
        
        return Ok(latestPrice);
      }
      catch (Exception ex)
      {       
        var error = "An error occured";
        return BadRequest(error);
      }

    }
  }
}
