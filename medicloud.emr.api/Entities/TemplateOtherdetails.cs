using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateOtherdetails
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Otherdrugsprescribed { get; set; }
        public string Othertestdone { get; set; }
        public string Consulthospitalizereferlink { get; set; }
        public string Nextappointmentdata { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
