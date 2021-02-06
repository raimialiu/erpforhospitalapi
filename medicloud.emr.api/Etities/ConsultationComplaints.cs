using medicloud.emr.api.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicloud.emr.api.Etities
{
    [Table("consultation_complaints")]
    public partial class ConsultationComplaints
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Complaintid { get; set; }
        public string Patientid { get; set; }
        public int? Consultationid { get; set; }
        public string Complaints { get; set; }
        public string Duration { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? ProviderId { get; set; }
        public int? Locationid { get; set; }
        public int? EncounterId { get; set; }
        public int? ProblemId { get; set; }
        public string Problemdescription { get; set; }
        public int? Doctorid { get; set; }
        public bool? Isactive { get; set; }
        public int? Encodedby { get; set; }
        public string Remarks { get; set; }
        public int? Lastchangeby { get; set; }
        public DateTime? Lastchangedate { get; set; }
        public string Side { get; set; }
        public int? Onsetid { get; set; }
        public int? Qualityid { get; set; }
        public int? Qualityid1 { get; set; }
        public int? Qualityid2 { get; set; }
        public int? Qualityid3 { get; set; }
        public int? Qualityid4 { get; set; }
        public int? Qualityid5 { get; set; }
        public int? Contextid { get; set; }
        public int? Severityid { get; set; }
        public int? Conditionid { get; set; }
        public int? Percentage { get; set; }
        public int? IsChronic { get; set; }
        public int? AssociatedProblemId1 { get; set; }
        public int? AssociatedProblemId2 { get; set; }
        public int? AssociatedProblemId3 { get; set; }
        public int? AssociatedProblemId4 { get; set; }
        public int? AssociatedProblemId5 { get; set; }
        public int? Durationid { get; set; }
        public string Durationtype { get; set; }

        
        public virtual Consultation Consultation { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual AccountManager Provider { get; set; }


    }
}
