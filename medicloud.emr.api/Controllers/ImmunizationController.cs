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
           // var all =await _conn.QueryAsync("select * from Immunization_Schedule a join EmrImmunizationMaster b " +
           //     "                            on a.immunizationid = b.Immunizationid");
         // var all = await _conn.QueryAsync("select a.*, b.immunizationname, b.isactive,b.cptcode, b.encodeddate, c.duedate, c.givendatetime, c.remarks, c.batchno, c.brandid, c.givenby from Immunization_Schedule a join EmrImmunizationMaster b on a.immunizationid = b.Immunizationid join immunization_details c on a.scheduleid = c.scheduleid");
         var all = "select *, d.name drugname, im.givenby givennurse, (select concat(firstname, ' ', lastname) from ApplicationUser where appuserid = im.givenby)nursename from Immunization_Schedule a join immunization_details im on a.scheduleid = im.scheduleid join Drug d on im.brandid = d.id join EmrImmunizationMaster b on a.immunizationid = b.Immunizationid";
         var allResult = await _conn.QueryAsync(all);   
         return Ok(allResult);
        }

        [Route("UpdateImmunizationSchedule/{id}")]
        [HttpPut]
        public async Task<IActionResult> UpdateImmunizationSchedule([FromRoute] long id, [FromBody]ImmunizationSchedule dto)
        {
            var single = await _ctx.ImmunizationSchedule.FirstOrDefaultAsync(x => x.Scheduleid == id);
            //dto.
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

        [Route("GetImmunizationDetailsByPatientId/{patientid}")]
        [HttpGet]
        public async Task<IActionResult> GetImmunizationScheduleByScheduleId([FromRoute]string patientid, [FromQuery]long scheduleid)
        {
            var all = await _conn.QueryAsync($"select b.* from Immunization_Schedule a join immunization_details b " +
                $"                          on a.scheduleid = b.scheduleid where a.scheduleid = {scheduleid} and b.patientid = '{patientid}'");
            //Console.Wri
            return Ok(all);
        }

        [Route("GetImmunizationScheduleById/{id}")]
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
        [HttpGet]
        public async Task<IActionResult> AllImmunizationDetail()

        {
            var query = "select * from Immunization_details a join EmrImmunizationMaster b on a.immunizationid = b.Immunizationid";
            // string query = "select a.*, d.name drugname, d.drugcode, (concat(u.firstname, ' ', u.lastname))nursename " + 
            // "from Immunization_details a join EmrImmunizationMaster b on a.immunizationid = b.Immunizationid full outer " +
            // "join Drug d on d.id = a.brandid full outer join ApplicationUser u on " +
            //     "a.givenby = u.appuserid where u.departmentid in (select departmentid from ApplicationUser where u.departmentid in (12))";
            var all = _conn.QueryAsync(query);
            
            return Ok(all);
        }

        [Route("GetImmunizationDetailById/{id}")]
        [HttpGet]
        public async Task<IActionResult> AllImmunizationDetail([FromRoute]long id)
        {
            return Ok(await _ctx.ImmunizationDetails.FirstOrDefaultAsync(x=>x.Id == id));
        }


        [Route("UpdateImmunizationDetails/{id}")]
        [HttpPut]
        public async Task<IActionResult> UpdateCancellationRemark([FromRoute]long id, 
            [FromForm]ImmunizationDetails dto)
        {
            var single = await _ctx.ImmunizationDetails.Where(x => x.Id == id).SingleOrDefaultAsync();
            if (single == null) return Ok(false);
            _ctx.Entry(dto).State = EntityState.Modified;
            _ctx.Entry(dto).Property(x => x.Id).IsModified = false;
            return Ok(await _ctx.SaveChangesAsync());
        }

        [Route("SaveImmunizationDetails")]
        [HttpPost]
        public async Task<IActionResult> SaveImmunizationDetails([FromBody]ImmunizationDetails dto)
        {
            _ctx.ImmunizationDetails.Add(dto);
            return Ok(await _ctx.SaveChangesAsync() > 0);
        }

        [Route("allnurse")]
        [HttpGet]
        public async Task<IActionResult> AllNurse()
        {
            return Ok(await _ctx.ApplicationUser.Where(x=>x.departmentid.Value ==12).ToListAsync());
        }

        [Route("SavePescriptionDetails")]
        [HttpPost]
        public async Task<IActionResult> SavePescription([FromBody] ConsultationPrescriptionDetails dto)
        {
            //dto. = DateTime.Now;
            _ctx.ConsultationPrescriptionDetails.Add(dto);
            return Ok(await _ctx.SaveChangesAsync() > 0);
        }

        [Route("DeleteImmunizationDetails/{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteImmunizationDetails([FromRoute] long id)
        {
            var single = await _ctx.ImmunizatiinMaster.FirstOrDefaultAsync(x => x.Immunizationid == id);
            if (single == null) return Ok(false);
            //if(single.give)
            return Ok(await _ctx.SaveChangesAsync() > 0);
        }
    }
}
