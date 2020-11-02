using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class BirthRegister
    {
        public int Babyid { get; set; }
        public string Patientid { get; set; }
        public DateTime? Deliverydate { get; set; }
        public string Deliverytype { get; set; }
        public string Gender { get; set; }
        public string Familyname { get; set; }
        public string Birthweight { get; set; }
        public int? Babycount { get; set; }
        public string Notes { get; set; }
        public int? Staffid { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? ProviderId { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual Personnel Staff { get; set; }
    }
}
