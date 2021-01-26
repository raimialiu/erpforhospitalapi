using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class allergytype
    {
        [Key]
        public int  typeid { get; set; }
        public int  ProviderId { get; set; }
        public string typename { get; set; }
        public bool isactive { get; set; }
        public int  encodedby { get; set; }
        public DateTime encodeddate { get; set; }
        public int  lastchangedby { get; set; }
        public DateTime lastchangeddate { get; set; }

    }
}
