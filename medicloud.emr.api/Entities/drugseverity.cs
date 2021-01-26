using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class drugseverity
    {
        [Key]
        public int drugseverityid  { get; set; }
        public string drugseverityname  { get; set; }

    }
}
