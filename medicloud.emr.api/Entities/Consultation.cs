using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Consultation
    {
        public Consultation()
        {
            AntenatalRecord = new HashSet<AntenatalRecord>();
            Bill = new HashSet<Bill>();
            ConsultationCheck = new HashSet<ConsultationCheck>();
            ConsultationComplaints = new HashSet<Etities.ConsultationComplaints>();
            ConsultationDental = new HashSet<ConsultationDental>();
            ConsultationDentalProcedure = new HashSet<ConsultationDentalProcedure>();
            ConsultationDiagnosis = new HashSet<ConsultationDiagnosis>();
            ConsultationOtherDiagnosis = new HashSet<ConsultationOtherDiagnosis>();
           // ConsultationPrescription = new HashSet<Etities.ConsultationPrescription>();
            ConsultationProblem = new HashSet<ConsultationProblem>();
            ConsultationProcedure = new HashSet<ConsultationProcedure>();
        }

        public int Consultationid { get; set; }
        public int? Staffid { get; set; }
        public string Patientid { get; set; }
        public int? Deptid { get; set; }
        public string Patienttype { get; set; }
        public string Arrivaltime { get; set; }
        public string Starttime { get; set; }
        public string Endtime { get; set; }
        public string Departuretime { get; set; }
        public string Complaints { get; set; }
        public string Chronicdisease { get; set; }
        public string Findings { get; set; }
        public string Complainthistory { get; set; }
        public string Subjective { get; set; }
        public string Objective { get; set; }
        public string Assessment { get; set; }
        public string Plan { get; set; }
        public string Advice { get; set; }
        public int? Hmoid { get; set; }
        public bool? Isdocattached { get; set; }
        public string Docname { get; set; }
        public string Docpath { get; set; }
        public DateTime? Consultationdate { get; set; }
        public string Casenotes { get; set; }
        public int? ProviderId { get; set; }
        public bool? Isbillgenerated { get; set; }
        public string Proceduredone { get; set; }
        public string Notenote { get; set; }

        public virtual AccountManager Provider { get; set; }
        public virtual ICollection<AntenatalRecord> AntenatalRecord { get; set; }
        public virtual ICollection<Bill> Bill { get; set; }
        public virtual ICollection<ConsultationCheck> ConsultationCheck { get; set; }
        public virtual ICollection<Etities.ConsultationComplaints> ConsultationComplaints { get; set; }
        public virtual ICollection<ConsultationDental> ConsultationDental { get; set; }
        public virtual ICollection<ConsultationDentalProcedure> ConsultationDentalProcedure { get; set; }
        public virtual ICollection<ConsultationDiagnosis> ConsultationDiagnosis { get; set; }
        public virtual ICollection<ConsultationOtherDiagnosis> ConsultationOtherDiagnosis { get; set; }
     //  public virtual ICollection<Etities.ConsultationPrescription> ConsultationPrescription { get; set; }
        public virtual ICollection<ConsultationProblem> ConsultationProblem { get; set; }
        public virtual ICollection<ConsultationProcedure> ConsultationProcedure { get; set; }
    }
}
