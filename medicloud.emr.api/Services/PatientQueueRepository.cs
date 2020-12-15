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
    public interface IPatientQueueRepository
    {
        Task<List<PatientQueueDTO>> PatientQueuesToday(int locationId, int accountId);
    }

    public class PatientQueueRepository : IPatientQueueRepository
    {
        private readonly DataContext _context;
        public PatientQueueRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<PatientQueueDTO>> PatientQueuesToday(int locationId, int accountId)
        {
            var todayQueue = await _context.PatientQueue.Where(p => p.LocationId == locationId && p.AccountId == accountId && p.DateAdded.Value.Date == DateTime.Today.Date).Include(h => h.HospitalUnit).Include(p => p.Patient)
                .Select(r => new PatientQueueDTO
                {
                    AccountId = r.AccountId,
                    EncounterId = r.EncounterId,
                    PatientQueueId = r.PatientQueueId,
                    CheckInDate = _context.CheckIn.Where(c => c.Encounterid == r.EncounterId && c.Locationid == locationId && c.Accountid == accountId && c.Patientid == r.PatientId)
                                .Select(d => d.CheckInDate).FirstOrDefault(),
                    LocationId = r.LocationId,
                    PatientId = r.PatientId,
                    HospitalUnitId = r.HospitalUnitId,
                    Patient = r.Patient,
                    HospitalUnitName = r.HospitalUnit.HospitalUnitName,
                    Gender = _context.Gender.Where(g => g.Genderid == r.Patient.Genderid).Select(n => n.Gendername).FirstOrDefault()


                })
                .ToListAsync();
            return todayQueue;
        }
    }
}
