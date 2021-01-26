using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class BillType
    {
        public int billtypeid { get; set; }
        public int? ProviderID { get; set; }
        public int? locationid { get; set; }
        public DateTime? dateadded { get; set; }
        public string billtypename { get; set; }
        public string billtypedescription { get; set; }
        public string alternatecode { get; set; }
        public string comments { get; set; }
    }
}
