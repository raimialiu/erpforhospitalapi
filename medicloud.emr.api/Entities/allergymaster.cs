using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Entities
{
    public class allergymaster
    {
        [Key]
        public int allergyid { get; set; }
        public int? providerid { get; set; }
        public int? typeid { get; set; }
        public string? description { get; set; }
        public bool? isactive { get; set; }
         public int? encodedby { get; set; }
        public DateTime? encodeddate { get; set; }
         public int? lastchangedby { get; set; }
        public DateTime? lastchangeddate { get; set; }
         public int? interfacecode { get; set; }
         public int? cimstype { get; set; }
        public virtual ICollection<ConsultationAllergy> ConsultationAllergy { get; set; }

    }
}
