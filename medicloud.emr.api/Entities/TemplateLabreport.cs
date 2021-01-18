using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateLabreport
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Bloodgroup { get; set; }
        public string Hb { get; set; }
        public string Tc { get; set; }
        public string Dc { get; set; }
        public string Haematocrit { get; set; }
        public string Plateletcount { get; set; }
        public string Rbs { get; set; }
        public string Urea { get; set; }
        public string Creatinine { get; set; }
        public string Serumna { get; set; }
        public string Serumk { get; set; }
        public string Serumca { get; set; }
        public string T3 { get; set; }
        public string T4 { get; set; }
        public string Tsh { get; set; }
        public string Act { get; set; }
        public string Arterialbloddgas { get; set; }
        public string Ph { get; set; }
        public string Pco2 { get; set; }
        public string Po2 { get; set; }
        public string Hco3 { get; set; }
        public string Be { get; set; }
        public string Lactate { get; set; }
        public string Ecg { get; set; }
        public string Echo { get; set; }
        public string Stressmibi { get; set; }
        public string Tmt { get; set; }
        public string Pft { get; set; }
        public string Minwalk { get; set; }
        public string Xray { get; set; }
        public string Ctscan { get; set; }
        public string Mri { get; set; }
        public string Angio { get; set; }
        public string Petscans { get; set; }
        public string Others { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
