using medicloud.emr.api.Data;
using medicloud.emr.api.DTOs;
using medicloud.emr.api.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Controllers
{
    [Route("api/uploadResult")]
    [ApiController]
    public class UploadResulController:ControllerBase
    {
        private DataContext _ctx;
        public UploadResulController()
        {
            _ctx = new DataContext();
        }

        [Route("upload")]
        [HttpPost]
        public async Task<IActionResult> UploadResult([FromBody]UploadResultDTO dto)
        {
            if(dto != null)
            {
                if(dto.uploadedfiles != null)
                {
                    foreach(PatientsUpload t in dto.uploadedfiles)
                    {
                        _ctx.PatientsUpload.Add(t);
                    }

                    return Ok(await _ctx.SaveChangesAsync() > 0);
                }

                return BadRequest(false);
            }

            return BadRequest(false);
        }
        //public async Task<IActionResult> AllOrderType()
        //{

        //}
    }
}
