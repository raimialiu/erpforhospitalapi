using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateMmodedata
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string La { get; set; }
        public string Ao { get; set; }
        public string Rvawd { get; set; }
        public string Rvdd { get; set; }
        public string Rvsd { get; set; }
        public string Ivsd { get; set; }
        public string Lvdd { get; set; }
        public string Lvpwd { get; set; }
        public string Laao { get; set; }
        public string Ef { get; set; }
        public string Fs { get; set; }
        public string Rvaws { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
