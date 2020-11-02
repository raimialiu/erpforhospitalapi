using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Department
    {
        public Department()
        {
            Admission = new HashSet<Admission>();
            Appointment = new HashSet<Appointment>();
            BillDetail = new HashSet<BillDetail>();
            ConsultationLaboratory = new HashSet<ConsultationLaboratory>();
            Personnel = new HashSet<Personnel>();
            QueueManager = new HashSet<QueueManager>();
            Service = new HashSet<Service>();
        }

        public int Deptid { get; set; }
        public string Deptname { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? ProviderId { get; set; }

        public virtual AccountManager Provider { get; set; }
        public virtual ICollection<Admission> Admission { get; set; }
        public virtual ICollection<Appointment> Appointment { get; set; }
        public virtual ICollection<BillDetail> BillDetail { get; set; }
        public virtual ICollection<ConsultationLaboratory> ConsultationLaboratory { get; set; }
        public virtual ICollection<Personnel> Personnel { get; set; }
        public virtual ICollection<QueueManager> QueueManager { get; set; }
        public virtual ICollection<Service> Service { get; set; }
    }
}
