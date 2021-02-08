﻿using medicloud.emr.api.Data;
using medicloud.emr.api.DTOs;
using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace medicloud.emr.api.Controllers
{
    [BindProperties]
    public class PrescriptionListFilterModel : QueryListParameters
    {
        //both defaultDate and Date must be equal, as this is the initial date value
       public DateTime defaultDate = new DateTime(1753, 1, 1);
        public int? LocationId { get; set; }
        public DateTime? Date { get; set; } 
        //public int VisitType { get; set; }        
        public int? ProviderId { get; set; }
        public int? StatusId { get; set; }
    }

    [Route("api/[controller]")]
    public class PharmacyManagementController : ControllerBase
    {
        private readonly IPharmacyManagementRepository _pharmacyManagementRepository;
        private readonly DataContext _context;

        public PharmacyManagementController(DataContext context, IPharmacyManagementRepository pharmacyManagementRepository)
        {
            _context = context;
            _pharmacyManagementRepository = pharmacyManagementRepository;
        }



        [HttpGet, Route("GetPrescriptionList")]
        public async Task<IActionResult> GetPrescriptionList([FromQuery] PrescriptionListFilterModel prescriptionListFilterModel)
        {
            try
            {
               
                var count = _context.ConsultationPrescription.Count();
                var prescriptionListWithCount = await _pharmacyManagementRepository.getConsultationPrescriptionsList(prescriptionListFilterModel);
                var prescriptionList = new PagedList<PharmacyManagementDTO>(prescriptionListWithCount.PrescriptionList, prescriptionListWithCount.Count, prescriptionListFilterModel.PageNumber, prescriptionListFilterModel.PageSize);
                var metadata = new
                {
                    prescriptionList.TotalCount,
                    prescriptionList.PageSize,
                    prescriptionList.CurrentPage,
                    prescriptionList.TotalPages,
                    prescriptionList.HasNext,
                    prescriptionList.HasPrevious
                };
                Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));
                return Ok(prescriptionList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return BadRequest();
            }
        }


        [HttpGet, Route("getPrescriptionByPrescriptionId/{prescriptionid}")]
        public async Task<IActionResult> getPrescriptionByPrescriptionId(int prescriptionid)
        {
            try
            {
                //    if (_pharmacyManagementRepository.ConsultationPrescriptionExists(prescriptionid))
                //    {
                var prescriptionList = _pharmacyManagementRepository.getConsultationPrescriptionByPrescriptionId(prescriptionid);
                return Ok(prescriptionList);
            //}
            //    else return BadRequest("invalid prescriptionid");
        }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return BadRequest();
            }
        }

        [HttpGet, Route("getPrescriptionDetailsByPrescriptionId/{prescriptionid}")]
        public async Task<IActionResult> getPrescriptionDetailsByPrescriptionId(int prescriptionid)
        {
            try
            {
                //if (_pharmacyManagementRepository.ConsultationPrescriptionExists(prescriptionid))
                //{
                var prescriptionList = await _pharmacyManagementRepository.getConsultationPrescriptionsDetailsByPrescriptionId(prescriptionid);

                return Ok(prescriptionList);
                //}
                //else return BadRequest("invalid prescriptionid");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("GetPrescriptionDetailsList")]
        public async Task<IActionResult> GetPrescriptionDetailsList()
        {
            
            try
            {  //if there is need to use this controller, add paging
                var PrescriptionDetailsList = await _context.ConsultationPrescriptionDetails.ToListAsync();
                return Ok(PrescriptionDetailsList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return BadRequest();
            }


        }
        
        [HttpPut]
        [Route("UpdatePrescriptionDetails/{id}")]
        public async Task<IActionResult> UpdatePrescriptionDetails(int id, [FromBody] PrescriptionDetailsUpdateDTO prescriptionDetailsUpdateDTO)
        {           
            if (prescriptionDetailsUpdateDTO.Statusid <0)
            {
                return BadRequest();
            }
            if (id != prescriptionDetailsUpdateDTO.Id) { return BadRequest(); }
            var details = await _context.ConsultationPrescriptionDetails.FindAsync(id);
            if (details == null) { return NotFound(); }
                details.Statusid = prescriptionDetailsUpdateDTO.Statusid;
                details.Lastchangeby = prescriptionDetailsUpdateDTO.Lastchangeby;
                details.Lastchangedate = DateTime.Now;
            try
            {
                var update = await _context.SaveChangesAsync();
                if (update >= 1)
                {
                    return NoContent();
                }
                else return BadRequest(new ErrorResponse { ErrorMessage = "Previous StatusId is the same as update status Id" });
            }
            catch (DbUpdateConcurrencyException) when (!_pharmacyManagementRepository.PrescriptionDetailsExist(id))
            {
                return NotFound();
            }

        }

        [HttpPut]
        [Route("RemovePrescriptionDetails/{id}")]
        public async Task<IActionResult> RemovePrescriptionDetails(int id, [FromBody] PrescriptionDetailsRemoveDTO prescriptionDetailsRemoveDTO)
        {
                      
            if (id != prescriptionDetailsRemoveDTO.Id) { return BadRequest(); }
            var details = await _context.ConsultationPrescriptionDetails.FindAsync(id);
            if (details == null) { return NotFound(); }
            details.Isactive = false;
            details.Lastchangeby = prescriptionDetailsRemoveDTO.Lastchangeby;
            details.Lastchangedate = DateTime.Now;
            if (prescriptionDetailsRemoveDTO.Comment != null)
            {
                details.Comments = prescriptionDetailsRemoveDTO.Comment;   
                
            }
           
            try
            {
                var update = await _context.SaveChangesAsync();
                if (update >= 1)
                {
                    return NoContent();
                }
                else return BadRequest();
            }
            catch (DbUpdateConcurrencyException) when (!_pharmacyManagementRepository.PrescriptionDetailsExist(id))
            {
                return NotFound();
            }

        }

        [HttpGet]
        [Route("GetProvider")]
        public async Task<IActionResult> GetProviders()
        {
            var providerList = await _pharmacyManagementRepository.GetProviders();
            return Ok(providerList);
        }

        [HttpGet]
        [Route("GetLocation")]
        public async Task<IActionResult> GetLocations()
        {
            var locationList = await _pharmacyManagementRepository.GetLocations();
            return Ok(locationList);
        }

        [HttpGet]
        [Route("GetStatus")]
        public async Task<IActionResult> GetStatus()
        {
            var locationList = await _pharmacyManagementRepository.GetStatus();
            return Ok(locationList);
        }

        [HttpPost]
        [Route("AddPrescriptionDetails")]
        public async Task<IActionResult> AddPrescriptionDetails([FromBody] FullPrescriptionDetailsDTO prescDetailsObj)
        {
            
                var prescDetailsCreated = await _pharmacyManagementRepository.AddPrescriptionDetails(prescDetailsObj);
                if (prescDetailsCreated)
                {
                    
                return NoContent();
                }
                else return BadRequest();
          
        }

    }   
}
