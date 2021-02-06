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
  public interface IMRPRepository
  {
    Task <PhrGrndetails> getLatestPrice(int itemid);
  }

  public class MRPRepository : IMRPRepository
  {
    private readonly DataContext _context;
    public MRPRepository(DataContext context)
    {
      _context = context;
    }

        public async Task<PhrGrndetails> getLatestPrice(int itemid)
        {
            var cost = await _context.PhrGrndetails.Where(d => d.ItemId == itemid)
                       .OrderByDescending(s => s.UnitCost).FirstOrDefaultAsync();

            if (cost.UnitCost <= 20000 && cost.UnitCost != null)
            {
                cost.UnitCost = Convert.ToDecimal(cost.UnitCost * 2);
                //return cost.UnitCost;
            }
            else if (cost.UnitCost > 20000 && cost.UnitCost <= 400000 && cost.UnitCost != null)
            {
                cost.UnitCost = (decimal)(cost.UnitCost * Convert.ToDecimal(1.5));
                //return cost.UnitCost;
            }
            else if (cost.UnitCost > 400000 && cost.UnitCost != null)
            {
                cost.UnitCost = (decimal)(cost.UnitCost * Convert.ToDecimal(1.3));
                //  return cost.UnitCost;
            }
            return cost;
        }

    //public async Task MRP getMRP(int price)
    //{
    //  if (price <= 20000)
    //  {
    //    price = price * 2;
    //    return price;
    //  }


    //}
  }

}
