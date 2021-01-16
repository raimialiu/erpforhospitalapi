using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class Diagnosissubgroup
    {
        public int subgroupid { get; set; }
        public string subgroupname { get; set; }
        public string range { get; set; }
        public string rangestart { get; set; }
        public string rangeend { get; set; }
        public int groupid { get; set; }
        public bool isactive { get; set; }
    }
}
