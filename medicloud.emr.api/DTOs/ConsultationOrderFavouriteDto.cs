using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class ConsultationOrderFavouriteDto
    {
        public int FavoriteId { get; set; }
        public int? DoctorId { get; set; }
        public int? serviceid { get; set; }
        public string serviceName { get; set; }
        public int? ProviderID { get; set; }
        public int? LocationId { get; set; }
        public DateTime? DateAdded { get; set; }

    }
}
