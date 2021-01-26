using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using medicloud.emr.api.Data;
using medicloud.emr.api.Entities;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class drug_genericController : ControllerBase
    {
        private readonly DataContext _context;

        public drug_genericController(DataContext context)
        {
            _context = context;
        }

        // GET: api/drug_generic
        [HttpGet]
        public IActionResult Getdrug_generic()
        {
            try { 
            return Ok(_context.drug_generic.ToList());
            }
            catch (Exception ex)
            {
                //_logger.LogError($"Something went wrong inside CreateOwner action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

    }
}
