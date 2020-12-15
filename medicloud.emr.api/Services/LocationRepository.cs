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
        Task<IEnumerable<VisitTypeDTO>> GetVisitTypes();
        Task<IEnumerable<ReferralDTO>> GetReferralTypes();
        Task<IEnumerable<ReferringDTO>> GetReferringPhysicians();
        Task<IEnumerable<ReminderDTO>> GetReminderOptions();
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

        public async Task<IEnumerable<ReferralDTO>> GetReferralTypes()
        {
            return await _context.Referral.Select(r => new ReferralDTO { Id = r.Refid, Name = r.Reftype })
                                        .AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<ReferringDTO>> GetReferringPhysicians()
        {
            return await _context.ReferringPhysician.Select(r => new ReferringDTO { Id = r.Refid, Name = r.Physicianname })
                                        .AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<ReminderDTO>> GetReminderOptions()
        {
            return await _context.Reminder.Select(r => new ReminderDTO { Id = r.Reminderid, Name = r.Reminder1 })
                                        .AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<SpecializationDTO>> GetSpecializations(int locationid)
        {
            return await _context.Specialization.Where(s => s.Locationid == locationid)
                        .Select(sp => new SpecializationDTO { Id = sp.Specid, Name = sp.Specname})
                        .AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<VisitTypeDTO>> GetVisitTypes()
        {
            return await _context.VisitType.Select(v => new VisitTypeDTO { Id = v.Typeid, Name = v.Typename })
                                        .AsNoTracking().ToListAsync();
        }
    }
}
