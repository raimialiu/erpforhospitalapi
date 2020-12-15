using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class AddCheckInDTO
    {
        public int EncounterId { get; set; }
        public int ProviderId { get; set; }
        public int LocationId { get; set; }
        public string PatientId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public bool isCheckedOut { get; set; }
        public bool isCheckedIn { get; set; }
    }
}
