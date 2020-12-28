using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DTOs
{
    public class OptionsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class LocationDTO : OptionsDTO { }


    public class SpecializationDTO : OptionsDTO { }

    public class ProviderDTO : OptionsDTO { }

    public class ReminderDTO : OptionsDTO { }

    public class ReferralDTO : OptionsDTO { }

    public class ReferringDTO : OptionsDTO { }

    public class VisitTypeDTO : OptionsDTO { }


}
