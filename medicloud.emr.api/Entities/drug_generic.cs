using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class drug_generic
    {
        [Key]
        public int genericid { get; set; }
        public string genericname { get; set; }
        public int? CIMSCategoryId { get; set; }
        public int? CIMSSubcategoryId { get; set; }
        public bool? isactive { get; set; }
        public int? Encodedby { get; set; }
        public int? lastchangeby { get; set; }
        public DateTime? lastchangedate { get; set; }
        public DateTime? encodeddate { get; set; }

    }
}
