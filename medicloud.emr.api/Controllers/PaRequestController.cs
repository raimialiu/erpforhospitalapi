using medicloud.emr.api.DTOs;
using medicloud.emr.api.Entities;
using medicloud.emr.api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace medicloud.emr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaRequestController : ControllerBase
    {
        private readonly IPaRequestRepository _paRequestRepository;
        public PaRequestController(IPaRequestRepository paRequestRepository)
        {
            _paRequestRepository = paRequestRepository;
        }

        [HttpGet, Route("GetProcedureByCode")]
        public async Task<IActionResult> GetProcedureByCode(string url, string search)
        {
            try
            {
                var client = new HttpClient();

                StringBuilder sb = new StringBuilder();

                string endpoint = url;

                sb.Append(endpoint + "?op=proceduresearchdesc&search=" + search);

                string address = sb.ToString();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  //.Add("authorization", @"aGdobW9hcGk6aGcqJDIwMTZAdGVjaA==");
                var _CredentialBase64 = "aGdobW9hcGk6aGcqJDIwMTZAdGVjaA==";
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Basic {0}", _CredentialBase64));

                var response = client.GetAsync(address).Result;
                var enrolleeJson = response.Content.ReadAsStringAsync().Result;

                var output = JsonConvert.DeserializeObject<List<ProcedureDto>>(enrolleeJson);
                //var procedure = await _paRequestRepository.GetProcedureByCode(accountId, procedureCode);
                return Ok(output);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
        
        [HttpGet, Route("GetProcedureTariff")]
        public async Task<IActionResult> GetProcedureTariff(string url, string procedureCode, string providerID, string submittingProviderID, long memberID)
        {
            try
            {
                var client = new HttpClient();

                StringBuilder sb = new StringBuilder();

                string endpoint = url;

                sb.Append(endpoint + "?op=tariff&procedure=" + procedureCode + "&providerid=" + providerID + "&submitid=" + submittingProviderID + "&encounter=" + DateTime.Now + "&memberid=" + memberID);

                string address = sb.ToString();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  //.Add("authorization", @"aGdobW9hcGk6aGcqJDIwMTZAdGVjaA==");
                var _CredentialBase64 = "aGdobW9hcGk6aGcqJDIwMTZAdGVjaA==";
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Basic {0}", _CredentialBase64));

                var response = client.GetAsync(address).Result;
                var enrolleeJson = response.Content.ReadAsStringAsync().Result;

                var output = JsonConvert.DeserializeObject<List<ProcedureDto>>(enrolleeJson);;
                return Ok(output);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpGet, Route("GetDiagnosisByDesc")]
        public async Task<IActionResult> GetDiagnosisByDesc(string url, string search)
        {
            try
            {
                var client = new HttpClient();

                StringBuilder sb = new StringBuilder();

                string endpoint = url;

                sb.Append(endpoint + "?op=diagnosissearchdesc&search=" + search);

                string address = sb.ToString();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  //.Add("authorization", @"aGdobW9hcGk6aGcqJDIwMTZAdGVjaA==");
                var _CredentialBase64 = "aGdobW9hcGk6aGcqJDIwMTZAdGVjaA==";
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Basic {0}", _CredentialBase64));

                var response = client.GetAsync(address).Result;
                var enrolleeJson = response.Content.ReadAsStringAsync().Result;

                var output = JsonConvert.DeserializeObject<List<DiagnosisDto>>(enrolleeJson);
                //var procedure = await _paRequestRepository.GetProcedureByCode(accountId, procedureCode);
                return Ok(output);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
        
        [HttpGet, Route("GetPaRequestHistory")]
        public async Task<IActionResult> GetPaRequestHistory(string enrolleeNumber, int locationId)
        {
            try
            {
                var client = new HttpClient();

                StringBuilder sb = new StringBuilder();

                string endpoint = "http://localhost/intermediary/JSON_Enrollee_Services.aspx";

                sb.Append(endpoint + "?op=allenrolleeparequest&iid=" + enrolleeNumber);

                string address = sb.ToString();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  //.Add("authorization", @"aGdobW9hcGk6aGcqJDIwMTZAdGVjaA==");
                var _CredentialBase64 = "aGdobW9hcGk6aGcqJDIwMTZAdGVjaA==";
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Basic {0}", _CredentialBase64));

                var response = client.GetAsync(address).Result;
                var enrolleeJson = response.Content.ReadAsStringAsync().Result;

                var output = JsonConvert.DeserializeObject<List<PaRequestHistorApiViewModel>>(enrolleeJson);

                List<PaRequest> paRequest = new List<PaRequest>();
                foreach (var request in output)
                {
                    var dbRequest = await _paRequestRepository.GetPaRequestHistory(request.EnrolleeNumber, request.Requestdate.Value, request.DiagnosisCode,
                        request.DiagnosisDesc, request.ProcedureCode, request.ProcedureDesc);

                    if (dbRequest != null)
                    {
                        dbRequest.PaNumber = request.PANumber.ToString();
                        dbRequest.PaStatus = request.Status;

                        paRequest.Add(dbRequest);


                    }
                    continue;
                }

                await _paRequestRepository.UpdatePaRequest(paRequest);

                var paHistory = await _paRequestRepository.GetPaRequestHistory(enrolleeNumber);

                return Ok(paHistory);

                //;
                //return Ok(paHistory);
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

        [HttpPost("PostToIntermediary")]
        public async Task<IActionResult> PostToIntermediary(PaRequestEx model)
        {
            try
            {
                string providerid = "1461";

                //foreach (var item in model.PaRequests)
                //{
                //    item.DiagnosisCode = "A1882";
                //    item.DiagnosisDesc = "Tuberculosis of other endocrine glands";

                //    item.ProcedureCode = "COT003";
                //    item.ProcedureDesc = "BUDESONIDE200 µg Inhalant";

                //}

                var client = new HttpClient();

                StringBuilder sb = new StringBuilder();

                string endpoint = "http://localhost/intermediary/JSON_Enrollee_Services.aspx";
                
                string sssendpoint = "http://test.medicloud.ng/clearlineportal/api/ProviderAPI/GetAllPARequest/1461";

                var serializedString = JsonConvert.SerializeObject(model.PaRequests);
                
                sb.Append(endpoint + "?op=bulkparequest");

                var formContent = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("paarray", serializedString),
                    new KeyValuePair<string, string>("providerid", providerid)
                });

                string address = sb.ToString();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  //.Add("authorization", @"aGdobW9hcGk6aGcqJDIwMTZAdGVjaA==");
                var _CredentialBase64 = "aGdobW9hcGk6aGcqJDIwMTZAdGVjaA==";
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Basic {0}", _CredentialBase64));

                HttpResponseMessage response = await client.PostAsync(address, formContent);
                var responseString = response.Content.ReadAsStringAsync().Result;

                //var _deserializeString = JsonConvert.DeserializeObject(responseString);
                var deserializeString = JsonConvert.DeserializeObject<paRequestResponse>(responseString);

                return Ok(deserializeString);
            }
            catch (Exception ex)
            {
                var status = false;
                return BadRequest(status);
            }

        }


        [HttpGet, Route("TotalOutStandingPaRequestToday")]
        public async Task<IActionResult> TotalOutStandingPaREquestToday(int locationId, int accountId)
        {
            try
            {
                var result = await _paRequestRepository.GetOutStandingPaRequestTodayCount(locationId, accountId);

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
    }
}
