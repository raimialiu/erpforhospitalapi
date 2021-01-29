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
    public interface IConsultationDiagnosisRepository
    {
        Task<List<PatientsConsultationDiagnosisHistoryDto>> getConsultationDiagnosisByPatientId(int accountId, string patientNo);
        Task AddConsultationDiagnosisFavourites(ConsultationDiagnosisFavourites model);
        Task AddConsultationDiagnosis(ConsultationDiagnosis model);
        Task<List<ConsultationDiagnosisFavouriteDto>> GetConsultationDiagnosisFavourites(int accountId, int doctorId, string searchword);
        Task<List<ConsultationDiagnosisDto>> getConsultationDiagnosisByPatientIdToday(int accountId, string patientNo);
        Task<List<PatientsConsultationDiagnosisHistoryDto>> getConsultationDiagnosisByPatientIdDateRange(int accountId, string patientNo, DateTime startDate, DateTime EndDate);
        Task DeleteConsultationDiagnosis(int accountId, int consultationDiagnosisId);
        Task<ConsultationDiagnosisDto> GetPatientDiagnosisByEncounterId(int accountId, string patientId, int encounterId);

    }

    public class ConsultationDiagnosisRepository : IConsultationDiagnosisRepository
    {
        private readonly DataContext _context;
        private readonly ICheckInRepository _checkInRepository;

        public ConsultationDiagnosisRepository(DataContext context, ICheckInRepository checkInRepository)
        {
            _context = context;
            _checkInRepository = checkInRepository;
        }


        public async Task<List<PatientsConsultationDiagnosisHistoryDto>> getConsultationDiagnosisByPatientId(int accountId, string patientNo)
        {
            var result = await _context.ConsultationDiagnosis.Where(c => c.ProviderID == accountId && c.Patientid == patientNo)
                .Select(a => new PatientsConsultationDiagnosisHistoryDto()
                {
                    diagnosiscode = a.diagnosiscode,
                    conditionid1 = a.conditionid1,
                    conditionid2 = a.conditionid2,
                    conditionid3 = a.conditionid3,
                    dateadded = a.dateadded,
                    diagnosisdesc = _context.Diagnosis.Where(d => d.diagnosisid == a.diagnosisid && d.ICDCode == a.diagnosiscode).Select(r => r.Name).FirstOrDefault(),
                    Patientid = a.Patientid,
                    primarydiagnosis = a.primarydiagnosis,
                    ischronic = a.ischronic,
                    isprovisional = a.isprovisional,
                    isresolved = a.isresolved,
                    doctorid = a.doctorid,
                    diagnosisname = _context.Diagnosis.Where(d => d.diagnosisid == a.diagnosisid && d.ICDCode == a.diagnosiscode).Select(r => r.Name).FirstOrDefault(),
                    isactive = a.isactive,
                    diagnosisid = a.diagnosisid,
                    Id = a.Id,
                    encounterId = a.encounterId,
                    facility = _context.Location.Where(l => l.Locationid == a.locationid).Select(d => d.Locationname).FirstOrDefault() != null ? _context.Location.Where(l => l.Locationid == a.locationid).Select(d => d.Locationname).FirstOrDefault() : "",
                    //visitdate = _context.AppointmentSchedule.Where(ap => ap.PatientNumber == a.Patientid && ap.ProviderID == accountId && ap.Starttime.Date == a.dateadded.Value.Date).Select(ap => ap.Starttime.Date).FirstOrDefault(), /*!= null ? _context.AppointmentSchedule.Where(ap => ap.PatientNumber == a.Patientid && ap.ProviderID == accountId && ap.Starttime.Date == a.dateadded.Value.Date).Select(ap => ap.Starttime.Date).FirstOrDefault() : null*/
                    doctorname = _context.ApplicationUser.Where(o => o.Appuserid == a.doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                }).ToListAsync();

            return result;

        }
    
        public async Task<List<PatientsConsultationDiagnosisHistoryDto>> getConsultationDiagnosisByPatientIdDateRange(int accountId, string patientNo, DateTime startDate, DateTime endDate)
        {
            var result = await _context.ConsultationDiagnosis.Where(c => c.ProviderID == accountId && c.Patientid == patientNo && c.dateadded.Value.Date >= startDate.Date && c.dateadded.Value.Date <= endDate)
                .Select(a => new PatientsConsultationDiagnosisHistoryDto()
                {
                    diagnosiscode = a.diagnosiscode,
                    conditionid1 = a.conditionid1,
                    conditionid2 = a.conditionid2,
                    conditionid3 = a.conditionid3,
                    dateadded = a.dateadded,
                    diagnosisdesc = _context.Diagnosis.Where(d => d.diagnosisid == a.diagnosisid && d.ICDCode == a.diagnosiscode).Select(r => r.Name).FirstOrDefault(),
                    Patientid = a.Patientid,
                    primarydiagnosis = a.primarydiagnosis,
                    ischronic = a.ischronic,
                    isprovisional = a.isprovisional,
                    isresolved = a.isresolved,
                    doctorid = a.doctorid,
                    diagnosisname = _context.Diagnosis.Where(d => d.diagnosisid == a.diagnosisid && d.ICDCode == a.diagnosiscode).Select(r => r.Name).FirstOrDefault(),
                    isactive = a.isactive,
                    diagnosisid = a.diagnosisid,
                    Id = a.Id,
                    encounterId = a.encounterId,
                    facility = _context.Location.Where(l => l.Locationid == a.locationid).Select(d => d.Locationname).FirstOrDefault() != null ? _context.Location.Where(l => l.Locationid == a.locationid).Select(d => d.Locationname).FirstOrDefault() : "",
                    //visitdate = _context.AppointmentSchedule.Where(ap => ap.PatientNumber == a.Patientid && ap.ProviderID == accountId && ap.Starttime.Date == a.dateadded.Value.Date).Select(ap => ap.Starttime.Date).FirstOrDefault(), /*!= null ? _context.AppointmentSchedule.Where(ap => ap.PatientNumber == a.Patientid && ap.ProviderID == accountId && ap.Starttime.Date == a.dateadded.Value.Date).Select(ap => ap.Starttime.Date).FirstOrDefault() : null*/
                    doctorname = _context.ApplicationUser.Where(o => o.Appuserid == a.doctorid).Select(o => o.Lastname + " " + o.Firstname).FirstOrDefault(),
                }).ToListAsync();

            return result;

        }
    
        public async Task<List<ConsultationDiagnosisDto>> getConsultationDiagnosisByPatientIdToday(int accountId, string patientNo)
        {
            var result = await _context.ConsultationDiagnosis.Where(c => c.ProviderID == accountId && c.Patientid == patientNo && c.dateadded.Value.Date == DateTime.Today.Date)
                .Select(a => new ConsultationDiagnosisDto() { 
                    diagnosiscode = a.diagnosiscode,
                    conditionid1 = a.conditionid1,
                    conditionid2 = a.conditionid2,
                    conditionid3 = a.conditionid3,
                    dateadded = a.dateadded,
                    diagnosisdesc = _context.Diagnosis.Where(d => d.diagnosisid == a.diagnosisid && d.ICDCode == a.diagnosiscode).Select(r => r.Name).FirstOrDefault(),
                    Patientid = a.Patientid,
                    primarydiagnosis = a.primarydiagnosis,
                    ischronic = a.ischronic,
                    isprovisional = a.isprovisional,
                    isresolved = a.isresolved,
                    doctorid = a.doctorid,
                    diagnosisname = _context.Diagnosis.Where(d => d.diagnosisid == a.diagnosisid && d.ICDCode == a.diagnosiscode).Select(r => r.Name).FirstOrDefault(),
                    isactive = a.isactive,
                    diagnosisid = a.diagnosisid,
                    Id = a.Id,
                    ProviderID = a.ProviderID
                })
                .ToListAsync();

            return result;

        }
    
        public async Task AddConsultationDiagnosisFavourites(ConsultationDiagnosisFavourites model)
        {
            var check = await _context.ConsultationDiagnosisFavourites.Where(e => e.ICDID == model.ICDID && e.doctorid == model.doctorid && e.ProviderID == model.ProviderID).FirstOrDefaultAsync();

            if (check != null)
            {
                check.lastchangeby = model.lastchangeby;
                check.isactive = model.isactive;
                check.lastchangedate = DateTime.Now;

                _context.Update(check);
                await _context.SaveChangesAsync();
            }
            else
            {
                model.encodeddate = DateTime.Now;
                model.encodeddate = DateTime.Now;
                model.lastchangedate = DateTime.Now;
                var result = _context.ConsultationDiagnosisFavourites.Add(model);
                await _context.SaveChangesAsync();
            }

            

        }
        
        public async Task<List<ConsultationDiagnosisFavouriteDto>> GetConsultationDiagnosisFavourites(int accountId, int doctorId, string searchword)
        {
            if (!string.IsNullOrEmpty(searchword))
            {
                var favourites = await _context.ConsultationDiagnosisFavourites.Where(e => e.ProviderID == accountId && e.doctorid == doctorId)
                    .Select(r => new ConsultationDiagnosisFavouriteDto() {
                        diagnosisName = _context.Diagnosis.Where(d => d.ProviderID == accountId && d.diagnosisid == r.ICDID).Select(m => m.Name).FirstOrDefault(),
                        doctorid = r.doctorid,
                        ICDID = r.ICDID,
                        Id = r.Id,
                        ProviderID = r.ProviderID
                    }).ToListAsync();

                var search = favourites.Where(f => f.diagnosisName.ToUpper().Contains(searchword.ToUpper())).OrderBy(p => p.diagnosisName).ToList();
                return search;

            }
            else
            {
                var favourites = await _context.ConsultationDiagnosisFavourites.Where(e => e.ProviderID == accountId && e.doctorid == doctorId)
                    .Select(r => new ConsultationDiagnosisFavouriteDto()
                    {
                        diagnosisName = _context.Diagnosis.Where(d => d.ProviderID == accountId && d.diagnosisid == r.ICDID).Select(m => m.Name).FirstOrDefault(),
                        doctorid = r.doctorid,
                        ICDID = r.ICDID,
                        Id = r.Id,
                        ProviderID = r.ProviderID
                    }).ToListAsync();

                return favourites;
            }

            

            
        }
        
        public async Task AddConsultationDiagnosis(ConsultationDiagnosis model)
        {
            model.dateadded = DateTime.Now;
            model.Onsetdate = model.Onsetdate.Value.AddHours(1);
            model.Onsetdate = new DateTime(model.Onsetdate.Value.Year, model.Onsetdate.Value.Month, model.Onsetdate.Value.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            await _context.ConsultationDiagnosis.AddAsync(model);
            await _context.SaveChangesAsync();

        }
        
        public async Task DeleteConsultationDiagnosis(int accountId, int consultationDiagnosisId)
        {
            
            var result = await _context.ConsultationDiagnosis.Where(c => c.Id == consultationDiagnosisId && c.ProviderID == accountId).FirstOrDefaultAsync();
            if (result != null)
            {
                _context.ConsultationDiagnosis.Remove(result);
                await _context.SaveChangesAsync();
            }
            

        }
        
        public async Task<ConsultationDiagnosisDto> GetPatientDiagnosisByEncounterId(int accountId, string patientId, int encounterId)
        {
            
            var result = await _context.ConsultationDiagnosis.Where(c => c.Patientid == patientId && c.ProviderID == accountId && c.encounterId == encounterId)
                .Select(a => new ConsultationDiagnosisDto()
                {
                    diagnosiscode = a.diagnosiscode,
                    conditionid1 = a.conditionid1,
                    conditionid2 = a.conditionid2,
                    conditionid3 = a.conditionid3,
                    dateadded = a.dateadded,
                    diagnosisdesc = _context.Diagnosis.Where(d => d.diagnosisid == a.diagnosisid && d.ICDCode == a.diagnosiscode).Select(r => r.Name).FirstOrDefault(),
                    Patientid = a.Patientid,
                    primarydiagnosis = a.primarydiagnosis,
                    ischronic = a.ischronic,
                    isprovisional = a.isprovisional,
                    isresolved = a.isresolved,
                    doctorid = a.doctorid,
                    diagnosisname = _context.Diagnosis.Where(d => d.diagnosisid == a.diagnosisid && d.ICDCode == a.diagnosiscode).Select(r => r.Name).FirstOrDefault(),
                    isactive = a.isactive,
                    diagnosisid = a.diagnosisid,
                    Id = a.Id,
                    ProviderID = a.ProviderID
                })
                .OrderBy(r => r.dateadded)
                .FirstOrDefaultAsync();

            return result;
        }

    }
}
