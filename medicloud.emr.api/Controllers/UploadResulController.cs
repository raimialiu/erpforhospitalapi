using medicloud.emr.api.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Controllers
{
    [ApiController]
    public class UploadResulController:ControllerBase
    {
        private DataContext _ctx;
        public UploadResulController()
        {
            _ctx = new DataContext();
        }


        //public async Task<IActionResult> AllOrderType()
        //{

        //}
    }
}
