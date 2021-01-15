using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class MiniResponseBase
    {
        public bool status { get; set; }
        public string ErrorMessage { get; set; }
    }
}
