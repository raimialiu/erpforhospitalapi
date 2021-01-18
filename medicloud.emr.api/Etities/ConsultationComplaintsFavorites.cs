using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicloud.emr.api.Etities
{
    [Table("Consultation_Complaints_Favorites")]
    public partial class ConsultationComplaintsFavorites
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Favoriteid { get; set; }
        public int? Doctorid { get; set; }
        public int? Problemid { get; set; }
        public int? ProviderId { get; set; }
        public int? Locationid { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual EmrProblems Problem { get; set; }
    }
}
