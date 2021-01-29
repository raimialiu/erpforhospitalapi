using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using medicloud.emr.api.DataContextRepo;
using medicloud.emr.api.DTOs;
using medicloud.emr.api.Helpers;
using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace medicloud.emr.api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DiagnosisSoapController : ControllerBase
  {
    private readonly ISoapRepository _DiagnosisSoapRepository;

    public DiagnosisSoapController(ISoapRepository repository)
    {
      _DiagnosisSoapRepository = repository;
    }

    [HttpGet("GetPatientDiagnosisSoap")]
    public async Task<IActionResult> GetPatientDiagnosisSoap(string patientid, int ecounterid)
    {
      try
      {
        var soapDiagnosis = await _DiagnosisSoapRepository.getDiagnosisSoap(patientid, ecounterid);
        //var status = true;
        return Ok(soapDiagnosis);
      }
      catch (Exception ex)
      {
        var status = false;
        return BadRequest(status);
      }

    }
    [HttpGet("GetPatientDiagnosisSoapHistory")]
    public async Task<IActionResult> getPatientDiagnosisSoapHistory(string patientid)
    {
      try
      {
        var soapDiagnosisHistory = await _DiagnosisSoapRepository.getDiagnosisSoapHistory(patientid);
        //var status = true;
        return Ok(soapDiagnosisHistory);
      }
      catch (Exception ex)
      {
        var status = false;
        return BadRequest(status);
      }
    }
    [HttpGet("GetFilterSoapHistory")]
    public async Task<IActionResult> filterSoapHistory(string patientid, DateTime startDate, DateTime endDate)
    {
      
      try
      {
        var filterSoapHistory = await _DiagnosisSoapRepository.filterSoapHistory(patientid, startDate, endDate);
        //var status = true;
        return Ok(filterSoapHistory);
      }
      catch (Exception ex)
      {
        var status = false;
        return BadRequest(status);
      }
    }
    [HttpPost("CreateDiagnosisSoap")]
    public async Task<IActionResult> CreateDiagnosisSoap(DiagnosisSoap model)
    {
      try
      {
        model.Dateadded = DateTime.Now;
        await _DiagnosisSoapRepository.AddDiagnosisSoap(model);
        var status = true;
        return Ok(status);
      }
      catch (Exception ex)
      {
        var status = false;
        return BadRequest(status);
      }

    }

    [HttpPost("UpdateDiagnosisSoap")]
    public async Task<IActionResult> UpdateDiagnosisSoap(string patientId, int encounterId, string subjective, string objective, string assessment, string plans)
    {
      try
      {
        await _DiagnosisSoapRepository.UpdateDiagnosisSoap(patientId, encounterId, subjective, objective, assessment, plans);
        var status = true;
        return Ok(status);
      }
      catch (Exception ex)
      {
        var status = false;
        return BadRequest(status);
      }

    }

    [HttpGet, Route("RemoveFromDiagnosisSoap")]
    public async Task<IActionResult> RemoveFromDiagnosisSoap(string patientId, int encounterId)
    {
      try
      {
        await _DiagnosisSoapRepository.RemoveFromDiagnosisSoap(patientId, encounterId);
        return Ok();
      }
      catch (Exception ex)
      {
        return BadRequest();
      }
    }

  }

}
