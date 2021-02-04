using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayorInsuranceController: ControllerBase
    {
        private readonly IPayerInsuranceRepository _payerInsuranceRepository;
        public PayorInsuranceController(IPayerInsuranceRepository payerInsuranceRepository)
        {
            _payerInsuranceRepository = payerInsuranceRepository;
        }


        [HttpGet, Route("GetPayerInsuranceInfo")]
        public async Task<IActionResult> GetPayerInsuranceInfo(string payerId)
        {
            try
            {
                var result = await _payerInsuranceRepository.GetPatientPayerInfo(payerId);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        
        [HttpGet, Route("GetPatientPayerList")]
        public async Task<IActionResult> GetPatientPayerList(string patientid)
        {
            try
            {
                var result = await _payerInsuranceRepository.GetPatientPayerList(patientid);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [Route("GetPatientHmoInformation")]
        [HttpGet]
        public async Task<IActionResult> GetPatientHmoInformation(string hmo, string id)
        {

            string hygeia = "https://apps.hygeiahmo.com/hyintermediary/json_enrollee_services.aspx?op=familyinfo&authorization=aGdobW9hcGk6aGcqJDIwMTZAdGVjaA==&dep={dep}&iid={id}";
            string redcare = "https://medicloud.redcarehmo.com/intermediary/json_enrollee_services.aspx?op=familyinfo&authorization=aGdobW9hcGk6aGcqJDIwMTZAdGVjaA==&iid={id}";
            string metrohealth = "https://apps.metrohealthhmo.com/intermediary/json_enrollee_services.aspx?op=familyinfo&authorization=aGdobW9hcGk6aGcqJDIwMTZAdGVjaA==&iid={id}";
            string prohealth = "https://prohealth.ngrok.io/intermediary/json_enrollee_services.aspx?op=familyinfo&authorization=aGdobW9hcGk6aGcqJDIwMTZAdGVjaA==&iid={id}";
            string healthpartners = "https://apps.hpconnect.org/intermediary/json_enrollee_services.aspx?op=familyinfo&authorization=aGdobW9hcGk6aGcqJDIwMTZAdGVjaA==&iid={id}";
            string philipshmo = "https://apps.phillipshmo.net/intermediary/json_enrollee_services.aspx?op=familyinfo&authorization=aGdobW9hcGk6aGcqJDIwMTZAdGVjaA==&iid={id}";

            string urlToCall = "";

            if (hmo.ToLower().Contains("hygeia"))
            {

                var split = id.Split("/");
                urlToCall = hygeia.Replace("{id}", split[0]).Replace("{dep}", split[1]);
                //return this.http.get(urlToCall);
            }

            if (hmo.ToLower().Contains("red care"))
            {
                urlToCall = redcare.Replace("{id}", id);
                //return this.http.get(urlToCall);
            }

            if (hmo.ToLower().Contains("metro health"))
            {
                urlToCall = metrohealth.Replace("{id}", id);
                //return this.http.get(urlToCall);
            }

            if (hmo.ToLower().Contains("pro health"))
            {
                urlToCall = prohealth.Replace("{id}", id);
                //return this.http.get(urlToCall);
            }

            if (hmo.ToLower().Contains("health partners"))
            {
                urlToCall = healthpartners.Replace("{id}", id);
                //return this.http.get(urlToCall);
            }

            if (hmo.ToLower().Contains("philipshmo"))
            {
                urlToCall = philipshmo.Replace("{id}", id);

                //return this.http.get(urlToCall);
            }

            string respponseContent = "";
            var client = new RestClient(urlToCall);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var resp = response.Content;
            return Ok(resp);
        }
    }
}
