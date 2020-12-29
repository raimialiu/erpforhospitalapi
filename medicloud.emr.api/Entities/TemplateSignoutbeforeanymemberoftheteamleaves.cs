using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class TemplateSignoutbeforeanymemberoftheteamleaves
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Locationid { get; set; }
        public string Patientid { get; set; }
        public string Hasthenameprocedurebeenrecorded { get; set; }
        public string Hasitbeenconfirmedthattheinstrumentsswabsandsharpcountsarecompleteornotapplicable { get; set; }
        public string Havethespecimensbeenlabeled { get; set; }
        public string Haveanyequipmentproblemsbeenidentifiedthatneedtobeaddressed { get; set; }
        public string Nurseofscrubnurse { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
