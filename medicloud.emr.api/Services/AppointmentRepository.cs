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
        Task<IEnumerable<Status>> GetStatuses();
        Task<IEnumerable<BlockSchedule>> GetBlockSchedules(int locationId, int provId);
        Task<AppointmentCreate> GetAppointmentForEdit(int apptId);
        Task<IEnumerable<AppointmentView>> GetScheduleAppointments(int locationId, int specId, IEnumerable<int> provIds, int statusId);
        Task<IEnumerable<AppointmentList>> GetListAppointments();
        Task AddGeneralSchedule(GenSchCreate model);
        Task AddSpecializationSchedule(SpecSchCreate model);
        Task AddProviderSchedule(ProvSchCreate model);
        Task AddBlockSchedule(BlockScheduleCreate model);
        Task<bool> RemoveBlockSchedule(int blockid);
        Task AddAppointment(AppointmentCreate model);
        Task<bool> UpdateAppointment(AppointmentCreate model);
        Task<List<UpcomingAppointmentList>> UpcomingAppointment(int locationId, int accountId, string searchWord);
        Task<(int, int, bool)> GetTotalAppointmentTodayCount(int locationId, int accountId);
        Task<(int, int, bool)> GetAppointmentNoShowTodayCount(int locationId, int accountId);

    }

    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly DataContext _context;

        public AppointmentRepository(DataContext context)
        {
            _context = context;
        }

        public async Task AddAppointment(AppointmentCreate model)
        {
            var generalSchedule = await _context.GeneralSchedule.FirstOrDefaultAsync(s => s.Locationid == model.LocationId);
            int duration = generalSchedule?.Timeinterval ?? 30;

            var appointment = new AppointmentSchedule
            {
                Starttime = model.Date,
                Endtime = model.Date.AddMinutes(duration),
                Reason = model.Reason,
                Isrecurring = model.IsRecurring,
                Recurrencerule = model.RecurrenceRule,
                Dateadded = DateTime.Now,
                Adjuster = model.Adjuster,
                Locationid = model.LocationId,
                Specid = model.SpecId,
                Provid = model.ProviderId,
                Referralid = model.ReferralTypeId,
                Referringid = model.ReferringPhysicianId,
                Visittypeid = model.VisitTypeId,
                Reminderid = model.ReminderId,
                Statusid = model.StatusId,
                PatientNumber = model.PatientNo
            };

            _context.AppointmentSchedule.Add(appointment);
            await _context.SaveChangesAsync();
        }

        public async Task AddBlockSchedule(BlockScheduleCreate model)
        {
            var activeSchedule = await _context.BreakBlockSchedule.SingleOrDefaultAsync(s => s.Provid == model.ProviderId && s.Iscurrent);

            if (activeSchedule != null)
                activeSchedule.Iscurrent = false;


            var newSchedule = new BreakBlockSchedule
            {
                Starttime = model.Start,
                Endtime = model.End,
                Adjuster = model.Adjuster,
                Iscurrent = true,
                Dateadded = DateTime.Now,
                Locationid = model.LocationId,
                Provid = model.ProviderId,
                Days = model.Days,
                Blockname = model.Blockname
            };

            _context.BreakBlockSchedule.Add(newSchedule);
            await _context.SaveChangesAsync();
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

        public async Task<AppointmentCreate> GetAppointmentForEdit(int apptId)
        {
            return await _context.AppointmentSchedule.Where(x => x.Apptid == apptId)
                .Select(a => new AppointmentCreate
                {
                    Id = a.Apptid,
                    Date = a.Starttime,
                    Reason = a.Reason,
                    IsRecurring = a.Isrecurring,
                    RecurrenceRule = a.Recurrencerule,
                    Adjuster = a.Adjuster,
                    LocationId = a.Locationid.Value,
                    SpecId = a.Specid.Value,
                    ProviderId = a.Provid.Value,
                    ReferralTypeId = a.Referralid.Value,
                    ReferringPhysicianId = a.Referringid.Value,
                    VisitTypeId = a.Visittypeid.Value,
                    ReminderId = a.Reminderid.Value,
                    StatusId = a.Statusid.Value,
                    PatientNo = a.PatientNumber
                })
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<BlockSchedule>> GetBlockSchedules(int locationId, int provId)
        {
            var schedules = _context.BreakBlockSchedule
                .Include(s => s.Location)
                .Include(s => s.Prov)
                .Where(s => s.Locationid == locationId && s.Iscurrent);

            if (provId > 0)
                schedules = schedules.Where(s => s.Provid == provId);

            return await schedules.Select(s => new BlockSchedule
            {
                Id = s.Blockid,
                Start = s.Starttime,
                End = s.Endtime,
                Days = s.Days,
                Adjuster = s.Adjuster,
                Iscurrent = s.Iscurrent,
                Dateadded = s.Dateadded,
                Location = s.Location.Locationname,
                Provider = $"{s.Prov.Firstname} {s.Prov.Lastname}",
                Name = s.Blockname
            }).AsNoTracking().ToListAsync();
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

        public async Task<IEnumerable<AppointmentList>> GetListAppointments()
        {
            return await _context.AppointmentSchedule
            .Include(s => s.PatientNumberNavigation)
            .ThenInclude(p => p.Gender)
            .Include(s => s.Location)
            .Include(s => s.Prov)
            .Include(s => s.Status)
            .Select(s => new AppointmentList
            { 
               Id = s.Apptid,
               PatientNo = s.PatientNumberNavigation.Patientid,
               Name = $"{s.PatientNumberNavigation.Firstname} {s.PatientNumberNavigation.Lastname}",
               Age = DateTime.Now.Year - s.PatientNumberNavigation.Dob.Value.Year,
               Gender = s.PatientNumberNavigation.Gender.Gendername,
               Date = s.Starttime,
               Status = s.Status.Statusname,
               Color = s.Status.Statuscolor,
               Location = s.Location.Locationname,
               Phone = s.PatientNumberNavigation.Mobilephone,
               Provider = $"Dr. {s.Prov.Firstname} {s.Prov.Lastname}"
            }).ToListAsync();

        }

        public async Task<IEnumerable<ProvSchedule>> GetMultipleProviderSchedules(IEnumerable<int> provids)
        {
            var schedules = await _context.ProviderSchedule
                .Include(s => s.Location)
                .Include(s => s.Spec)
                .Include(s => s.Prov)
                .Where(s => provids.Contains(s.Provid.Value) && s.Iscurrent)
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

        public async Task<IEnumerable<AppointmentView>> GetScheduleAppointments(int locationId, int specId, IEnumerable<int> provIds, int statusId)
        {
            var appointmentsQuery = _context.AppointmentSchedule.Where(a => a.Locationid == locationId);

            if (specId > 0)
                appointmentsQuery = appointmentsQuery.Where(a => a.Specid == specId);

            if (provIds.Count() > 0)
                appointmentsQuery = appointmentsQuery.Where(a => provIds.Contains(a.Provid.Value));

            if (statusId > 0)
                appointmentsQuery = appointmentsQuery.Where(a => a.Statusid == statusId);

            var appointments = await appointmentsQuery
            .Include(p => p.PatientNumberNavigation)
            .Include(p => p.Spec)
            .Include(p => p.Status)
            .Select(s => new AppointmentView
            {
                Id = s.Apptid,
                Start = s.Starttime,
                End = s.Endtime,
                StatusColor = s.Status.Statuscolor,
                ProviderId = s.Provid.Value,
                Specialization = s.Spec.Specname,
                RecurrenceRule = s.Recurrencerule,
                PatientName = $"{s.PatientNumberNavigation.Firstname} {s.PatientNumberNavigation.Lastname}"
            }).ToListAsync();
            return appointments;
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

        public async Task<IEnumerable<Status>> GetStatuses()
        {
            return await _context.AppointmentStatus.Select(s => new Status
            { 
               Id = s.Statusid,
               Name = s.Statusname,
               Color = s.Statuscolor
            
            }).AsNoTracking().ToListAsync();

        }

        public async Task<bool> RemoveBlockSchedule(int blockid)
        {
            var blockSchedule = await _context.BreakBlockSchedule.FindAsync(blockid);
            if (blockSchedule is null)
                return false;

            blockSchedule.Iscurrent = false;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateAppointment(AppointmentCreate model)
        {
            var appointment = await _context.AppointmentSchedule.FindAsync(model.Id);
            if (appointment is null)
                return false;

            var generalSchedule = await _context.GeneralSchedule.FirstOrDefaultAsync(s => s.Locationid == model.LocationId);
            int duration = generalSchedule?.Timeinterval ?? 30;


            appointment.Starttime = model.Date;
            appointment.Endtime = model.Date.AddMinutes(duration);
            appointment.Reason = model.Reason;
            appointment.Isrecurring = model.IsRecurring;
            appointment.Recurrencerule = model.RecurrenceRule;
            appointment.Adjuster = model.Adjuster;
            appointment.Locationid = model.LocationId;
            appointment.Specid = model.SpecId;
            appointment.Provid = model.ProviderId;
            appointment.Referralid = model.ReferralTypeId;
            appointment.Referringid = model.ReferringPhysicianId;
            appointment.Visittypeid = model.VisitTypeId;
            appointment.Reminderid = model.ReminderId;
            appointment.Statusid = model.StatusId;
            appointment.PatientNumber = model.PatientNo;
            
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<UpcomingAppointmentList>> UpcomingAppointment (int locationId, int accountId, string searchWord)
        {
            if (!string.IsNullOrEmpty(searchWord))
            {
                var _appointments = await _context.AppointmentSchedule.Where(a => a.Locationid == locationId && a.Provid == accountId &&
                                a.Starttime.Date == DateTime.Today.Date && a.Starttime >= DateTime.Now)
                .Select(r => new UpcomingAppointmentList()
                {
                    Location = _context.Location.Where(l => l.Locationid == r.Locationid).Select(e => e.Locationname).FirstOrDefault(),
                    Date = r.Starttime,
                    Patient = _context.Patient.Where(p => p.Patientid == r.PatientNumber).FirstOrDefault(),
                    Provider = _context.AccountManager.Where(p => p.ProviderId == r.Provid).Select(e => e.HospitalName).FirstOrDefault(),
                    Id = r.Apptid,
                    Status = (int)r.Statusid,
                    Gender = _context.Patient.Where(p => p.Patientid == r.PatientNumber).Select(g => g.Gender.Gendername).FirstOrDefault(),

                }).ToListAsync();

                var appointmentSearch = _appointments.Where(r => r.Patient.Patientid.ToUpper().Contains(searchWord.ToUpper()) || r.Patient.Firstname.ToUpper().Contains(searchWord.ToUpper()) ||
                                                    r.Patient.Lastname.ToUpper().Contains(searchWord.ToUpper()) /*|| r.EncounterId.ToString().ToUpper().Contains(searchWord.ToUpper())*/).ToList();
                return appointmentSearch;
            }

            var appointments = await _context.AppointmentSchedule.Where(a => a.Locationid == locationId && a.Provid == accountId &&
                                a.Starttime.Date == DateTime.Today.Date && a.Starttime >= DateTime.Now)
                .Select(r => new UpcomingAppointmentList()
                {
                    Location = _context.Location.Where(l => l.Locationid == r.Locationid).Select(e => e.Locationname).FirstOrDefault(),
                    Date = r.Starttime,
                    Patient = _context.Patient.Where(p => p.Patientid == r.PatientNumber).FirstOrDefault(),
                    Provider = _context.AccountManager.Where(p => p.ProviderId == r.Provid).Select(e => e.HospitalName).FirstOrDefault(),
                    Id = r.Apptid,
                    Status = (int)r.Statusid,
                    Gender = _context.Patient.Where(p => p.Patientid == r.PatientNumber).Select(g => g.Gender.Gendername).FirstOrDefault(),


                }).ToListAsync();
            return appointments;
        }

        public async Task<(int, int, bool)> GetTotalAppointmentTodayCount(int locationId, int accountId)
        {
            var totalAppointmentToday = await _context.AppointmentSchedule.Where(c => c.Locationid == locationId &&
                         c.Provid == accountId && c.Starttime.Date == DateTime.Today.Date).CountAsync();

            var totalAppointmentSixmonthsAgo = await _context.AppointmentSchedule.Where(c => c.Locationid == locationId &&
                            c.Provid == accountId && c.Starttime.Date >= DateTime.Today.AddMonths(-6).Date).CountAsync();

            var increase = totalAppointmentToday - totalAppointmentSixmonthsAgo;

            decimal percentIncrease;
            decimal div;
            div = (decimal)(increase) / (decimal)totalAppointmentSixmonthsAgo;

            percentIncrease = div * 100;

            var isIncrease = false;

            if (percentIncrease > 0)
            {
                isIncrease = true;
            }
            else if (percentIncrease < 0)
            {
                isIncrease = false;
            }

            percentIncrease = Math.Abs(percentIncrease);
            return (totalAppointmentToday, (int)percentIncrease, isIncrease);
        }

        public async Task<(int, int, bool)> GetAppointmentNoShowTodayCount(int locationId, int accountId)
        {
            var totalPastAppointToday = await _context.AppointmentSchedule.Where(c => c.Locationid == locationId &&
                         c.Provid == accountId && c.Starttime.Date == DateTime.Today.Date && c.Starttime < DateTime.Now).ToListAsync();

            int totalNoShowToday = 0;
            foreach (var item in totalPastAppointToday)
            {
                var isPatientCheckedIn = _context.CheckIn.Where(c => c.Locationid == locationId &&
                         c.Accountid == accountId && c.Patientid == item.PatientNumber && c.CheckInDate.Date == DateTime.Today.Date).Any();

                if (!isPatientCheckedIn)
                {
                    totalNoShowToday++;
                }
            }


            var totalAppointmentSixmonthsAgo = await _context.AppointmentSchedule.Where(c => c.Locationid == locationId &&
                            c.Provid == accountId && c.Starttime >= DateTime.Today.AddMonths(-6).Date).ToListAsync();
            
            int totalNoShowSixMonthsAgo = 0;
            foreach (var item in totalAppointmentSixmonthsAgo)
            {
                var isPatientCheckedIn = _context.CheckIn.Where(c => c.Locationid == locationId &&
                         c.Accountid == accountId && c.Patientid == item.PatientNumber && c.CheckInDate.Date == item.Starttime.Date).Any();

                if (!isPatientCheckedIn)
                {
                    totalNoShowSixMonthsAgo++;
                }
            }


            var increase = totalNoShowToday - totalNoShowSixMonthsAgo;

            decimal percentIncrease;
            decimal div;
            div = (decimal)(increase) / (decimal)totalNoShowSixMonthsAgo;

            percentIncrease = div * 100;

            var isIncrease = false;

            if (percentIncrease > 0)
            {
                isIncrease = true;
            }
            else if (percentIncrease < 0)
            {
                isIncrease = false;
            }

            percentIncrease = Math.Abs(percentIncrease);
            return (totalNoShowToday, (int)percentIncrease, isIncrease);
        }
    }
}
