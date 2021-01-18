using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Reminder
    {
        public int Reminderid { get; set; }
        public string reminder { get; set; }
        public DateTime Dateadded { get; set; }
    }
}
