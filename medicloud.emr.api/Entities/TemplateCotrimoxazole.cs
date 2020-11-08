using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateCotrimoxazole
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Dose { get; set; }
        public string Adherence { get; set; }
        public string Afraidaffectedbysideeffect { get; set; }
        public string Busyworkingathome { get; set; }
        public string Changeinroutineawayfromhome { get; set; }
        public string Didnotunderstandhowtotakemedications { get; set; }
        public string Didnotwantotherstoknow { get; set; }
        public string Didnotwanttotakemedications { get; set; }
        public string Drugstockout { get; set; }
        public string Fellasleepsleptthroughdose { get; set; }
        public string Feltoverwhelmeddepressed { get; set; }
        public string Feltsickwell { get; set; }
        public string Feltwell { get; set; }
        public string Forgot { get; set; }
        public string Gotpregnancy { get; set; }
        public string Notabletopay { get; set; }
        public string Others { get; set; }
        public string Patientmoved { get; set; }
        public string Ranoutofmedication { get; set; }
        public string Toomanypills { get; set; }
        public string Otherspleasespecify { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
