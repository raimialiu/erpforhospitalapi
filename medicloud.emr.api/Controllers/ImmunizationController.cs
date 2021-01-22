using Dapper;
using medicloud.emr.api.Data;
using medicloud.emr.api.Entities;
using medicloud.emr.api.Etities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Controllers
{
    [Route("api/immunization")]
    [ApiController]
    public class ImmunizationController : ControllerBase
    {
        private SqlConnection _conn;
        private IConfiguration config;
        private DataContext _ctx;
        public ImmunizationController(IConfiguration config)
        {
            this.config = config;
            _conn = new SqlConnection(config.GetSection("ConnectionStrings:lagoonDB").Value);
            _conn.Open();
            _ctx = new DataContext();
        }

        [Route("AllImmunizationSchedule")]
        [HttpGet]
        public async Task<IActionResult> AllImunizationSchedule()
        {
            var all =await _conn.QueryAsync<ImmunizationSchedule>("select * from Immunization_Schedule");

            return Ok(all);
        }

        [Route("UpdateImmunizationSchedule/{id}")]
        [HttpPut]
        public async Task<IActionResult> UpdateImmunizationSchedule([FromRoute] long id, [FromBody]ImmunizationSchedule dto)
        {
            var single = await _ctx.ImmunizationSchedule.FirstOrDefaultAsync(x => x.Scheduleid == id);
            if (single == null) return Ok(false);

            _ctx.Entry<ImmunizationSchedule>(single).State = EntityState.Modified;
            _ctx.Entry<ImmunizationSchedule>(single).Property(x => x.Scheduleid).IsModified = false;

            return Ok(await _ctx.SaveChangesAsync() > 0);
        }

        [Route("DeleteImmunizationSchedule/{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteImmunizationSchedule([FromRoute] long id)
        {
            var all = await _conn.ExecuteAsync($"delete from Immunization_Schedule where scheduleid=@id", new { id=id});

            return Ok(all > 0);
        }

        [Route("SaveImmunizationSchedule")]
        [HttpPost]
        public async Task<IActionResult> SaveImmunizationSchedule([FromBody]ImmunizationSchedule dto)
        {
            dto.Encodeddate = DateTime.Now;
            _ctx.ImmunizationSchedule.Add(dto);
            return Ok(await _ctx.SaveChangesAsync() > 0);
        }

        [Route("GetImmunizationById/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetImmunizationById([FromRoute]long id)
        {
            var all = await _conn.QueryAsync<ImmunizationSchedule>("select * from Immunization_Schedule where scheduleid=@id",new { id=id} );

            return Ok(all);
        }

        [Route("AllImmunizationBrand")]
        [HttpGet]
        public async Task<IActionResult> AllImmunizationBrand()
        {
            return Ok(await _ctx.ImmunizationBrand.ToListAsync());
        }

        [HttpGet, Route("AllImmunizationMaster")]
        public async Task<IActionResult> AllImmunizationMaster()
        {
            return Ok(await _ctx.ImmunizatiinMaster.ToListAsync());
        }

        [HttpGet, Route("GetImmunizationMasterById/{id}")]
        public async Task<IActionResult> GetImmunizationMasterById([FromRoute]long id)
        {
            return Ok(await _ctx.ImmunizatiinMaster.FirstOrDefaultAsync(x => x.Immunizationid == id));
        }

        [HttpDelete, Route("DeleteImmunizationMasterById/{id}")]
        public async Task<IActionResult> DeleteImmunizationMasterById([FromRoute] long id)
        {
            var single = await _ctx.ImmunizatiinMaster.FirstOrDefaultAsync(x => x.Immunizationid == id);
            if (single == null) return Ok(false);

            _ctx.ImmunizatiinMaster.Remove(single);
            return Ok(await _ctx.SaveChangesAsync() > 0);
        }

        [HttpPut, Route("UpdateImmunizationMaster/{id}")]
        public async Task<IActionResult> UpdateImmunizationMaster([FromRoute] long id, [FromBody]EmrimmunizationMaster dto)
        {
            var single = await _ctx.ImmunizatiinMaster.Where(x => x.Immunizationid == id).FirstOrDefaultAsync();
            if (single == null) return Ok(false);

            _ctx.Entry<EmrimmunizationMaster>(single).State = EntityState.Modified;
            _ctx.Entry<EmrimmunizationMaster>(single).Property(x => x.Immunizationid).IsModified = false;

            return Ok(await _ctx.SaveChangesAsync() > 0);
        }

        [HttpPost, Route("SaveImmunizationMaster")]
        public async Task<IActionResult> SaveImmunizationMaster([FromBody] EmrimmunizationMaster dto)
        {
            dto.Encodeddate = DateTime.Now;
            _ctx.ImmunizatiinMaster.Add(dto);
            return Ok(await _ctx.SaveChangesAsync() > 0);
        }


        [Route("AllImmunizationDetail")]
        [HttpPost]
        public async Task<IActionResult> AllImmunizationDetail()
        {
            return Ok(await _ctx.ImmunizationDetails.ToListAsync());
        }
    }
}
