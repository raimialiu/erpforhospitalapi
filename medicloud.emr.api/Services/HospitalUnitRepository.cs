using medicloud.emr.api.Data;
using medicloud.emr.api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Services
{
    public interface IHospitalUnitRepository
    {
        Task<List<HospitalUnit>> getHospitalUnitList(int locationId, int accountId);
    }

    public class HospitalUnitRepository : IHospitalUnitRepository
    {
        private readonly DataContext _context;
        public HospitalUnitRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<HospitalUnit>> getHospitalUnitList(int locationId, int accountId)
        {
            var units = await _context.HospitalUnit.OrderBy(p => p.HospitalUnitName).ToListAsync();
            return units;
        }
    }
}
