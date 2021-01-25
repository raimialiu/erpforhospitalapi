using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicloud.emr.api.Etities
{
    [Table("Consultation_prescription_favorites")]
    public partial class ConsultationPrescriptionFavorites
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FavouriteId { get; set; }
        public int? DoctorId { get; set; }
        public int? ProblemId { get; set; }
        public int? ProviderId { get; set; }
        public int? LocationId { get; set; }
        public DateTime? DateAdded { get; set; }
        public int? EncounterId { get; set; }
        public string Patientid { get; set; }
    }
}
