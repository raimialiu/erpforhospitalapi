using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateInterdisciplinarypatientandfamilyeducation
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Educationprovidedby { get; set; }
        public string Educationgivento { get; set; }
        public string Teachingmethod { get; set; }
        public string Language { get; set; }
        public string Teachingtopics { get; set; }
        public string Additionaldetails { get; set; }
        public string Barriersoflearning { get; set; }
        public string Evaluationofteachingsession { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
