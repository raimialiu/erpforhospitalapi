using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using medicloud.emr.api.Data;
using medicloud.emr.api.Entities;
using medicloud.emr.api.DTOs;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultationPrescriptionDetailsController : ControllerBase
    {
        private readonly DataContext _context;

        public ConsultationPrescriptionDetailsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/ConsultationPrescriptionDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsultationPrescriptionDetails>>> GetConsultationPrescriptionDetails()
        {
            return await _context.ConsultationPrescriptionDetails.ToListAsync();
        }

        // GET: api/ConsultationPrescriptionDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConsultationPrescriptionDetails>> GetConsultationPrescriptionDetails(int id)
        {
            var consultationPrescriptionDetails = await _context.ConsultationPrescriptionDetails.FindAsync(id);

            if (consultationPrescriptionDetails == null)
            {
                return NotFound();
            }

            return consultationPrescriptionDetails;
        }

        [HttpGet("GetConsultationPrescriptionDetailsByPatientId/{id}")]
        public async Task<ActionResult<IEnumerable<ConsultationPrescriptionDetails>>> GetConsultationPrescriptionDetailsByPatientId(int id)
        {
            var consultationPrescriptionDetails = await _context.ConsultationPrescriptionDetails
                .Where(e => e.Patientid.Equals(id.ToString())).ToListAsync();
                
                

            if (consultationPrescriptionDetails == null)
            {
                return NotFound();
            }

            return consultationPrescriptionDetails;
        }
       
        // PUT: api/ConsultationPrescriptionDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsultationPrescriptionDetails(int id, ConsultationPrescriptionDetails consultationPrescriptionDetails)
        {
            if (id != consultationPrescriptionDetails.Id)
            {
                return BadRequest();
            }

            _context.Entry(consultationPrescriptionDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsultationPrescriptionDetailsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ConsultationPrescriptionDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ConsultationPrescriptionDetails>> PostConsultationPrescriptionDetails(ConsultationPrescriptionDetails consultationPrescriptionDetails)
        {
            _context.ConsultationPrescriptionDetails.Add(consultationPrescriptionDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConsultationPrescriptionDetails", new { id = consultationPrescriptionDetails.Id }, consultationPrescriptionDetails);
        }

        // DELETE: api/ConsultationPrescriptionDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ConsultationPrescriptionDetails>> DeleteConsultationPrescriptionDetails(int id)
        {
            var consultationPrescriptionDetails = await _context.ConsultationPrescriptionDetails.FindAsync(id);
            if (consultationPrescriptionDetails == null)
            {
                return NotFound();
            }

            _context.ConsultationPrescriptionDetails.Remove(consultationPrescriptionDetails);
            await _context.SaveChangesAsync();

            return consultationPrescriptionDetails;
        }

        private bool ConsultationPrescriptionDetailsExists(int id)
        {
            return _context.ConsultationPrescriptionDetails.Any(e => e.Id == id);
        }
    }
}
