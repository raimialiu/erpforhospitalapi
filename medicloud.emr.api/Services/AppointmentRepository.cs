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
        Task<IEnumerable<GeneralSchedule>> GetGeneralSchedules(int locationId);
        Task<IEnumerable<SpecializationSchedule>> GetSpecializationSchedules(int locationId, int specId);
        Task AddGeneralSchedule(GenSchCreate model);
    
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
            var activeSchedule = await _context.GeneralSchedule.SingleOrDefaultAsync(g => g.Iscurrent);

            if (activeSchedule != null)
            {
                activeSchedule.Iscurrent = false;
            }

            var newSchedule = new GeneralSchedule
            {
                Starttime = model.Start,
                Endtime = model.End,
                Timeinterval = model.Interval,
                Adjuster = model.Adjuster,
                Iscurrent = true,
                Dateadded = DateTime.Now,
                Locationid = model.LocationId
            };

            _context.GeneralSchedule.Add(newSchedule);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<GeneralSchedule>> GetGeneralSchedules(int locationId)
        {
            return await _context.GeneralSchedule.Where(g => g.Locationid == locationId)
                .AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<SpecializationSchedule>> GetSpecializationSchedules(int locationId, int specId)
        {
            var schedules = _context.SpecializationSchedule.Where(s => s.Locationid == locationId);
            if (specId > 0)
                schedules = schedules.Where(s => s.Specid == specId);

            return await schedules.AsNoTracking().ToListAsync();
            
        }
    }
}
