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
    private PhrGrndetails cost;

    public MRPRepository(DataContext context)
    {
      _context = context;
    }

    public async Task<PhrGrndetails> getLatestPrice(int itemid)
    {
      
      try
      {
        
        cost = await _context.PhrGrndetails.Where(d => d.ItemId == itemid)
                .OrderByDescending(s => s.UnitCost).FirstOrDefaultAsync();

        if (cost != null)
        {
          if (cost.UnitCost <= 20000 && cost.UnitCost != null)
          {
            cost.UnitCost = Convert.ToDecimal(cost.UnitCost * 2);
          }
          else if (cost.UnitCost > 20000 && cost.UnitCost <= 400000 && cost.UnitCost != null)
          {
            cost.UnitCost = (decimal)(cost.UnitCost * Convert.ToDecimal(1.5));
          }
          else if (cost.UnitCost > 400000 && cost.UnitCost != null)
          {
            cost.UnitCost = (decimal)(cost.UnitCost * Convert.ToDecimal(1.3));
          }
        }
        else if(cost == null)
        {
          PhrGrndetails cost = new PhrGrndetails();
          cost.UnitCost = (decimal)1.00;
          return cost;
        }

      }
      catch (Exception ex)
      {
       
      }

      return cost;
    }
           
  }

}
