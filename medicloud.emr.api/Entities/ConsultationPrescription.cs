using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicloud.emr.api.Entities
{
   
        public partial class ConsultationPrescription
        {
            public int Prescriptionid { get; set; }
            public string Patientid { get; set; }
            public int? Consultationid { get; set; }
            public int? ProviderId { get; set; }
            public int? Locationid { get; set; }
            public int? Indentno { get; set; }
            public DateTime? Prescriptiondate { get; set; }
            public int? Encounterid { get; set; }
            public bool? Ispregnant { get; set; }
            public bool? Isnocurrentmedications { get; set; }
            public bool? Indentclose { get; set; }
            public bool? Isactive { get; set; }
            public int? Encodedby { get; set; }
            public DateTime? Encodeddate { get; set; }
            public int? Doctorid { get; set; }
            public bool? Isconsumable { get; set; }
            public string Remarks { get; set; }
            public int? Orderpriorityid { get; set; }
            public int? Indentstoreid { get; set; }
            public bool? Issubstitutenotallowed { get; set; }
            public int? Durationtype { get; set; }
            public DateTime? Dateadded { get; set; }

            //public virtual ApplicationUser EncodedbyNavigation { get; set; }
            //public virtual CheckIn Encounter { get; set; }
            public virtual Store Indentstore { get; set; }
            public virtual Location Location { get; set; }
            //public virtual OrderPriority Orderpriority { get; set; }
            public virtual Patient Patient { get; set; }
            public virtual AccountManager Provider { get; set; }
        public virtual List<ConsultationPrescriptionDetails> ConsultationPrescriptionDetails { get; set; }
    }
    }


//        ////[Table("Consultation_Prescription")]
//        //public partial class ConsultationPrescription
//        //{
//        //    public int Txnkey { get; set; }
//        //    public string Patientid { get; set; }
//        //    [Key]
//        //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//        //    public int? Consultationid { get; set; }
//        //    public string Drugcode { get; set; }
//        //    public string Drugtype { get; set; }
//        //    public string Drugstrength { get; set; }
//        //    public bool? Isdocattached { get; set; }
//        //    public string Docname { get; set; }
//        //    public string Docpath { get; set; }
//        //    public int? ProviderId { get; set; }
//        //    public string Quantity { get; set; }
//        //    public string Units { get; set; }
//        //    public string Dosage { get; set; }
//        //    public string Frequency { get; set; }
//        //    public int? Duration { get; set; }
//        //    public string Prescriptionnotes { get; set; }
//        //    public bool? Isdispensed { get; set; }
//        //    public bool? Isundispensed { get; set; }
//        //    public DateTime? Dispensedate { get; set; }
//        //    public string Dispensenotes { get; set; }
//        //    public DateTime? Dateadded { get; set; }
//        //    public int? Injectionflow { get; set; }

//        //    public virtual Consultation Consultation { get; set; }
//        //    public virtual Patient Patient { get; set; }
//        //    public virtual AccountManager Provider { get; set; }
//        //}
//    }
//}