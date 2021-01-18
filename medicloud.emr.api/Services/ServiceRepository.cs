using medicloud.emr.api.Data;
using medicloud.emr.api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Services
{
    public interface IServiceRepository
    {
        Task<List<Service>> GetServiceList(int accountId, string searchWord);
    }

    public class ServiceRepository : IServiceRepository
    {
        private readonly DataContext _context;

        public ServiceRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Service>> GetServiceList(int accountId, string searchWord)
        {
            if (!string.IsNullOrEmpty(searchWord))
            {
                var services = await _context.Service.Where(a => a.ProviderId == accountId).ToListAsync();
                
                var _servicesSearch = services.Where(a => a.Servicecode.ToUpper().Contains(searchWord.ToUpper()) || a.Servicedesc.ToUpper().Contains(searchWord.ToUpper()))
                .OrderBy(p => p.Servicecode).ToList();

                return _servicesSearch;
            }

            var _services = await _context.Service.Where(a => a.ProviderId == accountId).Take(15).OrderBy(p => p.Servicecode).ToListAsync();

            return _services;
        }

    }
}
