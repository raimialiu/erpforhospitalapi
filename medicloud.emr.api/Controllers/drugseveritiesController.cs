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
    public class drugseveritiesController : ControllerBase
    {
        private readonly DataContext _context;

        public drugseveritiesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/drugseverities
        [HttpGet]
        public IActionResult Getdrugseverity()
        {
            return Ok(_context.drugseverity.ToList());
        }

        

    }
}
