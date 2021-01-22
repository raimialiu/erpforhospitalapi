using medicloud.emr.api.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Services
{
    public interface IBillingRepository
    {
        Task<(bool, string, decimal?)> getPatientTarrifByPayor(int accountId, string patientId, int servicecode);
    }

    public class BillingRepository : IBillingRepository
    {
        private readonly DataContext _context;
        public BillingRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<(bool, string, decimal?)> getPatientTarrifByPayor (int accountId, string patientId, int servicecode)
        {
            var patientPlantype = await _context.Patient.Where(p => p.Patientid == patientId && p.ProviderId == accountId).Select(r => r.Plantype).FirstOrDefaultAsync();

            if (string.IsNullOrEmpty(patientPlantype))
            {
                return (false, "plan type not available for this patient", null);
            }

            var tariffplan = await _context.TarriffPlan.Where(t => t.planid == int.Parse(patientPlantype)).FirstOrDefaultAsync();

            if (tariffplan == null)
            {
                return (false, "tariff plan not found for patient plan type", null);
            }

            var tariffServiceCode = await _context.TariffServiceCode.Where(ts => ts.serviceid == servicecode && ts.tariffid == tariffplan.tariffid).FirstOrDefaultAsync();

            if (tariffServiceCode == null)
            {
                return (false, "tariff not found for this patient plan type and service requested", null);
            }

            return (true, "Success", tariffServiceCode.tariffamount);

        }
    }
}
