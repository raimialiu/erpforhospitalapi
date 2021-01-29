//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using medicloud.emr.api.Data;
//using medicloud.emr.api.Entities;

//namespace medicloud.emr.api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class VitalsController : ControllerBase
//    {
//        private  DataContext _context;

//        public VitalsController(DataContext context)
//        {
//            _context = context;
//        }


//        // GET: api/Vitals
//        //[HttpGet]
//        //public IActionResult GetVital()
//        //{
//        //    return Ok(_context.Vital.ToList());
//        //}

//        //[HttpPost]
//        //public IActionResult PostVital([FromBody] Vital vital)
//        //{
//        //    try
//        //    {
//        //        if (vital == null)
//        //        {
//        //           // _logger.LogError("Owner object sent from client is null.");
//        //            return BadRequest("Owner object is null");
//        //        }

//        //        if (!ModelState.IsValid)
//        //        {
//        //            //_logger.LogError("Invalid owner object sent from client.");
//        //            return BadRequest("Invalid model object");
//        //        }

//        //       // var ownerEntity = _mapper.Map<Owner>(owner);

//        //        _context.Vital.Add(vital);
//        //        _context.SaveChanges();

//        //       // var createdOwner = _mapper.Map<OwnerDto>(ownerEntity);

//        //        return CreatedAtRoute("OwnerById", new { id = vital.Id }, vital);
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        //_logger.LogError($"Something went wrong inside CreateOwner action: {ex.Message}");
//        //        return StatusCode(500, "Internal server error");
//        //    }
//        //}



//        // GET: api/Vitals/5
//        //[HttpGet("{id}")]
//        //public IActionResult GetVital(int id)
//        //{
//        //    var vital =  _context.Vital.Find(id);
           
//        //    if (vital == null)
//        //    {
//        //        return NotFound();
//        //    }
//        //    return Ok(vital);
//        //}


//        //[HttpPut("{id}")]
//        //public IActionResult Put(Vital vital)
//        //{
//        //    try{

//        //     var existingVital = _context.Vital.Where(s => s.Id == vital.Id)
//        //                                                .FirstOrDefault();

//        //        if (existingVital != null)
//        //        {
//        //        existingVital.remarks = vital.remarks;

//        //        _context.SaveChanges();
//        //        }
//        //        else
//        //        {
//        //            return NotFound();
//        //        }
            
//        //    return Ok();

//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        //_logger.LogError($"Something went wrong inside CreateOwner action: {ex.Message}");
//        //        return StatusCode(500, "Internal server error");
//        //    }
//        //}



//    }
//}
