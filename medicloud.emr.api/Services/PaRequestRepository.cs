using medicloud.emr.api.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Services
{
    public class PaRequestRepository
    {
        private readonly DataContext _context;
        public PaRequestRepository(DataContext context)
        {
            _context = context;
        }


    }
}
