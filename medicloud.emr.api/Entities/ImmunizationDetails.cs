using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicloud.emr.api.Entities
{
    [Table("immunization_details")]
    public partial class ImmunizationDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public int? Scheduleid { get; set; }
        public int? Immunizationid { get; set; }
        public string Patientid { get; set; }
        public int? Encounterid { get; set; }
        public DateTime? Givendatetime { get; set; }
        public int? Givenby { get; set; }
        public int? Locationid { get; set; }
        public int? Batchno { get; set; }
        public int? Qtygiven { get; set; }
        public bool? Visinfogiven { get; set; }
        public bool? Vaccinegiveninpast { get; set; }
        public bool? Isbillable { get; set; }
        public bool? Rejectedbypatient { get; set; }
        public string Impression { get; set; }
        public bool? Adversereaction { get; set; }
        public string Remarks { get; set; }
        public int? Encodedby { get; set; }
        public DateTime? Encodeddate { get; set; }
        public int? Lastchangeby { get; set; }
        public DateTime? Lastchangeddate { get; set; }
        public int? Brandid { get; set; }
        public bool? Vaccinegivenbyoutsider { get; set; }
        public DateTime? Duedate { get; set; }
        public string Cancellationremarks { get; set; }
    }
}
