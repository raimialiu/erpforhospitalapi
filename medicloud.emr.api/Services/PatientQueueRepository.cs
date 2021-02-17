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
        Task RemoveFromQueue(string patientId, int locationId, int accountId);
        Task UpdatePatientLocation(string patientId, int locationId, int accountId, int hospitalUnitId, int newHospitalUnitId, int encounterId);
    }

    public class PatientQueueRepository : IPatientQueueRepository
    {
        private readonly DataContext _context;
        private readonly IPayerInsuranceRepository _payerInsuranceRepository;
        public PatientQueueRepository(DataContext context, IPayerInsuranceRepository payerInsuranceRepository)
        {
            _context = context;
            _payerInsuranceRepository = payerInsuranceRepository;
        }

        public async Task<List<PatientQueueDTO>> PatientQueuesToday(int locationId, int accountId)
        {
            var todayQueue = await _context.PatientQueue.Where(p => p.LocationId == locationId && p.AccountId == accountId && p.DateAdded.Value.Date == DateTime.Today.Date && p.isCheckedOut == false && p.isCurrent == true).Include(h => h.HospitalUnit).Include(p => p.Patient)
                .Select(r => new PatientQueueDTO
                {
                    AccountId = r.AccountId,
                    EncounterId = r.EncounterId,
                    PatientQueueId = r.PatientQueueId,
                    CheckInDate = _context.CheckIn.Where(c => c.Encounterid == r.EncounterId && c.Locationid == locationId && c.ProviderId == accountId && c.Patientid == r.PatientId)
                                .Select(d => d.CheckInDate).FirstOrDefault(),
                    LocationId = r.LocationId,
                    PatientId = r.PatientId,
                    HospitalUnitId = r.HospitalUnitId,
                    Patient = r.Patient,
                    HospitalUnitName = r.HospitalUnit.HospitalUnitName,
                    PatientName = r.Patient.Lastname + " " + r.Patient.Firstname,
                    Gender = _context.Gender.Where(g => g.Genderid == r.Patient.Genderid).Select(n => n.Gendername).FirstOrDefault(),
                    AccountCategory = _payerInsuranceRepository.GetPatientPayerInfo(r.Patient.Payor).Result



        })
                .ToListAsync();
            return todayQueue;
        }


        public async Task RemoveFromQueue(string patientId, int locationId, int accountId)
        {
            var result = await _context.CheckIn.Where(c => c.IsCheckedOut == false && c.Patientid == patientId && c.Locationid == locationId && c.ProviderId == accountId).FirstOrDefaultAsync();
            if (result != null)
            {
                _context.Remove(result);
                await _context.SaveChangesAsync();
            }

            var patientQueue = await _context.PatientQueue.Where(q => q.PatientId == patientId && q.EncounterId == result.Encounterid && 
                                    q.LocationId == locationId && q.AccountId == accountId).FirstOrDefaultAsync();
            if (patientQueue != null)
            {
                _context.Remove(patientQueue);
                await _context.SaveChangesAsync();
            }
        }
        
        public async Task UpdatePatientLocation(string patientId, int locationId, int accountId, int hospitalUnitId, int newHospitalUnitId, int encounterId)
        {
            var patientQueue = await _context.PatientQueue.Where(q => q.PatientId == patientId && q.EncounterId == encounterId && 
                             q.LocationId ==locationId && q.AccountId == accountId && q.HospitalUnitId == hospitalUnitId && q.isCurrent == true).FirstOrDefaultAsync();
            if (patientQueue != null)
            {
                patientQueue.isCurrent = false;
                patientQueue.ChangedLocationAt = DateTime.Now;
                _context.Update(patientQueue);
                await _context.SaveChangesAsync();

                PatientQueue newQueue = new PatientQueue();

                newQueue = patientQueue;
                newQueue.isCurrent = true;
                newQueue.DateAdded = DateTime.Now;
                newQueue.ChangedLocationAt = null;
                newQueue.HospitalUnitId = newHospitalUnitId;
                newQueue.PatientQueueId = 0;
                await _context.AddAsync(newQueue);
                await _context.SaveChangesAsync();

                //_context.Update(patientQueue);
                //await _context.SaveChangesAsync();
            }
        }

    }
}
