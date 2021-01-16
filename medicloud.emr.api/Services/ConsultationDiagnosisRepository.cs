using medicloud.emr.api.Data;
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
        Task<List<ConsultationDiagnosis>> getConsultationDiagnosisByPatientId(int accountId, string patientNo, int locationId);
        Task AddConsultationDiagnosisFavourites(ConsultationDiagnosisFavourites model);
    }

    public class ConsultationDiagnosisRepository : IConsultationDiagnosisRepository
    {
        private readonly DataContext _context;

        public ConsultationDiagnosisRepository(DataContext context)
        {
            _context = context;
        }


        public async Task<List<ConsultationDiagnosis>> getConsultationDiagnosisByPatientId(int accountId, string patientNo, int locationId)
        {
            var result = await _context.ConsultationDiagnosis.Where(c => c.ProviderId == accountId && c.Patientid == patientNo && c.LocationId == locationId)
                //.Select()
                .ToListAsync();

            return result;

        }
    
        public async Task AddConsultationDiagnosisFavourites(ConsultationDiagnosisFavourites model)
        {
            var result = _context.ConsultationDiagnosisFavourites.Add(model);
            await _context.SaveChangesAsync();

        }

    }
}
