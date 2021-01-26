using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class ServiceCode
    {
        public int serviceid { get; set; }
        public string cptcode { get; set; }
        public string cptdescription { get; set; }
        public string servicename { get; set; }
        public string alternatecode { get; set; }
        public string comments { get; set; }
        public int? ProviderID { get; set; }
        public int? locationid { get; set; }
        public DateTime? dateadded { get; set; }
        public int? servicecategoryid { get; set; }
    }
}
