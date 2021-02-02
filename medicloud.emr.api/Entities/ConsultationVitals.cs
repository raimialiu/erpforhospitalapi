using System;
using System.Collections.Generic;

namespace medicloud.emr.api
{
    public partial class ConsultationVitals
    {
        public int Id { get; set; }
        public string Patientid { get; set; }
        public int? EncounterId { get; set; }
        public DateTime? Vitalentrydate { get; set; }
        public int? Enteredunitid1 { get; set; }
        public int? Convertedunitid { get; set; }
        public string Remarks { get; set; }
        public int? Encodedby { get; set; }
        public DateTime? Encodeddate { get; set; }
        public int? Templatefieldid { get; set; }
        public int? Billable { get; set; }
        public int? Isactive { get; set; }
        public int? Enteredvalue1 { get; set; }
        public int? Convertedvalue { get; set; }
        public string Cancellationremarks { get; set; }
        public int? Valueid { get; set; }
        public int? Abnormal { get; set; }
        public string Temperature { get; set; }
        public string Respiration { get; set; }
        public string Pulse { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Bpsystolic { get; set; }
        public string Bpdiastolic { get; set; }
        public string HeadCircumference { get; set; }
        public string MidArmCircumference { get; set; }
        public string Bmi { get; set; }
        public string Bsa { get; set; }
        public string FastingBloodSugar { get; set; }
        public string RandomBloodSugar { get; set; }
        public string UrinalysisSg { get; set; }
        public string UrinalysisPh { get; set; }
        public string UrinalysisLeu { get; set; }
        public string UrinalysisNit { get; set; }
        public string UrinalysisPro { get; set; }
        public string UrinalysisGlu { get; set; }
        public string UrinalysisKet { get; set; }
        public string UrinalysisUbg { get; set; }
        public string UrinalysisBil { get; set; }
        public string UrinalysisEry { get; set; }
        public string UrinalysisHb { get; set; }
        public string PainScore { get; set; }
        public string Spo2 { get; set; }
        public string dizziness { get; set; }
        public string needhelpstanding { get; set; }
        public string Anyfall { get; set; }
        public string meanarterialpressure { get; set; }
        public string fetalheartrate { get; set; }
    }
}
