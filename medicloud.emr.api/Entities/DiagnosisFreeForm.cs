using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicloud.emr.api.Entities
{
    [Table("diagnosis_freeform")]
    public partial class DiagnosisFreeForm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Freeformid { get; set; }
        public int? Encounterid { get; set; }
        public string Patientid { get; set; }
        public string Bodyarea { get; set; }
        public string Textvalue { get; set; }
        public int? Providerid { get; set; }
        public int? Locationid { get; set; }
        public DateTime? Dateadded { get; set; }
    }

    public class DiagnosisFreeFormDTO
    {
        public List<DiagnosisFreeForm> values { get; set; }
    }
}
