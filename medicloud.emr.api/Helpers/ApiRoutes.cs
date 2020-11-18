using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Helpers
{
    public class ApiRoutes
    {
        public const string baseUrl = "api/[controller]";
        public const string searchForPatient = baseUrl + "/" + Patient.searchForPatient;

        private class Patient
        {
            public const string searchForPatient = "getPatientBy/{searchValue}";
        }
    }
}
