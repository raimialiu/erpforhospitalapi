using medicloud.emr.api.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace medicloud.emr.api.DTOs
{

    public class Schedule
    {
        public string Starttime { get; set; }
        public string Endtime { get; set; }
        public int Duration { get; set; }
        public string Adjuster { get; set; }
        public bool Iscurrent { get; set; }
        public DateTime Dateadded { get; set; }
        public string Locationname { get; set; }
    }

    public class GenSchedule : Schedule
    {
        public int Genschid { get; set; }
    }
    public class GenSchCreate
    {
        [Required]
        public string Start { get; set; }
        [Required]
        public string End { get; set; }
        [Range(1, 120)]
        public int Duration { get; set; }
        [Required]
        public string Adjuster { get; set; }
        [Range(3,5)]
        public int LocationId { get; set; }
    }

    public class SpecSchCreate : GenSchCreate
    {
        [Required]
        public string Days { get; set; }
        public int SpecId { get; set; }
    }

    public class SpecSchedule : Schedule
    {
        public int Specschid { get; set; }
        public string Days { get; set; }
        public string Specname { get; set; }
    }

    public class ProvSchCreate : SpecSchCreate
    {
        public int ProvId { get; set; }
    }

    public class ProvSchedule : Schedule
    {
        public int Provschid { get; set; }
        public string Days { get; set; }
        public string Specname { get; set; }
        public string Providername { get; set; }
        public int Provid { get; set; }
    }

    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }

    public class BlockSchedule
    {
        public int Id { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Days { get; set; }
        public string Name { get; set; }
        public string Adjuster { get; set; }
        public string Location { get; set; }
        public string Provider { get; set; }
        public DateTime Dateadded { get; set; }
        public bool Iscurrent { get; set; }
    }

    public class BlockScheduleCreate
    {
        [Required]
        public string Start { get; set; }
        [Required]
        public string End { get; set; }
        [Required]
        public string Days { get; set; }
        [Required]
        public string Adjuster { get; set; }
        [Required]
        public string Blockname { get; set; }
        public int LocationId { get; set; }
        public int ProviderId { get; set; }
    }

    public class AppointmentCreate
    {
        public int Id { get; set; }
        [Required]
        public string PatientNo { get; set; }
        public DateTime Date { get; set; }
        public int LocationId { get; set; }
        public int SpecId { get; set; }
        public int ProviderId { get; set; }
        public int VisitTypeId { get; set; }
        public int StatusId { get; set; }
        public int ReferralTypeId { get; set; }
        public int ReferringPhysicianId { get; set; }
        public int ReminderId { get; set; }
        public string Reason { get; set; }
        public bool IsRecurring { get; set; }
        public string RecurrenceRule { get; set; }
        [Required]
        public string Adjuster { get; set; }
    }

    public class AppointmentView
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string Specialization { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string RecurrenceRule { get; set; }
        public string StatusColor { get; set; }
        public int ProviderId { get; set; }
    }

    public class AppointmentList
    {
        public int Id { get; set; }
        public string PatientNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Provider { get; set; }
        public string Status { get; set; }
        public string Color { get; set; }
    }

    public class UpcomingAppointmentList
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Provider { get; set; }
        public int Status { get; set; }
        public string Color { get; set; }
        public Patient Patient { get; set; }

    }
}
