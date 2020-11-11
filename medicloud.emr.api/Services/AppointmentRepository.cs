using medicloud.emr.api.Data;
using medicloud.emr.api.DTOs;
using medicloud.emr.api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Services
{
    public interface IAppointmentRepository
    {
        Task<IEnumerable<GenSchedule>> GetGeneralSchedules(int locationId);
        Task<IEnumerable<SpecSchedule>> GetSpecializationSchedules(int locationId, int specId);
        Task<IEnumerable<ProvSchedule>> GetProviderSchedules(int locationId, int specId, int provId);
        Task<IEnumerable<ProvSchedule>> GetMultipleProviderSchedules(IEnumerable<int> provids);
        Task AddGeneralSchedule(GenSchCreate model);
        Task AddSpecializationSchedule(SpecSchCreate model);
        Task AddProviderSchedule(ProvSchCreate model);

    }

    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly DataContext _context;

        public AppointmentRepository(DataContext context)
        {
            _context = context;
        }

        public async Task AddGeneralSchedule(GenSchCreate model)
        {
            var activeSchedule = await _context.GeneralSchedule.SingleOrDefaultAsync(g => g.Locationid == model.LocationId && g.Iscurrent);

            if (activeSchedule != null)          
                activeSchedule.Iscurrent = false;
            
            var newSchedule = new GeneralSchedule
            {
                Starttime = model.Start,
                Endtime = model.End,
                Timeinterval = model.Duration,
                Adjuster = model.Adjuster,
                Iscurrent = true,
                Dateadded = DateTime.Now,
                Locationid = model.LocationId
            };

            _context.GeneralSchedule.Add(newSchedule);
            await _context.SaveChangesAsync();
        }

        public async Task AddProviderSchedule(ProvSchCreate model)
        {
            var activeSchedule = await _context.ProviderSchedule.SingleOrDefaultAsync(s => s.Provid == model.ProvId && s.Iscurrent);

            if (activeSchedule != null)
                activeSchedule.Iscurrent = false;


            var newSchedule = new ProviderSchedule
            {
                Starttime = model.Start,
                Endtime = model.End,
                Duration = model.Duration,
                Adjuster = model.Adjuster,
                Iscurrent = true,
                Dateadded = DateTime.Now,
                Locationid = model.LocationId,
                Specid = model.SpecId,
                Provid = model.ProvId,
                Days = model.Days,
            };

            _context.ProviderSchedule.Add(newSchedule);
            await _context.SaveChangesAsync();
        }

        public async Task AddSpecializationSchedule(SpecSchCreate model)
        {
            var activeSchedule = await _context.SpecializationSchedule.SingleOrDefaultAsync(s => s.Specid == model.SpecId && s.Iscurrent);

            if (activeSchedule != null)
                activeSchedule.Iscurrent = false;
            

            var newSchedule = new SpecializationSchedule
            {
                Starttime = model.Start,
                Endtime = model.End,
                Duration = model.Duration,
                Adjuster = model.Adjuster,
                Iscurrent = true,
                Dateadded = DateTime.Now,
                Locationid = model.LocationId,
                Specid = model.SpecId,
                Days = model.Days,
            };

            _context.SpecializationSchedule.Add(newSchedule);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<GenSchedule>> GetGeneralSchedules(int locationId)
        {
            return await _context.GeneralSchedule.Where(g => g.Locationid == locationId)
                .Include(l => l.Location)
                .OrderByDescending(w => w.Iscurrent)
                .Select(g => new GenSchedule
                {
                    Starttime = g.Starttime,
                    Endtime = g.Endtime,
                    Adjuster = g.Adjuster,
                    Dateadded = g.Dateadded,
                    Duration = g.Timeinterval,
                    Genschid = g.Genschid,
                    Iscurrent = g.Iscurrent,
                    Locationname = g.Location.Locationname
                })
                .AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<ProvSchedule>> GetMultipleProviderSchedules(IEnumerable<int> provids)
        {
            var schedules = await _context.ProviderSchedule
                .Include(s => s.Location)
                .Include(s => s.Spec)
                .Include(s => s.Prov)
                .Where(s => provids.Contains(s.Provschid) && s.Iscurrent)
                .Select(s => new ProvSchedule
                {
                    Provschid = s.Provschid,
                    Starttime = s.Starttime,
                    Endtime = s.Endtime,
                    Duration = s.Duration,
                    Days = s.Days,
                    Adjuster = s.Adjuster,
                    Iscurrent = s.Iscurrent,
                    Dateadded = s.Dateadded,
                    Locationname = s.Location.Locationname,
                    Specname = s.Spec.Specname,
                    Providername = $"Dr. {s.Prov.Firstname} {s.Prov.Lastname}",
                    Provid = s.Prov.Appuserid
                }).AsNoTracking().ToListAsync();

            return schedules;
        }

        public async Task<IEnumerable<ProvSchedule>> GetProviderSchedules(int locationId, int specId, int provId)
        {
            var schedules = _context.ProviderSchedule
                .Include(s => s.Location)
                .Include(s => s.Spec)
                .Include(s => s.Prov)
                .Where(s => s.Locationid == locationId && s.Iscurrent);

            if (specId > 0)
                schedules = schedules.Where(s => s.Specid == specId);

            if (provId > 0)
                schedules = schedules.Where(s => s.Provid == provId);

            return await schedules.Select(s => new ProvSchedule
            {
                Provschid = s.Provschid,
                Starttime = s.Starttime,
                Endtime = s.Endtime,
                Duration = s.Duration,
                Days = s.Days,
                Adjuster = s.Adjuster,
                Iscurrent = s.Iscurrent,
                Dateadded = s.Dateadded,
                Locationname = s.Location.Locationname,
                Specname = s.Spec.Specname,
                Providername = $"{s.Prov.Firstname} {s.Prov.Lastname}",
                Provid = s.Prov.Appuserid
            }).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<SpecSchedule>> GetSpecializationSchedules(int locationId, int specId)
        {
            var schedules = _context.SpecializationSchedule
                .Include(s => s.Location)
                .Include(s => s.Spec)
                .Where(s => s.Locationid == locationId && s.Iscurrent);

            if (specId > 0)
                schedules = schedules.Where(s => s.Specid == specId);

            return await schedules.Select(s => new SpecSchedule
            {
                Specschid = s.Specschid,
                Starttime = s.Starttime,
                Endtime = s.Endtime,
                Duration = s.Duration,
                Days = s.Days,
                Adjuster = s.Adjuster,
                Iscurrent = s.Iscurrent,
                Dateadded = s.Dateadded,
                Locationname = s.Location.Locationname,
                Specname = s.Spec.Specname
            }).AsNoTracking().ToListAsync();
        }
    }
}
