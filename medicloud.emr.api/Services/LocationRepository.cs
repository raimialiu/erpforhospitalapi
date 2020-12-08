using medicloud.emr.api.Data;
using medicloud.emr.api.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Services
{
    public interface ILocationRepository
    {
        Task<IEnumerable<LocationDTO>> GetLocations();
        Task<IEnumerable<SpecializationDTO>> GetSpecializations(int locationid);
        Task<IEnumerable<ProviderDTO>> GetProviders(int locationid, int specid);
    }
    public class LocationRepository : ILocationRepository
    {
        private readonly DataContext _context;

        public LocationRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LocationDTO>> GetLocations()
        {
            return await _context.Location.Where(l => l.Locationid > 2)
                .Select(l => new LocationDTO { Id = l.Locationid, Name = l.Locationname})
                .AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<ProviderDTO>> GetProviders(int locationid, int specid)
        {
            return await _context.ApplicationUser.Where(a => a.Locationid == locationid)
                .Select(u => new ProviderDTO { Id = u.Appuserid, Name = $"{u.Firstname} {u.Lastname}"})
                .AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<SpecializationDTO>> GetSpecializations(int locationid)
        {
            return await _context.Specialization.Where(s => s.Locationid == locationid)
                        .Select(sp => new SpecializationDTO { Id = sp.Specid, Name = sp.Specname})
                        .AsNoTracking().ToListAsync();
        }

    }
}
