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
    public class allergytypesController : ControllerBase
    {
        private readonly DataContext _context;

        public allergytypesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/allergytypes
        [HttpGet]
        public IActionResult Getallergytype()
        {
            return Ok(_context.allergytype.ToList());
        }
        [HttpPost]
        public IActionResult PostAllergyType([FromBody] allergytype AllergyType)
        {
            try
            {
                if (AllergyType == null)
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

                _context.allergytype.Add(AllergyType);
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
