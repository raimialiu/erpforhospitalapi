using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateSegmentalanalysis
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Situs { get; set; }
        public string Avconnection { get; set; }
        public string Vaconnection { get; set; }
        public string Atrialseptum { get; set; }
        public string Leftatrium { get; set; }
        public string Rightatrium { get; set; }
        public string Pda { get; set; }
        public string Lv { get; set; }
        public string Rv { get; set; }
        public string Aorticvalves { get; set; }
        public string Mitralvalves { get; set; }
        public string Mitralvalves1 { get; set; }
        public string Pulmonaryvalves { get; set; }
        public string Pabranches { get; set; }
        public string Mpamm { get; set; }
        public string Rpamm { get; set; }
        public string Lpamm { get; set; }
        public string Pulmonaryveins { get; set; }
        public string Coarctation { get; set; }
        public string Systematicveins { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
