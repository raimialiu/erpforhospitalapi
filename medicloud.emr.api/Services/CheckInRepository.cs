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
        Task<(string, bool)> CreaateCheckIn(string patientId, int providerId, int locationId);
        Task<List<CheckInDTO>> GetCheckInList(int locationId, string searchWord, int accountId);
        Task<CheckIn> GetCheckedInPatient(int locationId, string patientId, int accountId);
    }

    public class CheckInRepository : ICheckInRepository
    {
        private readonly DataContext _context;

        public CheckInRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<(string, bool)> CreaateCheckIn(string patientId, int providerId, int locationId)
        {
            var check = await _context.CheckIn.Where(e => e.Patientid == patientId && e.Locationid == locationId && e.Accountid == providerId && e.IsCheckedOut == false).ToListAsync();

            if (check.Count == 0)
            {
                CheckIn checkIn = new CheckIn
                {
                    Accountid = providerId,
                    CheckInDate = DateTime.Now,
                    CheckOutDate = null,
                    IsCheckedIn = true,
                    IsCheckedOut = false,
                    Locationid = locationId,
                    Patientid = patientId
                };

                await _context.AddAsync(checkIn);
                await _context.SaveChangesAsync();

                return ("Patient has been successfully checked-In", true);
            }
            else
            {
                return ("this patient is already checked-In", false);
            }
            
        }

        public async Task<List<CheckInDTO>> GetCheckInList(int locationId, string searchWord, int accountId)
        {
            if (!string.IsNullOrEmpty(searchWord))
            {
                var _result = await _context.CheckIn.Where(c => c.Locationid == locationId && c.IsCheckedOut == false && c.Accountid == accountId).Include(s => s.Patient)/*.ThenInclude(g => g.Gender)*/
                .Select(r => new CheckInDTO
                {
                    CheckInDate = r.CheckInDate,
                    CheckOutDate = r.CheckOutDate.Value,
                    EncounterId = r.Encounterid,
                    isCheckedIn = r.IsCheckedIn,
                    isCheckedOut = r.IsCheckedOut,
                    LocationId = r.Locationid,
                    PatientId = r.Patientid,
                    ProviderId = r.Accountid,
                    PatientDetails = r.Patient

                }).ToListAsync();

                var checkInList = _result.Where(r => r.PatientId.ToUpper().Contains(searchWord.ToUpper()) || r.PatientDetails.Firstname.ToUpper().Contains(searchWord.ToUpper()) ||
                                                    r.PatientDetails.Lastname.ToUpper().Contains(searchWord.ToUpper()) || r.EncounterId.ToString().ToUpper().Contains(searchWord.ToUpper())).ToList();
                return checkInList;
            }

            var result = await _context.CheckIn.Where(c => c.Locationid == locationId && c.IsCheckedOut == false && c.Accountid == accountId).Include(s => s.Patient)/*.ThenInclude(g => g.Gender)*/
                .Select(r => new CheckInDTO
                {
                    CheckInDate = r.CheckInDate,
                    CheckOutDate = r.CheckOutDate.Value,
                    EncounterId = r.Encounterid,
                    isCheckedIn = r.IsCheckedIn,
                    isCheckedOut = r.IsCheckedOut,
                    LocationId = r.Locationid,
                    PatientId = r.Patientid,
                    ProviderId = r.Accountid,
                    PatientDetails = r.Patient

                }).ToListAsync();
            return result;
        }
        
        public async Task<CheckIn> GetCheckedInPatient(int locationId, string patientId, int accountId)
        {
            var result = await _context.CheckIn.Where(c => c.Locationid == locationId && c.IsCheckedOut == false && 
                            c.Accountid == accountId && c.Patientid == patientId).AsNoTracking().FirstOrDefaultAsync();
            return result;
        }

        public async Task CheckOutPatient(string patientId, int locationId, int accountId)
        {
            var result = await _context.CheckIn.Where(c => c.IsCheckedOut == false && c.Patientid == patientId && c.Locationid == locationId && c.Accountid == accountId).FirstOrDefaultAsync();
            if (result != null)
            {
                result.IsCheckedOut = true;
                result.CheckOutDate = DateTime.Now;
                _context.Update(result);
                await _context.SaveChangesAsync();
            }
        }


    }
}
