using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateLaboratory
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Glands { get; set; }
        public string Tongue { get; set; }
        public string Biochemicaldatalaboratorytestandprocedure { get; set; }
        public string Foodnutritionrelatedhistory2472hoursdietaryrecall { get; set; }
        public string Nutritiondiagnosis { get; set; }
        public string Nutritionintervention { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
