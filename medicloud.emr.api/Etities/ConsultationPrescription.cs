using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicloud.emr.api.Etities
{
    //Commented this out because of the error message: 2 conflicting definitions of ConsultationPrescription in the dbcontext
    //[Table("Consultation_Prescription")]
    //public partial class ConsultationPrescription
    //{
    //    [Key()]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int Prescriptionid { get; set; }
    //    public string Patientid { get; set; }
    //    public int? Consultationid { get; set; }
    //    public int? ProviderId { get; set; }
    //    public int? Locationid { get; set; }
    //    public int? Indentno { get; set; }
    //    public DateTime? Prescriptiondate { get; set; }
    //    public int? Encounterid { get; set; }
    //    public bool? Ispregnant { get; set; }
    //    public bool? Isnocurrentmedications { get; set; }
    //    public bool? Indentclose { get; set; }
    //    public bool? Isactive { get; set; }
    //    public int? Encodedby { get; set; }
    //    public DateTime? Encodeddate { get; set; }
    //    public int? Doctorid { get; set; }
    //    public bool? Isconsumable { get; set; }
    //    public string Remarks { get; set; }
    //    public int? Orderpriorityid { get; set; }
    //    public int? Indentstoreid { get; set; }
    //    public bool? Issubstitutenotallowed { get; set; }
    //    public int? Durationtype { get; set; }
    //    public DateTime? Dateadded { get; set; }
    //}
}
