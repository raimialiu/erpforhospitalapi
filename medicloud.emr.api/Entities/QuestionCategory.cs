using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class QuestionCategory
    {
        public QuestionCategory()
        {
            PatientQuestionnaire = new HashSet<PatientQuestionnaire>();
            Questionnaire = new HashSet<Questionnaire>();
        }

        public int Qcatid { get; set; }
        public string Categoryname { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual ICollection<PatientQuestionnaire> PatientQuestionnaire { get; set; }
        public virtual ICollection<Questionnaire> Questionnaire { get; set; }
    }
}
