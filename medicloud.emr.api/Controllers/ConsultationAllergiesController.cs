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
    public class ConsultationAllergiesController : ControllerBase
    {
        private readonly DataContext _context;

        public ConsultationAllergiesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Allergy
        [HttpGet]
        public IActionResult GetAllergy()
        {
            return Ok(_context.consultation_allergy.ToList());
        }

        [HttpPost]
        public IActionResult PostAllergy([FromBody] ConsultationAllergy Allergy)
        {
            try
            {
                if (Allergy == null)
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

                _context.consultation_allergy.Add(Allergy);
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



        // GET: api/Vitals/5
        [HttpGet("{id}")]
        public IActionResult GetAllergy(int id)
        {
            var vital = _context.consultation_allergy.Find(id);

            if (vital == null)
            {
                return NotFound();
            }
            return Ok(vital);
        }


        [HttpPut("{id}")]
        public IActionResult PutAllergy(ConsultationAllergy Allergy)
        {
            try
            {

                var existingAllergy = _context.consultation_allergy.Where(s => s.Id == Allergy.Id)
                                                           .FirstOrDefault();

                if (existingAllergy != null)
                {
                    existingAllergy.remarks = Allergy.remarks;

                    _context.SaveChanges();
                }
                else
                {
                    return NotFound();
                }

                return Ok();

            }
            catch (Exception ex)
            {
                //_logger.LogError($"Something went wrong inside CreateOwner action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        // GET api/user/firstname/lastname/address
        [HttpGet("{PatientId}/{Active}")]
        public IActionResult GetPatientHistory(string PatientId, Boolean Active)
        {
            var AlleryHistory = _context.consultation_allergy
                .Include(p => p.Drug)
                .Where(a => a.patientid == PatientId && a.isactive == Active && a.drugId != null)
                .Select(g => new ConsultationAllergyDM
                {
                    DrugName = g.Drug.Name,
                    remarks = g.remarks,
                    reaction=g.reaction,
                    patientid = g.patientid,
                    encodeddate=g.encodeddate
                })
                .ToList();

            if (AlleryHistory == null)
            {
                return NotFound();
            }
            return Ok(AlleryHistory);
        }

        // GET api/user/firstname/lastname/address
        [HttpGet("{PatientId}/{Active}/{FromDate}/{ToDate}")]
        public IActionResult GetPatientHistoryFliter(string PatientId, Boolean Active,DateTime FromDate, DateTime ToDate)
        {
            var AlleryHistory = _context.consultation_allergy
                .Include(p => p.Drug)
                .Where(a => a.patientid == PatientId && a.isactive == Active && a.encodeddate > FromDate && a.encodeddate < ToDate)
                .Select(g => new ConsultationAllergyDM
                {
                    DrugName = g.Drug.Name,
                    remarks = g.remarks,
                    reaction = g.reaction,
                    patientid = g.patientid,
                    encodeddate = g.encodeddate,
                    AllergyName = g.AllergyMaster.description
                })
                .ToList();

            if (AlleryHistory == null)
            {
                return NotFound();
            }
            return Ok(AlleryHistory);
        }
         // GET api/user/firstname/lastname/address
        [HttpGet("{PatientId}/{Active}/{FromDate}/{ToDate}/{OtherAllergy}")]
        public IActionResult GetPatientHistoryOtherAllergy(string PatientId, Boolean Active,DateTime FromDate, DateTime ToDate, string OtherAllergy)
        {
            var AlleryHistory = _context.consultation_allergy
                .Include(p => p.AllergyMaster)
                .Where(a => a.patientid == PatientId && a.isactive == Active && a.encodeddate > FromDate && a.encodeddate < ToDate && a.allergyid != null)
                .Select(g => new ConsultationAllergyDM
                {
                    remarks = g.remarks,
                    reaction = g.reaction,
                    patientid = g.patientid,
                    encodeddate = g.encodeddate,
                    AllergyName = g.AllergyMaster.description
                })
                .ToList();

            if (AlleryHistory == null)
            {
                return NotFound();
            }
            return Ok(AlleryHistory);
        }
    }
}
