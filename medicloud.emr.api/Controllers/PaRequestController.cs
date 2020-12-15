using medicloud.emr.api.DTOs;
using medicloud.emr.api.Entities;
using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaRequestController : ControllerBase
    {
        private readonly IPaRequestRepository _paRequestRepository;
        private readonly IHttpContextAccessor _httpContext;
        public PaRequestController(IPaRequestRepository paRequestRepository, IHttpContextAccessor httpContext)
        {
            _paRequestRepository = paRequestRepository;
            _httpContext = httpContext;
        }

        [HttpGet, Route("GetProcedureByCode")]
        public async Task<IActionResult> GetProcedureByCode(int accountId, string procedureCode)
        {
            try
            {
                var procedure = await _paRequestRepository.GetProcedureByCode(accountId, procedureCode);
                return Ok(procedure);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpGet, Route("GetDiagnosisByCode")]
        public async Task<Diagnosis> GetDiagnosisByCode(int accountId, string diagnosisCode)
        {
            try
            {
                var diagnosis = await _paRequestRepository.GetDiagnosisByCode(accountId, diagnosisCode);
                return diagnosis;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        
        [HttpGet, Route("GetPaRequestHistory")]
        public async Task<IActionResult> GetPaRequestHistory(int accountId, int locationId)
        {
            try
            {
                var paHistory = await _paRequestRepository.GetPaRequestHistory(accountId, locationId);
                return Ok(paHistory);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
        
        [HttpPost("Create")]
        public async Task<IActionResult> Create(PaRequestDTO model)
        {
            try
            {
                await _paRequestRepository.CreatePaRequest(model);
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
