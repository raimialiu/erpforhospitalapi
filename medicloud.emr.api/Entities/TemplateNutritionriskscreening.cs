using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateNutritionriskscreening
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Hasfoodintakedeclinedoverthe3monthduetoloseofappetit { get; set; }
        public string Difficultyinchewing { get; set; }
        public string Difficultyinswallowing { get; set; }
        public string Recentunexplainedweightlossorgainduringlastmonths { get; set; }
        public string Pallorsunkeneyesdehydrationanorexia { get; set; }
        public string Vomitingdiarrheaedema { get; set; }
        public string Receivinganytubefeeding { get; set; }
        public string Hairchangeandskinchange { get; set; }
        public string Hasfoodintakedeclinedoverthepast3monthduetoloseappetite { get; set; }
        public string Difficultyinchewing1 { get; set; }
        public string Difficultyinswallowing1 { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
