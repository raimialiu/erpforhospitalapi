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
  public class ConsultationVitalsController : ControllerBase
  {
    private readonly IVitalSignsRepository _VitalSignsRepository;

    public ConsultationVitalsController(IVitalSignsRepository repository)
    {
      _VitalSignsRepository = repository;
    }

    [HttpGet("GetConsultationVitals")]
    public async Task<IActionResult> GetConsultationVitals(string patientid, int ecounterid)
    {
      try
      {
        var getVitals = await _VitalSignsRepository.getConsultationVitals(patientid, ecounterid);
        //var status = true;
        return Ok(getVitals);
      }
      catch (Exception ex)
      {
        var status = false;
        return BadRequest(status);
      }

    }

    [HttpGet("GetConsultationVitalsHistory")]
    public async Task<IActionResult> getConsultationVitalsHistory(string patientid)
    {
      try
      {
        var vitalsHistory = await _VitalSignsRepository.getConsultationVitalsHistory(patientid);
        return Ok(vitalsHistory);
      }
      catch (Exception ex)
      {
        var status = false;
        return BadRequest(status);
      }
    }

    [HttpPost("CreateConsultationVitals")]
    public async Task<IActionResult> CreateConsultationVitals(ConsultationVitals model)
    {
      try
      {
        await _VitalSignsRepository.AddConsultationVitals(model);

        var status = true;
        return Ok(status);
      }
      catch (Exception ex)
      {
        var status = false;
        return BadRequest(status);
      }

    }

    [HttpPost("UpdateVitalSigns")]
    public async Task<IActionResult> UpdateVitalSigns(ConsultationVitals model)
      {

      try
      { 
        await _VitalSignsRepository.UpdateVitalSigns(model);

        var status = true;
        return Ok(status);
      }
      catch (Exception ex)
      {
        var status = false;
        return BadRequest(status);
      }
    }

    [HttpGet, Route("RemoveFromConsultationVitals")]
    public async Task<IActionResult> RemoveFromConsultationVitals(string patientId, int encounterId, int Id)
    {
      try
      {
        await _VitalSignsRepository.RemoveFromConsultationVitals(patientId, encounterId, Id);
        return Ok();
      }
      catch (Exception ex)
      {
        return BadRequest();
      }
    }

  }
}
