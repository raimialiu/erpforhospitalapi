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
    public interface IPaRequestRepository
    {
        Task<Diagnosis> GetDiagnosisByCode(int accountId, string diagnosisCode);
        Task<Procedure> GetProcedureByCode(int accountId, string procedureCode);
        Task CreatePaRequest(PaRequestDTO paRequestDTO);
        Task<List<PaRequestViewModel>> GetPaRequestHistory(int accountId, int locationId);
    }

    public class PaRequestRepository : IPaRequestRepository
    {
        private readonly DataContext _context;
        public PaRequestRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Diagnosis> GetDiagnosisByCode(int accountId, string diagnosisCode)
        {
            var diagnosis = await _context.Diagnosis.Where(d => d.ProviderId == accountId && d.Code == diagnosisCode).FirstOrDefaultAsync();
            return diagnosis;
        }

        public async Task<Procedure> GetProcedureByCode(int accountId, string procedureCode)
        {
            var procedure = await _context.Procedure.Where(d => d.ProviderId == accountId && d.Procedurecode == procedureCode).FirstOrDefaultAsync();
            return procedure;
        }
        
        public async Task<List<PaRequestViewModel>> GetPaRequestHistory(int accountId, int locationId)
        {
            var requests = await _context.PaRequest.Where(d => d.AccountId == accountId && d.LocationId == locationId && d.RequestDate >= DateTime.Today.AddYears(-1)).Include(p => p.Patient).Include(d => d.Diagnosis).Include(pr => pr.Procedure)
                .Select(r => new PaRequestViewModel
                {
                    accountid = r.AccountId,
                    diagnosisid = r.DiagnosisId,
                    diagnosisname = r.Diagnosis.Name,
                    issuercomment = r.IssuerComment,
                    locationid = r.LocationId,
                    panumber = r.PaNumber,
                    parequestid = r.PARequestId,
                    pastatus = r.PaStatus,
                    patientid = r.PatientId,
                    patientname = r.Patient.Firstname + " " + r.Patient.Lastname,
                    procedureid = r.ProcedureId,
                    procedurename = r.Procedure.Procedurename,
                    quantity = r.Quantity,
                    requestdate = r.RequestDate,
                    unitcharge = r.UnitCharge

                }).OrderByDescending(rq => rq.requestdate).ToListAsync();
            return requests;
        }

        public async Task CreatePaRequest(PaRequestDTO paRequestDTO)
        {
            await _context.AddRangeAsync(paRequestDTO.PaRequests);
            await _context.SaveChangesAsync();
        }
    }
}
