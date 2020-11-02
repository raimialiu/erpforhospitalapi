using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class HmoMonthlyList
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Othernames { get; set; }
        public string PatientHmoNumber { get; set; }
        public string Plancode { get; set; }
        public string Planname { get; set; }
        public string Servicetype { get; set; }
        public string Phone { get; set; }
        public string Companyname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Month { get; set; }
        public string Hmoname { get; set; }
        public string Status { get; set; }
        public string Startdate { get; set; }
        public string Enddate { get; set; }
        public bool? IsResolved { get; set; }
        public string Year { get; set; }
        public DateTime? Uploaddate { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public int? Hmoid { get; set; }

        public virtual Hmo Hmo { get; set; }
    }
}
