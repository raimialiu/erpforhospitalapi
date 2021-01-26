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
    public class allergymastersController : ControllerBase
    {
        private readonly DataContext _context;

        public allergymastersController(DataContext context)
        {
            _context = context;
        }

        // GET: api/allergymasters
        [HttpGet]
        public IActionResult Getallergymaster()
        {
            return Ok(_context.allergymaster.ToList());
        }

        // GET: api/Vitals/5
        [HttpGet("{id}")]
        public IActionResult GetAllergyFliter(int id)
        {
            var AllergyFliter = _context.allergymaster.Where(a => a.typeid == id).ToList();

            if (AllergyFliter == null)
            {
                return NotFound();
            }
            return Ok(AllergyFliter);
        }

        [HttpPost]
        public IActionResult PostAllergyMaster([FromBody] allergymaster AllergyMaster)
        {
            try
            {
                if (AllergyMaster == null)
                {
                    // _logger.LogError("Owner object sent from client is null.");
                    return BadRequest("Owner object is null");
                }

                if (!ModelState.IsValid)
                {
                    //_logger.LogError("Invalid owner object sent from client.");
                    return BadRequest("Invalid model object");
                }

                // var ownerEntity = _mapper.Map<Owner>(owner);

                _context.allergymaster.Add(AllergyMaster);
                _context.SaveChanges();

                // var createdOwner = _mapper.Map<OwnerDto>(ownerEntity);

                //return CreatedAtRoute("OwnerById", new { id = Allergy.Id }, Allergy);
                return StatusCode(201, "Created successfully");

            }
            catch (Exception ex)
            {
                //_logger.LogError($"Something went wrong inside CreateOwner action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }


    }
}
