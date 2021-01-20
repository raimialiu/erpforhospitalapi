using medicloud.emr.api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class CheckInDTO
    {
        public int EncounterId { get; set; }
        public int ProviderId { get; set; }
        public int LocationId { get; set; }
        public string PatientId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime AppointmentDate { get; set; }
        public bool isCheckedOut { get; set; }
        public bool isCheckedIn { get; set; }
        public Patient PatientDetails { get; set; }
        public AppointmentSchedule AppointmentSchedule { get; set; }
    }
}
