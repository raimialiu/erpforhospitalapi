using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class PatientsConsultationDiagnosisHistoryDto
    {
        public int Id { get; set; }
        public string Patientid { get; set; }
        public int? Consultationid { get; set; }
        public int? locationid { get; set; }
        public string doctorname { get; set; }
        public string facility { get; set; }
        public string visittypename { get; set; }
        public string diagnosiscode { get; set; }
        public string diagnosisname { get; set; }
        public DateTime? dateadded { get; set; }
        public DateTime? visitdate { get; set; }
        public int? ProviderID { get; set; }
        public int? diagnosislocationid { get; set; }
        public string Status { get; set; }
        public string diagnosisdesc { get; set; }
        public int? genderconstraint { get; set; }
        public int? encounterId { get; set; }
        public bool primarydiagnosis { get; set; }
        public bool ischronic { get; set; }
        public bool isresolved { get; set; }
        public int? doctorid { get; set; }
        public string remarks { get; set; }
        public bool isactive { get; set; }
        public int? encodedby { get; set; }
        public DateTime? encodeddate { get; set; }
        public bool MRDCode { get; set; }
        public bool IsOTDiagnosis { get; set; }
        public int? diagnosisid { get; set; }
        public DateTime? Onsetdate { get; set; }
        public int? Typeid { get; set; }
        public int? conditionid1 { get; set; }
        public int? conditionid2 { get; set; }
        public int? conditionid3 { get; set; }
        public int? isprovisional { get; set; }
    }

    public class ConsultationDiagnosisDto
    {
        public int Id { get; set; }
        public string Patientid { get; set; }
        public int? Consultationid { get; set; }
        public int? locationid { get; set; }
        public string diagnosiscode { get; set; }
        public string diagnosisname { get; set; }
        public DateTime? dateadded { get; set; }
        public int? ProviderID { get; set; }
        public int? diagnosislocationid { get; set; }
        public string Status { get; set; }
        public string diagnosisdesc { get; set; }
        public int? genderconstraint { get; set; }
        public int? encounterId { get; set; }
        public bool primarydiagnosis { get; set; }
        public bool ischronic { get; set; }
        public bool isresolved { get; set; }
        public int? doctorid { get; set; }
        public string remarks { get; set; }
        public bool isactive { get; set; }
        public int? encodedby { get; set; }
        public DateTime? encodeddate { get; set; }
        public bool MRDCode { get; set; }
        public bool IsOTDiagnosis { get; set; }
        public int? diagnosisid { get; set; }
        public DateTime? Onsetdate { get; set; }
        public int? Typeid { get; set; }
        public int? conditionid1 { get; set; }
        public int? conditionid2 { get; set; }
        public int? conditionid3 { get; set; }
        public int? isprovisional { get; set; }
    }
}
