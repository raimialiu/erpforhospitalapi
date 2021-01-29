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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace medicloud.emr.api.Controllers
{
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
        public async Task<IActionResult> GetPrescriptionList()
        {


            //var prescriptionList = await _pharmacyManagementRepository.getPrescriptionsList();
            //return Ok(prescriptionList);

            //var prescriptionList = await _pharmacyManagementRepository.getPrescriptionsList();
            //return Ok(prescriptionList);


            try
            {
                var prescriptionList = await _pharmacyManagementRepository.getPrescriptionsList();
                return Ok(prescriptionList);
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
