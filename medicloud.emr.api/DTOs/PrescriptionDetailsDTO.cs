using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class PrescriptionDetailsDTO
    {
        public string DrugName { get; set; }
        public string PrescriptionDetail { get; set; }
        public int PrescriptionQuantity { get; set; }
        public int IssuedQuantity { get; set; }
        public int DispensedQuantity { get; set; }
        public int PaNo { get; set; }
        public string status { get; set; }
    }
}
