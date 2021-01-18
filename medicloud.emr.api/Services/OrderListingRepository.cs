using medicloud.emr.api.Data;
using medicloud.emr.api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Services
{
    public interface IOrderListingRepository
    {
        Task AddOrderListing(List<OrderListing> orderListings);
        Task<List<OrderListing>> GetOrderListing(int accountId);
        Task DeleteOrderListingById(int accountId, int orderListingId);
        Task<OrderListing> GetOrderListingById(int accountId, int orderListingId);
    }

    public class OrderListingRepository : IOrderListingRepository
    {
        private readonly DataContext _context;

        public OrderListingRepository(DataContext context)
        {
            _context = context;
        }

        public async Task AddOrderListing(List<OrderListing> orderListings)
        {
            await _context.OrderListing.AddRangeAsync(orderListings);
            await _context.SaveChangesAsync();
        }

        public async Task<List<OrderListing>> GetOrderListing(int accountId)
        {
            var orders = await _context.OrderListing.Where(o => o.ProviderID == accountId).ToListAsync();
            return orders;
        }

        public async Task<OrderListing> GetOrderListingById(int accountId, int orderListingId)
        {
            var orders = await _context.OrderListing.Where(o => o.ProviderID == accountId && o.Orderlistid == orderListingId).FirstOrDefaultAsync();
            return orders;
        }

        public async Task DeleteOrderListingById(int accountId, int orderListingId)
        {
            var orders = await _context.OrderListing.Where(o => o.ProviderID == accountId && o.Orderlistid == orderListingId).FirstOrDefaultAsync();

            _context.OrderListing.Remove(orders);
            await _context.SaveChangesAsync();
        }
    }
}
