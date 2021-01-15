using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class updateAppointmentResponse
    {
        public string CheckinMessage { get; set; }
        public bool IsCheckedIn { get; set; }
        public bool IsUpdated { get; set; }
    }
}
