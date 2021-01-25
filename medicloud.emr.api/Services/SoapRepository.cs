using medicloud.emr.api.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Services
{
   public interface ISoapRepository
  {
    Task<List<DiagnosisSoap>> getDiagnosisSoap(string patientid, int ecounterid);
    Task AddDiagnosisSoap(DiagnosisSoap model);
    Task RemoveFromDiagnosisSoap(string patientId, int encounterId);
    Task UpdateDiagnosisSoap(string patientId, int encounterId, string subjective, string objective, string assessment, string plans);
  }

  public class SoapRepository : ISoapRepository
  {
    private readonly DataContext _context;
    public SoapRepository(DataContext context)
    {
      _context = context;
    }

    public async Task AddDiagnosisSoap(DiagnosisSoap model)
    {
      model.Dateadded = DateTime.Now;
      var result = _context.DiagnosisSoap.Add(model);
      await _context.SaveChangesAsync();
    }

    public async Task<List<DiagnosisSoap>> getDiagnosisSoap(string patientid, int ecounterid)
    {
      var result = await _context.DiagnosisSoap.Where(c => c.Patientid == patientid && c.Encounterid == ecounterid)
                 .ToListAsync();

      return result;
    }

    public async Task RemoveFromDiagnosisSoap(string patientId, int encounterId)
    {
      var result = await _context.DiagnosisSoap.Where(c => c.Patientid == patientId && c.Encounterid == encounterId).FirstOrDefaultAsync();
      if (result != null)
      {
        _context.Remove(result);
        await _context.SaveChangesAsync();
      }

    }

    public async Task UpdateDiagnosisSoap(string patientId, int encounterId, string subjective, string objective, string assessment, string plans) 
    {
      var diagnosisSoap = await _context.DiagnosisSoap.Where(q => q.Patientid == patientId && q.Encounterid == encounterId ).FirstOrDefaultAsync();
      if (diagnosisSoap != null)
        diagnosisSoap.Subjective = subjective;
        diagnosisSoap.Objective = objective;
        diagnosisSoap.Assessment =assessment;
        diagnosisSoap.Plans = plans;
        diagnosisSoap.Dateadded = DateTime.Now;

        _context.Update(diagnosisSoap);
        await _context.SaveChangesAsync();
      }
    }
}
