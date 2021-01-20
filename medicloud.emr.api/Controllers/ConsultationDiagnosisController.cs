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
        
        [HttpPost("CreateConsultationDiagnosis")]
        public async Task<IActionResult> CreateConsultationDiagnosis(ConsultationDiagnosis model)
        {
            try
            {
                await _consultationDiagnosisRepository.AddConsultationDiagnosis(model);
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
        public async Task<IActionResult> GetPatientConsultationDiagnosis(int accountId, string patientId)
        {
            try
            {
                var patientDiagnosis = await _consultationDiagnosisRepository.getConsultationDiagnosisByPatientId(accountId, patientId);
                return Ok(patientDiagnosis);
            }
            catch (Exception ex)
            {
                var status = false;
                return BadRequest(status);
            }

        }
        
        [HttpGet("GetPatientConsultationDiagnosisDateRange")]
        public async Task<IActionResult> GetPatientConsultationDiagnosisDateRange(int accountId, string patientId, DateTime startDate, DateTime endDate)
        {
            try
            {
                var patientDiagnosis = await _consultationDiagnosisRepository.getConsultationDiagnosisByPatientIdDateRange(accountId, patientId, startDate, endDate);
                return Ok(patientDiagnosis);
            }
            catch (Exception ex)
            {
                var status = false;
                return BadRequest(status);
            }

        }
        
        [HttpGet("GetPatientConsultationDiagnosisToday")]
        public async Task<IActionResult> GetPatientConsultationDiagnosisToday(int accountId, string patientId, int locationId)
        {
            try
            {
                var patientDiagnosis = await _consultationDiagnosisRepository.getConsultationDiagnosisByPatientIdToday(accountId, patientId);
                return Ok(patientDiagnosis);
            }
            catch (Exception ex)
            {
                var status = false;
                return BadRequest(status);
            }

        }
        
        [HttpGet("GetConsultationDiagnosisFavourites")]
        public async Task<IActionResult> GetConsultationDiagnosisFavourites(int accountId, int doctorId, string searchword)
        {
            try
            {
                var patientDiagnosis = await _consultationDiagnosisRepository.GetConsultationDiagnosisFavourites(accountId, doctorId, searchword);
                return Ok(patientDiagnosis);
            }
            catch (Exception ex)
            {
                var status = false;
                return BadRequest();
            }

        }
        
        [HttpGet("DeleteConsultationDiagnosis")]
        public async Task<IActionResult> DeleteConsultationDiagnosis(int accountId, int consultationDiagnosisId)
        {
            try
            {
                await _consultationDiagnosisRepository.DeleteConsultationDiagnosis(accountId, consultationDiagnosisId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

    }
}
