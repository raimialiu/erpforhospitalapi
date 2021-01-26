//using medicloud.emr.api.Data;
//using medicloud.emr.api.Entities;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace medicloud.emr.api.Services
//{
//  public interface IMRPRepository
//  {
//    //Task MRP getMRP(int price);
//  }

//  public class MRPRepository : IMRPRepository
//  {
//    private readonly DataContext _context;
//    //public MRPRepository(DataContext context)
//    //{
//    //  _context = context;
//    //}

//    public async Task MRP getMRP(int price)
//    {
//      if (price <= 20000)
//      {
//        price = price * 2;
//        return price;
//      }
//      else if (price > 20000 && price <= 400000)
//      {
//        price = (int)(price * 1.5);
//        return price;
//      }
//      else if (price > 400000)
//      {
//        price = (int)(price * 1.3);
//        return price;
//      }

//    }
//  }

//}
