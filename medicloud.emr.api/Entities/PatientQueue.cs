using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class PatientQueue
    {
        public int PatientQueueId { get; set; }
        public string PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public int AccountId { get; set; }
        public virtual AccountManager AccountManager { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public int HospitalUnitId { get; set; }
        public virtual HospitalUnit HospitalUnit { get; set; }
        public int EncounterId { get; set; }
        [NotMapped]
        public DateTime? LastVisit { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? ChangedLocationAt { get; set; }
        public bool isCheckedOut { get; set; }
        public bool isCurrent { get; set; }
    }
}
