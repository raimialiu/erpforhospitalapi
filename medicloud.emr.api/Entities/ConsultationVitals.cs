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
        public int? Temperature { get; set; }
        public int? Respiration { get; set; }
        public int? Pulse { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public int? Bpsystolic { get; set; }
        public int? Bpdiastolic { get; set; }
        public int? HeadCircumference { get; set; }
        public int? MidArmCircumference { get; set; }
        public int? Bmi { get; set; }
        public int? Bsa { get; set; }
        public int? FastingBloodSugar { get; set; }
        public int? RandomBloodSugar { get; set; }
        public int? UrinalysisSg { get; set; }
        public int? UrinalysisPh { get; set; }
        public int? UrinalysisLeu { get; set; }
        public int? UrinalysisNit { get; set; }
        public int? UrinalysisPro { get; set; }
        public int? UrinalysisGlu { get; set; }
        public int? UrinalysisKet { get; set; }
        public int? UrinalysisUbg { get; set; }
        public int? UrinalysisBil { get; set; }
        public int? UrinalysisEry { get; set; }
        public int? UrinalysisHb { get; set; }
        public int? PainScore { get; set; }
        public int? Spo2 { get; set; }
        public string dizziness { get; set; }
        public string needhelpstanding { get; set; }
        public string Anyfall { get; set; }
        public string meanarterialpressure { get; set; }
        public string fetalheartrate { get; set; }
    }
}
