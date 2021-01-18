using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public partial class DiagSampleOplabMain
    {
        

        public int Diagsampleid { get; set; }
        public long? Labno { get; set; }
        public int? Hospitallocationid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public int? Serviceid { get; set; }
        public int? Subdeptid { get; set; }
        public int? Departmentid { get; set; }
        public int? Unit { get; set; }
        public int? Encounterid { get; set; }
        public int? Billid { get; set; }
        public int? Orderid { get; set; }
        public string Remarks { get; set; }
        public int? Companyid { get; set; }
        public int? Payorid { get; set; }
        public bool? Stat { get; set; }
        public int? Statusid { get; set; }
        public bool? Isactive { get; set; }
        public int? Encodedby { get; set; }
        public DateTime? Encodeddate { get; set; }
        public bool? Errequest { get; set; }
        public bool? Pocrequest { get; set; }
        public bool? ManualLabNoAuto { get; set; }
        public int? ReportingFacilityId { get; set; }

        public virtual Store Department { get; set; }
        public virtual CheckIn Encounter { get; set; }
        public virtual HospitalLocation Hospitallocation { get; set; }
        public virtual Location Location { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Payer Payor { get; set; }
        public virtual DepartmentSub Subdept { get; set; }
       
    }
}
