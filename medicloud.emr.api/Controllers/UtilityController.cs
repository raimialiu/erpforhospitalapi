using medicloud.emr.api.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Controllers
{
    [Route("api/utilities")]
    [ApiController]
    public class UtilityController:ControllerBase
    {
        private EmailConfiguration emailConfig;
        private EmailMessageHelper _emailHelper;
        public UtilityController(EmailConfiguration _config)
        {
            //emailConfig = _config;
            _emailHelper = EmailMessageHelper.instance(_config);
        }

        [Route("sendMail")]
        [HttpPost]
        public async Task<IActionResult> SendMail([FromBody] MailBodyDTO mailBodyDTO)
        {
            var result = await _emailHelper.sendMailMailMessageAsync(mailBodyDTO);

            return Ok(result);
        }
    }
}
