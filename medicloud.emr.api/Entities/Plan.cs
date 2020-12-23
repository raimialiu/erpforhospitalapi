using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Plan
    {
        public Plan()
        {
            Enrollee = new HashSet<Enrollee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<Enrollee> Enrollee { get; set; }
    }

    public class PlanType
    {
        public int planid { get; set; }
        public string planname { get; set; }
        //public string Description { get; set; }
        public DateTime? dateadded { get; set; }
        public int? payerid { get; set; }
        public int? sponsid { get; set; }
        public int? accountcatid { get; set; }


    }


}
