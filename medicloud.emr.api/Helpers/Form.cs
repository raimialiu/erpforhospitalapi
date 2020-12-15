using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Helpers
{
    public class Form
    {
        public List<Columns> components { get; set; } 
      
    }

    public class Component
    {
        public List<Detail> components { get; set; }
    }

    public class Columns
    {
        public List<Component> columns { get; set; }

    }

    public class Detail
    {
        public string key { get; set; }
        public string label { get; set; }
    }

    public class FormData
    {
        public string formname { get; set; }
        public string formdata { get; set; }
    }

    public class FormDirect
    {
        public List<Detail> components { get; set; }

    }


}
