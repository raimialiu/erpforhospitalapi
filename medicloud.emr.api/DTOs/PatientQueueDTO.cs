using medicloud.emr.api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class PatientQueueDTO
    {
        public int PatientQueueId { get; set; }
        public string PatientId { get; set; }
        public Patient Patient { get; set; }
        public int AccountId { get; set; }
        public string Payer { get; set; }
        public PayerDto AccountCategory { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int HospitalUnitId { get; set; }
        public string HospitalUnitName { get; set; }
        public string Gender { get; set; }
        public string PatientName { get; set; }
        public int EncounterId { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}
