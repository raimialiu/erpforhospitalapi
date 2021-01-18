using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class OrderTypeDto
    {
        public int Ordertypeid { get; set; }
        public int? ProviderID { get; set; }
        public string Ordername { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }
    }

    public class OrderCategoryDto
    {
        public int Ordercategoryid { get; set; }
        public int? ProviderID { get; set; }
        public int? Ordertypeid { get; set; }
        public string Ordercategory1 { get; set; }
        public string Categorycomment { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
