using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class OrderDetails
    {
        public int serviceid { get; set; }
        public string servicename { get; set; }
        public int? ordercategoryid { get; set; }
        public int? providerId { get; set; }
        public bool doctorrequired { get; set; }
        public bool differbybedcategory { get; set; }
        public bool differbypercentage { get; set; }
        public bool priceeditable { get; set; }
        public bool isactive { get; set; }
        public int? encodedby { get; set; }
        public DateTime? encodeddate { get; set; }
    }
}
