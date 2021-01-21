using medicloud.emr.api.Data;
using medicloud.emr.api.DTOs;
using medicloud.emr.api.Entities;
using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]

    public class PrescriptionController : ControllerBase
    {

        private readonly IPrescriptionRepository _prescriptionRepository;
        private DataContext _ctx;

        public PrescriptionController(IPrescriptionRepository prescriptionRepository)
        {
            _prescriptionRepository = prescriptionRepository;
            _ctx = new DataContext();
        }

        //get orderpriority

        [HttpGet, Route("GetDrugList")]
        public async Task<IActionResult> GetDrugList(int formularyid, int genericid)
        {
            try
            {
                var queueList = await _prescriptionRepository.GetDrugs(formularyid, genericid);
                return Ok(queueList);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpGet, Route("GetStore")]
        public async Task<IActionResult> GetStore(int locationid)
        {
            try
            {
                var getorder = await _prescriptionRepository.GetStore(locationid);
                return Ok(getorder);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        ////get drug

        [HttpGet, Route("GetOrderPriority")]
        public async Task<IActionResult> GetOrderPriority(int locationid)
        {
            try
            {
                var getorder = await _prescriptionRepository.GetOrderPriority(locationid);
                return Ok(getorder);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [Route("GetDrugFormulary")]
        [HttpGet]
        public async Task<IActionResult> GetDrugFormulary()
        {
            return Ok(await _ctx.DrugFormulary.ToListAsync());
        }


        [Route("GetDrugBrandByGenericid")]
        [HttpGet]
        public async Task<IActionResult> GetDrugBrandByGenericID([FromQuery] long id)
        {
            if(id != 0)
            {
                var genericBrand = await _ctx.Drug.Where(x => x.genericid.Value == id).ToListAsync();

                if (genericBrand != null || genericBrand.Count > 0) return Ok(genericBrand);
            }
          

            return Ok(await _ctx.Drug.ToListAsync());
        }

        //////get drug formulary
        //[HttpGet, Route("GetDrugFormulary")]
        //public async Task<IActionResult> GetDrugFormulary(int locationid)
        //{
        //    try
        //    {
        //        var getresult = await _prescriptionRepository.GetDrugFormulary(locationid);
        //        return Ok(getresult);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest();
        //    }
        //}

        //////get drug generic
        [HttpGet, Route("GetDrugGeneric")]
        public async Task<IActionResult> GetDrugGeneric()
        {
            try
            {
                var getresult = await _prescriptionRepository.GetDrugGeneric();
                return Ok(getresult);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        //////get drug unit
        [HttpGet, Route("GetDrugUnit")]
        public async Task<IActionResult> GetDrugUnit()
        {
            try
            {
                var getresult = await _prescriptionRepository.GetDrugUnit();
                return Ok(getresult);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        //////get drug dose form
        [HttpGet, Route("GetDrugDoseForm")]
        public async Task<IActionResult> GetDrugDoseForm()
        {
            try
            {
                var getresult = await _prescriptionRepository.GetDrugDoseForms();
                return Ok(getresult);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        //////get drug route
        [HttpGet, Route("GetDrugRoute")]
        public async Task<IActionResult> GetDrugRoute()
        {
            try
            {
                var getresult = await _prescriptionRepository.GetDrugRoute();
                return Ok(getresult);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        //////get drug frequency
        [HttpGet, Route("GetDrugFrequency")]
        public async Task<IActionResult> GetDrugFrequency()
        {
            try
            {
                var getresult = await _prescriptionRepository.GetDrugFrequency();
                return Ok(getresult);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        ////get drug food relation
        [HttpGet, Route("GetDrugFoodRelation")]
        public async Task<IActionResult> GetDrugFoodRelation()
        {
            return Ok(await _ctx.DrugFoodrelation.ToListAsync());
        }

        [Route("PrescriptionHistory")]
        [HttpGet]
        public async Task<IActionResult> GetPrescriptionHistory()
        {
            return Ok(await _ctx.Prescriptions.ToListAsync());
        }

        [Route("LoadPrescriptionHistorybyDateRange")]
        [HttpGet]
        public async Task<IActionResult> LoadPrescriptionHistorybyDateRange([FromQuery]string startDate, [FromQuery]string endDate)
        {
            return Ok(await _ctx.Prescriptions.FromSqlRaw($"select * from Consultation_Prescription where dateadded between '{startDate}' and '{endDate}'").ToListAsync());
        }

        [Route("SavePescription")]
        [HttpPost]
        public async Task<IActionResult> SavePescription([FromBody]Etities.ConsultationPrescription dto)
        {
            dto.Dateadded = DateTime.Now;
            _ctx.Prescriptions.Add(dto);
            return Ok(await _ctx.SaveChangesAsync());
        }
        [Route("SaveToFavourites")]
        [HttpPost]
        public async Task<IActionResult> SaveToFavourites([FromBody]Etities.ConsultationComplaintsFavorites dto)
        {
            dto.Dateadded = DateTime.Now;
            _ctx.ConsultationComplaintsFavorites.Add(dto);
            return Ok(await _ctx.SaveChangesAsync() > 0);
        }
        [HttpGet, Route("GetPrescriptionFavouritesByDoctorid")]
        public async Task<IActionResult> GetPrescriptionFavouritesByDoctorid([FromQuery] long doctorid)
        {
            return Ok(await _ctx.ConsultationComplaintsFavorites.Where(x => x.Doctorid.Value == doctorid).ToListAsync());
        }

        [HttpGet, Route("GetPrescriptionByDoctorid")]
        public async Task<IActionResult> GetPrescriptionByDoctorid([FromQuery] long doctorid)
        {
            //return Ok(await _ctx.ConsultationPrescription.Where(x=>x);
            return Ok(await _ctx.Prescriptions.Where(x=>x.Doctorid.Value == doctorid).ToListAsync());
        }


      

        ////[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Prescribtion/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Prescribtion
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Prescribtion/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
        // GET: api/Prescribtion

    }
} 
