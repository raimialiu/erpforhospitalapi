using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class CheckIn
    {
        [Key]
        public int Encounterid { get; set; }
        public string Patientid { get; set; }
        public virtual Patient Patient { get; set; }
        public int ProviderId { get; set; }
        public int EncodedBy { get; set; }
        public virtual AccountManager AccountManager { get; set; }
        public int Locationid { get; set; }
        public virtual Location Location { get; set; }
        public bool IsCheckedIn { get; set; }
        public bool IsCheckedOut { get; set; }
        public bool IsActive { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
    }
}
