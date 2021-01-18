using medicloud.emr.api.Entities;
using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultationDiagnosisController : ControllerBase
    {
        private readonly IConsultationDiagnosisRepository _consultationDiagnosisRepository;
        public ConsultationDiagnosisController(IConsultationDiagnosisRepository consultationDiagnosisRepository)
        {
            _consultationDiagnosisRepository = consultationDiagnosisRepository;
        }

        [HttpPost("CreateConsultationDiagnosisFavourite")]
        public async Task<IActionResult> CreateConsultationDiagnosisFavourite(ConsultationDiagnosisFavourites model)
        {
            try
            {
                await _consultationDiagnosisRepository.AddConsultationDiagnosisFavourites(model);
                var status = true;
                return Ok(status);
            }
            catch (Exception ex)
            {
                var status = false;
                return BadRequest(status);
            }

        }
        
        [HttpGet("GetPatientConsultationDiagnosis")]
        public async Task<IActionResult> GetPatientConsultationDiagnosis(int accountId, string patientId, int locationId)
        {
            try
            {
                var patientDiagnosis = await _consultationDiagnosisRepository.getConsultationDiagnosisByPatientId(accountId, patientId, locationId);
                var status = true;
                return Ok(status);
            }
            catch (Exception ex)
            {
                var status = false;
                return BadRequest(status);
            }

        }

    }
}
