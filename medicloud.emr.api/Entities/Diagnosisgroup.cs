using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class Diagnosisgroup
    {
        public int groupid { get; set; }
        public string groupname { get; set; }
        public string grouptype { get; set; }
        public bool isactive { get; set; }
    }
}
