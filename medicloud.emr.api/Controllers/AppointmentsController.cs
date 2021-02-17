using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using medicloud.emr.api.DataContextRepo;
using medicloud.emr.api.DTOs;
using medicloud.emr.api.Entities;
using medicloud.emr.api.Helpers;
using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentRepository _repository;
        private readonly IPatientRepo _patientRepo;
        private readonly IBillingRepository _billingRepository;


        public AppointmentsController(IAppointmentRepository repository, IBillingRepository billingRepository, IPatientRepo patientRepo)
        {
            _repository = repository;
            _patientRepo = patientRepo;
            _billingRepository = billingRepository;
        }

        [HttpGet, Route("GetUpcomingAppointments")]
        public async Task<IActionResult> GetUpcomingAppointments(int locationId, int accountId, string searchWord)
        {
            var appointments = await _repository.UpcomingAppointment(locationId, accountId, searchWord);
            return Ok(appointments);
        }

        [HttpGet, Route("GetTodaysAppointments")]
        public async Task<IActionResult> GetTodaysAppointments(int accountId, int locationId)
        {
            var appointments = await _repository.TodaysAppointment(accountId, locationId);
            return Ok(appointments);
        }

        [HttpGet, Route("TotalAppointmentToday")]
        public async Task<IActionResult> TotalAppointmentToday(int locationId, int accountId)
        {
            try
            {
                var result = await _repository.GetTotalAppointmentTodayCount(locationId, accountId);

                TotalsPercentDto response = new TotalsPercentDto
                {
                    isIncrease = result.Item3,
                    TodayTotals = result.Item1,
                    PercentIncrease = result.Item2
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet, Route("TotalAppointmentNoShowToday")]
        public async Task<IActionResult> TotalAppointmentNoShowToday(int locationId, int accountId)
        {
            try
            {
                var result = await _repository.GetAppointmentNoShowTodayCount(locationId, accountId);

                TotalsPercentDto response = new TotalsPercentDto
                {
                    isIncrease = result.Item3,
                    TodayTotals = result.Item1,
                    PercentIncrease = result.Item2
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet("schedules/{locationid}")]
        public async Task<IActionResult> GetGenSchedules(int locationid) => Ok(await _repository.GetGeneralSchedules(locationid));

        [HttpGet("schedules/multipleproviders/({provids})")]
        public async Task<IActionResult> GetActiveGenSchedule([FromRoute]
        [ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<int> provids)
        {
            if (provids is null || provids.Count() < 1)
                return BadRequest(new ErrorResponse { ErrorMessage = "Invalid Ids Passed" });

            return Ok(await _repository.GetMultipleProviderSchedules(provids));
        }


        [HttpPost("schedules/")]
        public async Task<IActionResult> AddGenSchedules(GenSchCreate model)
        {
            await _repository.AddGeneralSchedule(model);
            return NoContent();
        }

        [HttpGet("schedules/{locationid}/specialization/{specid}")]
        public async Task<IActionResult> GetSpecSchedules(int locationid, int specid)
            => Ok(await _repository.GetSpecializationSchedules(locationid, specid));


        [HttpPost("schedules/{locationid}/specialization")]
        public async Task<IActionResult> AddSpecSchedules(int locationid, SpecSchCreate model)
        {
            if (locationid != model.LocationId) return BadRequest(new ErrorResponse { ErrorMessage = "LocationId does not match" });

            await _repository.AddSpecializationSchedule(model);
            return NoContent();
        }

        [HttpGet("schedules/{locationid}/specialization/{specid}/provider/{provid}")]
        public async Task<IActionResult> GetProvSchedules(int locationid, int specid, int provid)
            => Ok(await _repository.GetProviderSchedules(locationid, specid, provid));


        [HttpPost("schedules/{locationid}/specialization/{specid}/provider")]
        public async Task<IActionResult> AddProvSchedules(int locationid, int specid, ProvSchCreate model)
        {
            if (locationid != model.LocationId || specid != model.SpecId)
                return BadRequest(new ErrorResponse { ErrorMessage = "LocationId/SpecializationId does not match" });

            await _repository.AddProviderSchedule(model);
            return NoContent();
        }

        [HttpGet("statuses")]
        public async Task<IActionResult> GetAppointmentStatuses() => Ok(await _repository.GetStatuses());

        [HttpPost("create")]
        public async Task<IActionResult> CreateAppointment(AppointmentCreate model)
        {
            try
            {
                await _repository.AddAppointment(model);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
            
        }

        [HttpPut("update/{apptId}")]
        public async Task<IActionResult> UpdateAppointment(int apptId, AppointmentCreate model)
        {
            try
            {
                if (apptId != model.Id)
                    return BadRequest(new ErrorResponse { ErrorMessage = "Id does not match" });

                model.Date.AddHours(1);

                //(string, bool, bool) updated = await _repository.UpdateAppointment(model);
                var updated = await _repository.UpdateAppointment(model);

                //updateAppointmentResponse updateAppointmentResponse = new updateAppointmentResponse
                //{
                //    CheckinMessage = updated.Item1,
                //    IsCheckedIn = updated.Item2,
                //    IsUpdated = updated.Item3
                //};

                //if (!updated.Item3)
                //    return BadRequest(new ErrorResponse { ErrorMessage = "Record Not Found" });

                if (!updated.Item1)
                {
                    return BadRequest(new ErrorResponse { ErrorMessage = "Record Not Found" });
                }
                    

                if (model.StatusId == 3 && updated.Item2 != null)
                {
                    // add bill
                    BillingInvoice billingInvoice = new BillingInvoice()
                    {
                        patientid = model.PatientNo,
                        ProviderID = model.AccountId,
                        locationid = model.LocationId,
                        encodedby = int.Parse(model.Adjuster),
                        encounterId = updated.Item2
                    };

                    var billResult = await _billingRepository.WritePatientConsultationBill(billingInvoice);
                }

                return Ok(updated);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }


            
        }

        [HttpGet("retrieve/{apptId}")]
        public async Task<IActionResult> GetSingleAppointment(int apptId)
        {
            var appt = await _repository.GetAppointmentForEdit(apptId);
            return Ok(appt);
        }

        [HttpGet, Route("GetPatientAppointmentsToday")]
        public async Task<IActionResult> GetPatientAppointmentsToday(string patientId, int locationId, int accountId)
        {
            try
            {
                var appt = await _repository.GetPatientAppointmentsToday(patientId, locationId, accountId);
                return Ok(appt);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpGet("calendar")]
        public async Task<IActionResult> GetAppointmentsForScheduler([FromQuery] int locationid, [FromQuery] int specid, [FromQuery] IEnumerable<int> provids, [FromQuery] int statusid)
        {
            return Ok(await _repository.GetScheduleAppointments(locationid, specid, provids, statusid));
        }

        //[HttpGet("list")]
        //public async Task<IActionResult> GetAppointmentsForTable() 
        //{
        //    var appointments = await _repository.GetListAppointments();
        //    return Ok(appointments);
        //}

        [HttpGet, Route("list")]
        public async Task<IActionResult> GetAppointmentsForTable(int locationId, int accountId)
        {
            try
            {
                var appointments = await _repository.GetListAppointments(locationId, accountId);
                return Ok(appointments);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
