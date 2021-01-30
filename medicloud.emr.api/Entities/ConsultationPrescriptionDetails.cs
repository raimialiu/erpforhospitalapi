using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicloud.emr.api.Entities
{
    [Table("Consultation_PrescriptionDetails")]

    public partial class ConsultationPrescriptionDetails
    {
        public int Id { get; set; }
        public int? EncounterId { get; set; }
        public int? Frequencyid { get; set; }
        public int? Doseformid { get; set; }
        public int? Routeid { get; set; }
        public int? Unitid { get; set; }
        public string Icdcode { get; set; }
        public string Comments { get; set; }
        public bool? EmrPrescription { get; set; }
        public bool? Isvoid { get; set; }
        public bool? Isactive { get; set; }
        public int? Encodedby { get; set; }
        public DateTime? Encodeddate { get; set; }
        public int? ItemId { get; set; }
        public bool? Issubstitutenotallowed { get; set; }
        public bool? Isvariabledose { get; set; }
        public bool? Iscapitated { get; set; }
        public bool? Isexcluded { get; set; }
        public bool? Isapprovedrequired { get; set; }
        public int? Locationid { get; set; }
        public int? ProviderId { get; set; }
        public string Patientid { get; set; }
        public int Genericid { get; set; }
        public string Strength { get; set; }
        public DateTime? Startdate { get; set; }
        public int? Refill { get; set; }
        public int? Statusid { get; set; }
        public int? Lastchangeby { get; set; }
        public DateTime? Lastchangedate { get; set; }
        public int? Prescriptionid { get; set; }
        public int? Qty { get; set; }
        public string PrescriptionDetail { get; set; }
        public string Strengthvalue { get; set; }
        public int? Dose { get; set; }
        public int? Durationtype { get; set; }
        public string Medicationinstructions { get; set; }
        public int? Formularyid { get; set; }
        public int? Doctorid { get; set; }
        public int? Dosetime { get; set; }
        public string Preauthorizationno { get; set; }

        public virtual ConsultationPrescription ConsultationPrescription { get; set; }
        public virtual DrugGeneric DrugGeneric { get; set; }

        public virtual StatusMaster Status { get; set; }


    }
}

