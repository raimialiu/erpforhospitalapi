using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class ConsultationAllergy
    {
        [Key]
        public int Id  { get; set; }
        public string? patientid { get; set; }
        public int? encounterId { get; set; }
        public int? drugId { get; set; }
        public string? reaction { get; set; }
        public string? remarks { get; set; }
        public string? cancellationremarks { get; set; }
        public bool? isactive { get; set; }
        public int? encodedby { get; set; }
        public DateTime? encodeddate { get; set; }
        public int? locationid { get; set; }
        public int? ProviderID { get; set; }
        public bool? isDrugAllergy { get; set; }
        public int? genericid { get; set; }
        public int? allergytypeid { get; set; }
        public int? allergyid { get; set; }
        public int? drugseverityid { get; set; }
        public DateTime? allergydate { get; set; }
        public int? istolerance { get; set; }
        public string? reactions { get; set; }
        public virtual Drug Drug { get; set; }

        public virtual allergymaster AllergyMaster { get; set; }
    }
}
