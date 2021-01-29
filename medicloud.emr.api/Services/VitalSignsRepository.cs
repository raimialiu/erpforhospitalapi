using medicloud.emr.api.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Services
{
  public interface IVitalSignsRepository
  {
    Task<List<ConsultationVitals>> getConsultationVitals(string patientid, int ecounterid);
    Task<List<ConsultationVitals>> getConsultationVitalsHistory(string patientid);
    Task AddConsultationVitals(ConsultationVitals model);
    Task RemoveFromConsultationVitals(string patientId, int encounterId, int Id);
    Task UpdateVitalSigns(ConsultationVitals model);

  }

  public class VitalSignsRepository : IVitalSignsRepository
  {
    private readonly DataContext _context;
    public VitalSignsRepository(DataContext context)
    {
      _context = context;
    }

    public async Task AddConsultationVitals(ConsultationVitals model)
    {
      model.Vitalentrydate = DateTime.Now;
      model.Encodeddate = DateTime.Now;
      var result = _context.ConsultationVitals.Add(model);
      await _context.SaveChangesAsync();
    }

    public async Task<List<ConsultationVitals>> getConsultationVitals(string patientid, int encounterid)
    {
      var result = await _context.ConsultationVitals.Where(c => c.Patientid == patientid && c.EncounterId == encounterid)
                  .ToListAsync();

      return result;
    }

    public async Task<List<ConsultationVitals>> getConsultationVitalsHistory(string patientid)
    {
      var result = await _context.ConsultationVitals.Where(c => c.Patientid == patientid)
                  .OrderByDescending(s => s.Encodeddate)
                  .ToListAsync();

      return result;
    }

    public async Task RemoveFromConsultationVitals(string patientId, int encounterId,int Id)
    {
      var result = await _context.ConsultationVitals.Where(c => c.Patientid == patientId && c.EncounterId == encounterId && c.Id == Id).FirstOrDefaultAsync();
      if (result != null)
      {
        _context.Remove(result);
        await _context.SaveChangesAsync();
      }
    }

    public async Task UpdateVitalSigns(ConsultationVitals model)
    {
      var vitalSigns = await _context.ConsultationVitals.Where(q => q.Patientid == model.Patientid && q.EncounterId == model.EncounterId && q.Id == model.Id).FirstOrDefaultAsync();

      vitalSigns.Abnormal = model.Abnormal ;
      vitalSigns.Anyfall = model.Anyfall;
      vitalSigns.Bmi = model.Bmi;
      vitalSigns.Bpsystolic = model.Bpdiastolic;
      vitalSigns.Bpsystolic = model.Bpsystolic;
      vitalSigns.Bsa = model.Bsa;
      vitalSigns.Convertedunitid= model.Convertedunitid ;
      vitalSigns.Convertedvalue = model.Convertedvalue;
      vitalSigns.dizziness = model.dizziness;
      vitalSigns.Encodedby = model.Encodedby;
      vitalSigns.Encodeddate = model.Encodeddate = DateTime.Now;
      vitalSigns.Enteredunitid1 = model.Enteredunitid1;
      vitalSigns.Enteredvalue1 = model.Enteredvalue1;
      vitalSigns.FastingBloodSugar = model.FastingBloodSugar;
      vitalSigns.fetalheartrate = model.fetalheartrate;
      vitalSigns.HeadCircumference = model.HeadCircumference;
      vitalSigns.Height = model.Height;
      vitalSigns.Isactive = model.Isactive;
      vitalSigns.meanarterialpressure = model.meanarterialpressure;
      vitalSigns.MidArmCircumference = model.MidArmCircumference;
      vitalSigns.needhelpstanding = model.needhelpstanding;
      vitalSigns.PainScore = model.PainScore;
      vitalSigns.Pulse = model.Pulse;
      vitalSigns.RandomBloodSugar = model.RandomBloodSugar;
      vitalSigns.Remarks = model.Remarks;
      vitalSigns.Respiration = model.Respiration;
      vitalSigns.Spo2 = model.Spo2;
      vitalSigns.Temperature = model.Temperature;
      vitalSigns.Templatefieldid = model.Templatefieldid;
      vitalSigns.UrinalysisBil = model.UrinalysisBil;
      vitalSigns.UrinalysisEry = model.UrinalysisEry;
      vitalSigns.UrinalysisGlu = model.UrinalysisGlu;
      vitalSigns.UrinalysisHb = model.UrinalysisHb;
      vitalSigns.UrinalysisKet = model.UrinalysisKet;
      vitalSigns.UrinalysisLeu = model.UrinalysisLeu;
      vitalSigns.UrinalysisNit = model.UrinalysisNit;
      vitalSigns.UrinalysisPh = model.UrinalysisPh;
      vitalSigns.UrinalysisPro = model.UrinalysisPro;
      vitalSigns.UrinalysisSg = model.UrinalysisSg;
      vitalSigns.UrinalysisUbg = model.UrinalysisUbg;
      vitalSigns.Valueid = model.Valueid;
      vitalSigns.Vitalentrydate = model.Vitalentrydate;
      vitalSigns.Weight = model.Weight;

      _context.Update(vitalSigns);
      await _context.SaveChangesAsync();
    }
  }
}
