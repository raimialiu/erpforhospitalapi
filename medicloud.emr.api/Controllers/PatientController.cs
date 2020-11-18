using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using medicloud.emr.api.Helpers;
using medicloud.emr.api.DataContextRepo;
using medicloud.emr.api.DTOs;

namespace medicloud.emr.api.Controllers
{
    [ApiController]
    public class PatientController : ControllerBase
    {
        private IPatientRepo patientRepo;
        private BaseResponse _reponse;
        public PatientController(IPatientRepo patientRepo)
        {
            this.patientRepo = patientRepo;
        }

        [Route(ApiRoutes.searchForPatient)]
        [HttpGet]
        public async Task<IActionResult> SearchForPatient([FromRoute] string searchValue)
        {
            try
            {
                var returnedDataFromSearch = await patientRepo.SearchByValue(searchValue);

                _reponse = BaseResponse.GetResponse(returnedDataFromSearch, $"searching for patient information with {searchValue}", "00");

                patientRepo.Close();
                return Ok(_reponse);

            }
            catch(Exception es)
            {
                return Content(es.Message, "application/json");

            }

        }
    }
}
