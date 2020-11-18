using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Helpers
{
    public class SwaggerSettings
    {
        public string RouteTemplate { get; set; }
        public string RouteEndpoint { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
    }
}
