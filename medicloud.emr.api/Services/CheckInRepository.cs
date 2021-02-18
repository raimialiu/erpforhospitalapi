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
    public interface ICheckInRepository
    {
        Task CheckOutPatient(string patientId, int locationId, int accountId);
        Task<(string, bool, int?)> CreaateCheckIn(string patientId, int providerId, int locationId, int userid);
        Task<List<CheckInDTO>> GetCheckInList(int locationId, string searchWord, int accountId);
        Task<CheckIn> GetCheckedInPatient(int locationId, string patientId, int accountId);
        Task<(int, int, bool)> GetTotalCheckInTodayCount(int locationId, int accountId);
        Task<CheckInDTO> GetPatientLatestEncounter(string patientId, int accountId);
    }

    public class CheckInRepository : ICheckInRepository
    {
        private readonly DataContext _context;

        public CheckInRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<(string, bool, int?)> CreaateCheckIn(string patientId, int providerId, int locationId, int userid)
        {
            var getPatientsAppointment = await _context.AppointmentSchedule.Where(a => a.PatientNumber == patientId && 
                                                 a.ProviderID == providerId && a.Locationid == locationId && a.Starttime.Date == DateTime.Today.Date).ToListAsync();

            if (getPatientsAppointment.Count() == 0)
            {
                return ("Patient cannot be checked-In because no appointment was found for the patient", false, null);
            }

            var check = await _context.CheckIn.Where(e => e.Patientid == patientId && e.Locationid == locationId && e.ProviderId == providerId && e.CheckInDate.Date == DateTime.Today.Date && e.IsCheckedOut == false).ToListAsync();

            if (check.Count == 0)
            {
                CheckIn checkIn = new CheckIn
                {
                    ProviderId = providerId,
                    CheckInDate = DateTime.Now,
                    CheckOutDate = null,
                    IsCheckedIn = true,
                    IsCheckedOut = false,
                    Locationid = locationId,
                    Patientid = patientId,
                    IsActive = true,
                    EncodedBy = userid
                };

                var checkin = await _context.AddAsync(checkIn);
                await _context.SaveChangesAsync();

                // insert to patientQueue
                PatientQueue patientQueue = new PatientQueue
                {
                    EncounterId = checkIn.Encounterid,
                    AccountId = checkIn.ProviderId,
                    HospitalUnitId = _context.HospitalUnit.Where(h => h.HospitalUnitName.Contains("frontdesk")).Select(n => n.HospitalUnitId).FirstOrDefault(),
                    LocationId = checkIn.Locationid,
                    PatientId = checkIn.Patientid,
                    DateAdded = DateTime.Now,
                    isCurrent = true
                   
                };

                await _context.AddAsync(patientQueue);
                await _context.SaveChangesAsync();

                if (getPatientsAppointment.Count > 0)
                {
                    foreach (var item in getPatientsAppointment)
                    {
                        item.encounterid = checkin.Entity.Encounterid;
                    }

                    _context.AppointmentSchedule.UpdateRange(getPatientsAppointment);
                    await _context.SaveChangesAsync();
                }
                

                return ("Patient has been successfully checked-In", true, checkin.Entity.Encounterid);
            }
            else
            {
                return ("this patient is already checked-In", false, null);
            }
            
        }

        public async Task<List<CheckInDTO>> GetCheckInList(int locationId, string searchWord, int accountId)
        {
            if (!string.IsNullOrEmpty(searchWord))
            {
                var _result = await _context.CheckIn.Where(c => c.Locationid == locationId && c.IsCheckedOut == false && c.IsActive == true && c.ProviderId == accountId && c.CheckInDate.Date == DateTime.Today.Date).Include(s => s.Patient)/*.ThenInclude(g => g.Gender)*/
                .Select(r => new CheckInDTO
                {
                    CheckInDate = r.CheckInDate,
                    CheckOutDate = r.CheckOutDate.Value,
                    EncounterId = r.Encounterid,
                    isCheckedIn = r.IsCheckedIn,
                    //Is = r.IsActive,
                    isCheckedOut = (bool)r.IsCheckedOut,
                    LocationId = r.Locationid,
                    PatientId = r.Patientid,
                    ProviderId = r.ProviderId,
                    PatientDetails = r.Patient,
                    AppointmentDate = _context.AppointmentSchedule.Where(a => a.Locationid == locationId && a.PatientNumber == r.Patientid && a.ProviderID == accountId && a.Starttime.Date == DateTime.Today.Date).Select(ap => ap.Starttime).FirstOrDefault()

                }).ToListAsync();

                var checkInList = _result.Where(r => r.PatientId.ToUpper().Contains(searchWord.ToUpper()) || r.PatientDetails.Firstname.ToUpper().Contains(searchWord.ToUpper()) ||
                                                    r.PatientDetails.Lastname.ToUpper().Contains(searchWord.ToUpper()) || r.EncounterId.ToString().ToUpper().Contains(searchWord.ToUpper())).ToList();
                return checkInList;
            }

            var result = await _context.CheckIn.Where(c => c.Locationid == locationId && c.IsCheckedOut == false && c.IsActive == true && c.ProviderId == accountId && c.CheckInDate.Date == DateTime.Today.Date).Include(s => s.Patient)/*.ThenInclude(g => g.Gender)*/
                .Select(r => new CheckInDTO
                {
                    CheckInDate = r.CheckInDate,
                    CheckOutDate = r.CheckOutDate.Value,
                    EncounterId = r.Encounterid,
                    isCheckedIn = r.IsCheckedIn,
                    isCheckedOut = (bool)r.IsCheckedOut,
                    LocationId = r.Locationid,
                    PatientId = r.Patientid,
                    ProviderId = r.ProviderId,
                    PatientDetails = r.Patient,
                    AppointmentDate = _context.AppointmentSchedule.Where(a => a.Locationid == locationId && a.PatientNumber == r.Patientid && a.ProviderID == accountId && a.Starttime.Date == DateTime.Today.Date).Select(ap => ap.Starttime).FirstOrDefault()

                }).ToListAsync();
            return result;
        }
        
        public async Task<(int, int, bool)> GetTotalCheckInTodayCount(int locationId, int accountId)
        {
            var totalCheckedInToday = await _context.CheckIn.Where(c => c.Locationid == locationId &&
                         c.ProviderId == accountId && c.CheckInDate.Date == DateTime.Today.Date && c.IsActive == true).CountAsync();

            var totalCheckedInSixmonthsAgo = await _context.CheckIn.Where(c => c.Locationid == locationId && c.IsActive == true &&
                            c.ProviderId == accountId && c.CheckInDate.Date >= DateTime.Today.AddMonths(-6).Date).CountAsync();

            var increase = totalCheckedInToday - totalCheckedInSixmonthsAgo;

            decimal percentIncrease = 0;
            decimal div = 0;
            if (increase > 0 && totalCheckedInSixmonthsAgo > 0)
            {
                div = (decimal)(increase) / (decimal)totalCheckedInSixmonthsAgo;

                percentIncrease = div * 100;
            }
            

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
            return (totalCheckedInToday, (int)percentIncrease, isIncrease);
        }
        
        public async Task<CheckIn> GetCheckedInPatient(int locationId, string patientId, int accountId)
        {
            var result = await _context.CheckIn.Where(c => c.Locationid == locationId && c.IsCheckedOut == false && c.IsActive == true && 
                            c.ProviderId == accountId && c.Patientid == patientId && c.CheckInDate.Date == DateTime.Today.Date).AsNoTracking().FirstOrDefaultAsync();
            return result;
        }
        
        public async Task<CheckInDTO> GetPatientLatestEncounter(string patientId, int accountId)
        {
            var result = await _context.CheckIn.Where(c => c.CheckInDate.Date == DateTime.Today.Date  && c.ProviderId == accountId && c.Patientid == patientId && c.IsCheckedOut == false).AsNoTracking()
                .Select(r => new CheckInDTO
                {
                    CheckInDate = r.CheckInDate,
                    CheckOutDate = r.CheckOutDate.Value,
                    EncounterId = r.Encounterid,
                    isCheckedIn = r.IsCheckedIn,
                    isCheckedOut = (bool)r.IsCheckedOut,
                    LocationId = r.Locationid,
                    PatientId = r.Patientid,
                    ProviderId = r.ProviderId,
                    //PatientDetails = r.Patient,
                    //AppointmentSchedule = _context.AppointmentSchedule.Where(a => a.PatientNumber == r.Patientid && a.ProviderID == accountId && a.Starttime.Date == DateTime.Today.Date).FirstOrDefault()

                }).FirstOrDefaultAsync();
            return result;
        }

        public async Task CheckOutPatient(string patientId, int locationId, int accountId)
        {
            var result = await _context.CheckIn.Where(c => c.IsCheckedOut == false && c.Patientid == patientId && c.Locationid == locationId && c.ProviderId == accountId).FirstOrDefaultAsync();
            if (result != null)
            {
                result.IsCheckedOut = true;
                result.CheckOutDate = DateTime.Now;
                _context.Update(result);
                await _context.SaveChangesAsync();
            }

            var patientQueueList = await _context.PatientQueue.Where(q => q.PatientId == patientId && q.EncounterId == result.Encounterid && 
                                    q.LocationId == locationId && q.AccountId == accountId).ToListAsync();
            if (patientQueueList.Count > 0)
            {
                foreach (var patientQueue in patientQueueList)
                {
                    if (patientQueue.isCurrent)
                    {
                        patientQueue.ChangedLocationAt = DateTime.Now;
                        patientQueue.isCurrent = false;
                    }
                    patientQueue.isCheckedOut = true;
                    _context.Update(patientQueue);
                }
                
                await _context.SaveChangesAsync();
            }
        }


    }
}
