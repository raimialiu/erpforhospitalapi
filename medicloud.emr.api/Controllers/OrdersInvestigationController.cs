using medicloud.emr.api.DTOs;
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
    public class OrdersInvestigationController : ControllerBase
    {

        private readonly IConsultationDiagnosisRepository _consultationDiagnosisRepository;
        private readonly IOrderInvestigationRepository _orderInvestigationRepository;
        public OrdersInvestigationController(IConsultationDiagnosisRepository consultationDiagnosisRepository, IOrderInvestigationRepository orderInvestigationRepository)
        {
            _consultationDiagnosisRepository = consultationDiagnosisRepository;
            _orderInvestigationRepository = orderInvestigationRepository;
        }

        [HttpGet("GetPatientConsultationDiagnosisByEncounterId")]
        public async Task<IActionResult> GetPatientConsultationDiagnosisByEncounterId(int accountId, string patientId, int encounterId)
        {
            try
            {
                var patientDiagnosis = await _consultationDiagnosisRepository.GetPatientDiagnosisByEncounterId(accountId, patientId, encounterId);
                return Ok(patientDiagnosis);
            }
            catch (Exception ex)
            {
                var status = false;
                return BadRequest(status);
            }

        }

        [HttpPost("CreateOrderInvestigation")]
        public async Task<IActionResult> CreateOrderInvestigation(AddConsultationOrderDto model)
        {
            try
            {
                await _orderInvestigationRepository.AddConsultationOrder(model);
                var status = true;
                return Ok(status);
            }
            catch (Exception ex)
            {
                var status = false;
                return BadRequest(status);
            }

        }
        

        [HttpPost("CreateConsultationOrderFavourite")]
        public async Task<IActionResult> CreateConsultationOrderFavourite(ConsultationOrderFavorites model)
        {
            try
            {
                await _orderInvestigationRepository.AddConsultationOrderFavourites(model);
                var status = true;
                return Ok(status);
            }
            catch (Exception ex)
            {
                var status = false;
                return BadRequest(status);
            }

        }

        [HttpGet("GetPatientConsultationOrder")]
        public async Task<IActionResult> GetPatientConsultationOrder(int accountId, string patientId)
        {
            try
            {
                var patientCOnsultationOrders = await _orderInvestigationRepository.getConsultationOrderByPatientId(accountId, patientId);
                return Ok(patientCOnsultationOrders);
            }
            catch (Exception ex)
            {
                var status = false;
                return BadRequest(status);
            }

        }

        [HttpGet("GetConsultationOrderFavourites")]
        public async Task<IActionResult> GetConsultationOrderFavourites(int accountId, int doctorId, string searchword)
        {
            try
            {
                var patientDiagnosis = await _orderInvestigationRepository.GetConsultationOrdersFavourites(accountId, doctorId, searchword);
                return Ok(patientDiagnosis);
            }
            catch (Exception ex)
            {
                var status = false;
                return BadRequest();
            }

        }

        [HttpGet("GetPatientConsultationOrderDateRange")]
        public async Task<IActionResult> GetPatientConsultationOrderDateRange(int accountId, string patientId, DateTime startDate, DateTime endDate)
        {
            try
            {
                var patientOrderHistory = await _orderInvestigationRepository.getConsultationOrderByPatientIdDateRange(accountId, patientId, startDate, endDate);
                return Ok(patientOrderHistory);
            }
            catch (Exception ex)
            {
                var status = false;
                return BadRequest(status);
            }

        }

        //[HttpGet("GetPatientConsultationOrderToday")]
        //public async Task<IActionResult> GetPatientConsultationOrderToday(int accountId, string patientId, int locationId)
        //{
        //    try
        //    {
        //        var patientDiagnosis = await _consultationDiagnosisRepository.getConsultationDiagnosisByPatientIdToday(accountId, patientId);
        //        return Ok(patientDiagnosis);
        //    }
        //    catch (Exception ex)
        //    {
        //        var status = false;
        //        return BadRequest(status);
        //    }

        //}


        [HttpGet("DeleteConsultationOrder")]
        public async Task<IActionResult> DeleteConsultationOrder(int accountId, int consultationOrderId)
        {
            try
            {
                await _orderInvestigationRepository.DeleteConsultationOrder(accountId, consultationOrderId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

    }
}
