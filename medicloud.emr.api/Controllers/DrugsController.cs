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
    public class DrugsController : ControllerBase
    {
        private readonly DataContext _context;

        public DrugsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Drugs
        [HttpGet]
        public IActionResult GetDrug()
        {

            //return Ok(_context.Drug.ToList());
            return Ok(_context.Drug.Where(a => a.Drugcategoryid == 31).ToList());
        }

        // GET: api/Vitals/5
        [HttpGet("{id}")]
        public IActionResult GetDrugsFliter(int id)
        {
            var DrugsFliter = _context.Drug.Where(a => a.genericid == id).ToList();

            if (DrugsFliter == null)
            {
                return NotFound();
            }
            return Ok(DrugsFliter);
        }
    }
}
