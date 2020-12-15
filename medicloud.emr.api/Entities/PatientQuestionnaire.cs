using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class PatientQuestionnaire
    {
        public int Pqid { get; set; }
        public string Patientid { get; set; }
        public int? Qid { get; set; }
        public int? Qcatid { get; set; }
        public string Patientanswer { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? ProviderId { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual Questionnaire Q { get; set; }
        public virtual QuestionCategory Qcat { get; set; }
    }
}
