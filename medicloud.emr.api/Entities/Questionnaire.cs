using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Questionnaire
    {
        public Questionnaire()
        {
            PatientQuestionnaire = new HashSet<PatientQuestionnaire>();
        }

        public int Qid { get; set; }
        public int? Questioncategoryid { get; set; }
        public string Question { get; set; }
        public string Comments { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual QuestionCategory Questioncategory { get; set; }
        public virtual ICollection<PatientQuestionnaire> PatientQuestionnaire { get; set; }
    }
}
