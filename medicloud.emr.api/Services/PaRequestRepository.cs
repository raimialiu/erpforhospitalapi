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
        Task<List<PaRequestViewModel>> GetPaRequestHistory(string enrolleeNumber);
        Task UpdatePaRequest(List<PaRequest> paRequest);
        Task<PaRequest> GetPaRequestHistory(string enrolleeNumber, DateTime requestDate, string diagnosiscode,
            string diagnosisDesc, string procedureCode, string proceduredesc);
        Task<(int, int, bool)> GetOutStandingPaRequestTodayCount(int locationId, int accountId);
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
        
        public async Task<List<PaRequestViewModel>> GetPaRequestHistory(string enrolleeNumber)
        {
            enrolleeNumber = enrolleeNumber.Replace(" ", string.Empty);
            var requests = await _context.PaRequest.Where(d => d.EnrolleeNumber == enrolleeNumber && d.RequestDate >= DateTime.Now.AddYears(-1)).Include(p => p.Patient)
                .Select(r => new PaRequestViewModel
                {
                    accountid = r.AccountId,
                    diagnosiscode = r.DiagnosisCode,
                    diagnosisdesc = r.DiagnosisDesc,
                    issuercomment = r.IssuerComment,
                    locationid = r.LocationId,
                    panumber = r.PaNumber,
                    parequestid = r.PARequestId,
                    pastatus = r.PaStatus,
                    patientid = r.PatientId,
                    patientname = r.Patient.Firstname + " " + r.Patient.Lastname,
                    procedurecode = r.ProcedureCode,
                    proceduredesc = r.ProcedureDesc,
                    quantity = r.Quantity,
                    requestdate = r.RequestDate,
                    unitcharge = r.UnitCharge,
                    enrolleenumber = r.EnrolleeNumber

                }).OrderByDescending(rq => rq.parequestid).ToListAsync();
            return requests;
        }
        
        public async Task<PaRequest> GetPaRequestHistory (string enrolleeNumber, DateTime requestDate, string diagnosiscode, 
            string diagnosisDesc, string procedureCode, string proceduredesc)
        {
            var requests = await _context.PaRequest.Where(d => d.EnrolleeNumber == enrolleeNumber && d.RequestDate.Value.Date == requestDate.Date &&
            d.DiagnosisCode.ToUpper() == diagnosiscode.ToUpper() && d.DiagnosisDesc.ToUpper() == diagnosisDesc.ToUpper() && 
            d.ProcedureCode.ToUpper() == procedureCode.ToUpper() && d.ProcedureDesc.ToUpper() == proceduredesc.ToUpper()).FirstOrDefaultAsync();
            
            return requests;
        }
        
        public async Task UpdatePaRequest (List<PaRequest> paRequest)
        {
            _context.UpdateRange(paRequest);
            await _context.SaveChangesAsync();
        }

        public async Task CreatePaRequest(PaRequestDTO paRequestDTO)
        {
            await _context.AddRangeAsync(paRequestDTO.PaRequests);
            await _context.SaveChangesAsync();
        }

        public async Task<(int, int, bool)> GetOutStandingPaRequestTodayCount(int locationId, int accountId)
        {
            var outstandingPaRequestToday = await _context.PaRequest.Where(c => c.LocationId == locationId &&
                         c.AccountId == accountId && c.RequestDate.Value.Date == DateTime.Today.Date && c.PaStatus == "PENDING").CountAsync();

            var totalOutstandingPaRequestSixmonthsAgo = await _context.PaRequest.Where(c => c.LocationId == locationId &&
                         c.AccountId == accountId && c.RequestDate.Value.Date >= DateTime.Today.AddMonths(-6).Date && c.PaStatus == "PENDING").CountAsync();

            var increase = outstandingPaRequestToday - totalOutstandingPaRequestSixmonthsAgo;

            decimal percentIncrease = 0;
            decimal div = 0;

            if (increase > 0 && totalOutstandingPaRequestSixmonthsAgo > 0)
            {
                div = (decimal)(increase) / (decimal)totalOutstandingPaRequestSixmonthsAgo;

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
            return (outstandingPaRequestToday, (int)percentIncrease, isIncrease);
        }

    }
}
