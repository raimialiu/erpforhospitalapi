using medicloud.emr.api.Data;
using medicloud.emr.api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Controllers
{
    [Route("api/vitals")]
    [ApiController]
    public class VitalController : ControllerBase
    {
        private DataContext _ctx;
        public VitalController()
        {
            _ctx = new DataContext();
        }

        [Route("addDiagnosis")]
        [HttpPost]
        public async Task<IActionResult> AddDiagnosis([FromBody] Diagnosis body)
        {
            _ctx.Diagnosis.Add(body);
            var result = await _ctx.SaveChangesAsync();

            return Ok(result > 0);
        }


        [Route("UpdateDiagnosis/{id}")]
        [HttpPut]
        public async Task<IActionResult> UpdateDiagnosis([FromRoute] long id, [FromBody] Diagnosis body)
        {
            var oldChiefComplaint = await _ctx.Diagnosis.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
            if (oldChiefComplaint == null) return BadRequest(false);

            _ctx.Entry<Diagnosis>(body).State = EntityState.Modified;
            _ctx.Entry<Diagnosis>(body).Property(x => x.Id).IsModified = false;
            var result = await _ctx.SaveChangesAsync();
            return Ok(result > 0);
        }

        [Route("DeleteDiagnosis/{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteDiagnosis([FromRoute] long id)
        {
            var oldChiefComplaint = await _ctx.Diagnosis.SingleOrDefaultAsync(x => x.Id == id);
            if (oldChiefComplaint == null) return BadRequest(false);

            _ctx.Diagnosis.Remove(oldChiefComplaint);

            var result = await _ctx.SaveChangesAsync();
            return Ok(result > 0);
        }

        [Route("GetDiagnosis/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetDiagnosis([FromRoute] long id)
        {
            return Ok(await _ctx.Diagnosis.SingleOrDefaultAsync(x => x.Id == id));
        }

        [Route("allDiagnosis")]
        [HttpGet]
        public async Task<IActionResult> allDiagnosis()
        {
            return Ok(await _ctx.Diagnosis.ToListAsync());
        }

        [Route("createChiefComplain")]
        [HttpPost]
        public async Task<IActionResult> CreateChiefComplain([FromBody] ChiefComplain body)
        {
            _ctx.ChiefComplain.Add(body);
            var result = await _ctx.SaveChangesAsync();

            return Ok(result > 0);
        }

        [Route("UpdateChiefComplain/{id}")]
        [HttpPut]
        public async Task<IActionResult> UpdateChiefComplain([FromRoute]long id, [FromBody]ChiefComplain body)
        {
            var oldChiefComplaint = await _ctx.ChiefComplain.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
            if (oldChiefComplaint == null) return BadRequest(false);

            _ctx.Entry<ChiefComplain>(body).State = EntityState.Modified;
            _ctx.Entry<ChiefComplain>(body).Property(x => x.Id).IsModified = false;
            var result = await _ctx.SaveChangesAsync();
            return Ok(result > 0);
        }

        [Route("DeleteChiefComplain/{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteChiefComplain([FromRoute] long id)
        {
            var oldChiefComplaint = await _ctx.ChiefComplain.SingleOrDefaultAsync(x => x.Id == id);
            if (oldChiefComplaint == null) return BadRequest(false);

            _ctx.ChiefComplain.Remove(oldChiefComplaint);
            
            var result = await _ctx.SaveChangesAsync();
            return Ok(result > 0);
        }

        [Route("allChiefComplain")]
        [HttpGet]
        public async Task<IActionResult> GetAllChiefComplaint()
        {
            return Ok(await _ctx.ChiefComplain.ToListAsync());
        }

        [Route("GetChiefComplain/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetChiefComplaint([FromRoute]long id)
        {
            return Ok(await _ctx.ChiefComplain.SingleOrDefaultAsync(x => x.Id == id));
        }
    }
}
