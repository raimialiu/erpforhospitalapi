using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    [Table("PatientUpload")]
    public class PatientsUpload
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string patientid { get; set; }
        public string uploadtype { get; set; }
        public string filename { get; set; }
        public string fileitem { get; set; }
        public string filetype { get; set; }
        public string filesize { get; set; }
        public int? adjusterid { get; set; }
        public int? encounterId { get; set; }
        public int? providerId { get; set; }
        public int? locationId { get; set; }
        public DateTime dateadded { get; set; }
        public string ordertypename { get; set; }
    }
}
