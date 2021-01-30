using medicloud.emr.api.Data;
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
    public class PrescriptionListFilterModel : QueryListParameters
    {
        public string Facility { get; set; }
        public DateTime Date { get; set; }
        public int VisitType { get; set; }
        public int StatusId { get; set; } 
        public int ProviderId { get; set; }
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
        public async Task<IActionResult> GetPrescriptionList([FromQuery] PrescriptionListParameters prescriptionListParameters)
        {
            try
            {
                //var prescriptionList = await _pharmacyManagementRepository.getPrescriptionsList();
                var count = _context.ConsultationPrescription.Count();
                var prescriptionList = new PagedList<PharmacyManagementDTO>(await _pharmacyManagementRepository.getPrescriptionsList(prescriptionListParameters), count, prescriptionListParameters.PageNumber, prescriptionListParameters.PageSize);
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
                var prescriptionList = await _pharmacyManagementRepository.getPrescriptionByPrescriptionId(prescriptionid);
                return Ok(prescriptionList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("GetPatientPrescriptionList/{patientid}")]
        public async Task<IActionResult> GetPrescriptionList(int patientid)
        {

            
                try
                {

                var patientPrescriptionList = await _pharmacyManagementRepository.getPatientPrescriptionsList(patientid.ToString());
                //var patientPrescriptionList = await _pharmacyManagementRepository.getPatientPrescriptionsListAll(patientid.ToString());
                return Ok(patientPrescriptionList);
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
            {

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
        [Route("RemovePrescriptionDetails/{prescriptionid}")]
        public async Task<IActionResult> RemovePrescriptionDetails(int prescriptionid)
        {
            
            {
                try {
                    //if (_pharmacyManagementRepository.ConsultationPrescriptionExists(prescriptionid))
                    //{
                        await _pharmacyManagementRepository.removePrescriptionDetailsItem(prescriptionid);
                        return NoContent();
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
            
        }

    }
}
