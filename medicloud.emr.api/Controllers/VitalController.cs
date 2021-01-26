using medicloud.emr.api.Data;
using medicloud.emr.api.Entities;
using medicloud.emr.api.Etities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VitalController : ControllerBase
    {
        private DataContext _ctx;
        public VitalController()
        {
            _ctx = new DataContext();
        }


        [Route("GetAllProblem")]
        [HttpGet]
        public async Task<IActionResult> GetAllProblem()
        {
            return Ok(await _ctx.EmrProblems.ToListAsync());
        }

        [Route("GetAllProblemByKeyword/{keyword}")]
        [HttpGet]
        public async Task<IActionResult> GetAllProblemByKeyword([FromRoute]string keyword)
        {
            return Ok(await _ctx.EmrProblems.Where(x=>x.Description.Contains(keyword)).ToListAsync());
        }

        [Route("AllProblemDuration")]
        [HttpGet]
        public async Task<IActionResult> AllProblemDuration()
        {
            return Ok(await _ctx.EmrProblemDuration.ToListAsync());
        }

        [Route("TodaysProblem")]
        [HttpGet]
        public async Task<IActionResult> TodaysProblem()
        {
            var _today = DateTime.Now.ToShortDateString();
            return Ok(await _ctx.ConsultationComplaintsB.Where(x=>x.Dateadded.Value.ToShortDateString() == DateTime.Now.ToShortDateString()).ToListAsync());
        }

        [Route("SaveConsultationFavourites")]
        [HttpPost]
        public async Task<IActionResult> SaveConsultationFavoruties([FromBody] ConsultationComplaintsFavorites dto)
        {
            dto.Dateadded = DateTime.Now;
            _ctx.ConsultationComplaintsFavorites.Add(dto);
            return Ok(await _ctx.SaveChangesAsync() > 0);
        }


        [Route("DeleteConsultationFavourites/{id}")]
        [HttpPost]
        public async Task<IActionResult> DeleteConsultationfavourites([FromRoute]long id)
        {
            var single = await _ctx.ConsultationComplaintsFavorites.SingleOrDefaultAsync(x => x.Favoriteid == id);
            if (single == null) return Ok(false);

            _ctx.ConsultationComplaintsFavorites.Remove(single);
            return Ok(await _ctx.SaveChangesAsync() > 0);
        }

        [Route("SaveFreeForm")]
        [HttpPost]
        public async Task<IActionResult> SaveFreeForm([FromBody] DiagnosisFreeFormDTO vl)
        {
            foreach(DiagnosisFreeForm k in vl.values)
            {
               if(k != null)
                {
                    if(k.Bodyarea != null || k.Textvalue != null)
                     {
                          k.Dateadded = DateTime.Now;
                          _ctx.DiagnosisFreeForms.Add(k);
                     }
                }
                
               
            }

            return Ok(await _ctx.SaveChangesAsync() > 0);
        }

        [Route("LoadFreeFormByDateRange")]
        [HttpGet]
        public async Task<IActionResult> LoadFreeFormByDateRange([FromQuery]string startDate, [FromQuery]string endDate)
        {
            //DateTime start = DateTime.Parse(startDate);
            //DateTime end = DateTime.Parse(endDate);

            var FreeForms = await _ctx.DiagnosisFreeForms.FromSqlRaw($"select * from diagnosis_freeform where dateadded between '{startDate}' and '{endDate}'").ToListAsync();


            return Ok(FreeForms);
        }

        [Route("LoadFreeFormLastTen")]
        [HttpGet]
        public async Task<IActionResult> LoadFreeFormLastTen()
        {
            var FreeForms = await _ctx.DiagnosisFreeForms.OrderByDescending(x => x.Freeformid).Take(10).ToListAsync();


            return Ok(FreeForms);
        }

        [Route("LoadConsultationFavourites")]
        [HttpGet]
        public async Task<IActionResult> LoadConsultationFavoruties()
        {
            var favourites = await _ctx.ConsultationComplaintsFavorites.Include(x => x.Problem).ToListAsync();
            return Ok(favourites);
        }

        [Route("DeleteConsultationFavorites/{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteConsultationFavourites([FromRoute]long id, [FromQuery] int doctorid)
        {
            var single = await _ctx.ConsultationComplaintsFavorites.SingleOrDefaultAsync(x => x.Favoriteid == id && x.Doctorid == doctorid);
            if (single == null) return BadRequest(false);

            _ctx.ConsultationComplaintsFavorites.Remove(single);
            return Ok(await _ctx.SaveChangesAsync() > 0);
        }

        [Route("SaveConsultationComplaints")]
        [HttpPost]
        public async Task<IActionResult> SaveConsultationComplaints([FromBody]Etities.ConsultationComplaints dto)
        {
            dto.Dateadded = DateTime.Now;
            _ctx.ConsultationComplaints.Add(dto);
            return Ok(await _ctx.SaveChangesAsync() > 0);
        }

        [Route("LoadLastTenConsultationComplaints")]
        [HttpGet]
        public async Task<IActionResult> LoadLastTenConsultationComplaints()
        {
            var lastTen =  _ctx.ConsultationComplaints.OrderByDescending(x => x.Complaintid).Take(10);

            return Ok(lastTen);
        }

        [Route("ConsultationComplainByDateRange")]
        [HttpGet]
        public async Task<IActionResult> ConsultationComplainByDateRange([FromQuery]string startDate, [FromQuery]string endDate)
        {
            string _start = DateTime.Parse(startDate).ToString("mm-dd-yyyy");
            string  _end = DateTime.Parse(endDate).ToString("mm-dd-yyyy");
            //var complaints = await _ctx.ConsultationComplaints.Where(x => x.Dateadded.Value == _start && x.Dateadded.Value <= _end).ToListAsync();
            var complaints = await _ctx.ConsultationComplaints.FromSqlRaw($"select * from consultation_complaints where dateadded between '{startDate}' and '{endDate}'").ToListAsync();
            // select * from consultation_complaints where dateadded between

            return Ok(complaints);
        }

        [Route("DeleteConsultationComplaint/{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteConsultationComplaint([FromRoute]long id, [FromQuery] string isChronic)
        {
            Etities.ConsultationComplaints single = null;
            if(Convert.ToInt32(isChronic) ==  0)
            {
                single = await _ctx.ConsultationComplaints.SingleOrDefaultAsync(x => x.Complaintid == id);
            }
            else
            {
                single = await _ctx.ConsultationComplaints.SingleOrDefaultAsync(x => x.Complaintid == id && x.IsChronic == 1);
            }
          
            if (single == null) return Ok(false);

            _ctx.ConsultationComplaints.Remove(single);

            return Ok(await _ctx.SaveChangesAsync() > 0);
        }
        [Route("LoadAllComplaints")]
        [HttpGet]
        public async Task<IActionResult> LoadAllComplaint()
        {
            return Ok(await _ctx.ConsultationComplaints.ToListAsync());
        }

        [Route("LoadProblemQuality")]
        [HttpGet]
        public async Task<IActionResult> LoadProblemQuality()
        {
            return Ok(await _ctx.EmrproblemsQualities.ToListAsync());
        }

        [Route("LoadProblemConditions")]
        [HttpGet]
        public async Task<IActionResult> LoadProblemConditions()
        {
            return Ok(await _ctx.EmrproblemsConditions.ToListAsync());
        }


        [Route("LoadProblemSeverity")]
        [HttpGet]
        public async Task<IActionResult> LoadProblemSeverity()
        {
            return Ok(await _ctx.EmrproblemsSeverity.ToListAsync());
        }

        [Route("LoadProblemContext")]
        [HttpGet]
        public async Task<IActionResult> LoadProblemContext()
        {
            return Ok(await _ctx.EmrproblemsContext.ToListAsync());
        }

        [Route("LoadProblemLocation")]
        [HttpGet]
        public async Task<IActionResult> LoadProblemLocation()
        {
            return Ok(await _ctx.EmrproblemsLocation.ToListAsync());
        }


        [Route("addDiagnosis")]
        [HttpPost]
        public async Task<IActionResult> AddDiagnosis([FromBody] Diagnosis body)
        {
            _ctx.Diagnosis.Add(body);
            var result = await _ctx.SaveChangesAsync();

            return Ok(result > 0);
        }


        //[Route("UpdateDiagnosis/{id}")]
        //[HttpPut]
        //public async Task<IActionResult> UpdateDiagnosis([FromRoute] long id, [FromBody] Diagnosis body)
        //{
        //    var oldChiefComplaint = await _ctx.Diagnosis.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
        //    if (oldChiefComplaint == null) return BadRequest(false);

        //    _ctx.Entry<Diagnosis>(body).State = EntityState.Modified;
        //    _ctx.Entry<Diagnosis>(body).Property(x => x.Id).IsModified = false;
        //    var result = await _ctx.SaveChangesAsync();
        //    return Ok(result > 0);
        //}

        //[Route("DeleteDiagnosis/{id}")]
        //[HttpDelete]
        //public async Task<IActionResult> DeleteDiagnosis([FromRoute] long id)
        //{
        //    var oldChiefComplaint = await _ctx.Diagnosis.SingleOrDefaultAsync(x => x.Id == id);
        //    if (oldChiefComplaint == null) return BadRequest(false);

        //    _ctx.Diagnosis.Remove(oldChiefComplaint);

        //    var result = await _ctx.SaveChangesAsync();
        //    return Ok(result > 0);
        //}

        //[Route("GetDiagnosis/{id}")]
        //[HttpGet]
        //public async Task<IActionResult> GetDiagnosis([FromRoute] long id)
        //{
        //    return Ok(await _ctx.Diagnosis.SingleOrDefaultAsync(x => x.Id == id));
        //}

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
