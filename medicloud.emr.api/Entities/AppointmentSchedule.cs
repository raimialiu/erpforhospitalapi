using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace medicloud.emr.api.Entities
{
    public partial class AppointmentSchedule
    {
        [Key]
        public int Apptid { get; set; }
        public DateTime Starttime { get; set; }
        public DateTime Endtime { get; set; }
        public string Reason { get; set; }
        public bool Isrecurring { get; set; }
        public string Recurrencerule { get; set; }
        public DateTime Dateadded { get; set; }
        public string Adjuster { get; set; }
        public int? Locationid { get; set; }
        public int? Specid { get; set; }
        public int? Provid { get; set; }
        public int? ProviderID { get; set; }
        public int? Referralid { get; set; }
        public int? Referringid { get; set; }
        public int? Statusid { get; set; }
        public int? Visittypeid { get; set; }
        public int? Reminderid { get; set; }
        public int? encounterid { get; set; }
        public string PatientNumber { get; set; }

        public virtual Location Location { get; set; }
        public virtual Patient? PatientNumberNavigation { get; set; }
        public virtual ApplicationUser Prov { get; set; }
        public virtual Referral Referral { get; set; }
        public virtual ReferringPhysician Referring { get; set; }
        public virtual Reminder Reminder { get; set; }
        public virtual Specialization Spec { get; set; }
        public virtual AppointmentStatus Status { get; set; }
        public virtual VisitType Visittype { get; set; }
    }
}
