using medicloud.emr.api.Data;
using medicloud.emr.api.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Services
{
    public interface IPayerInsuranceRepository
    {
        Task<PayerDto> GetPatientPayerInfo(string payerId);
    }

    public class PayerInsuranceRepository : IPayerInsuranceRepository
    {
        private readonly DataContext _context;
        public PayerInsuranceRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<PayerDto> GetPatientPayerInfo(string payerId)
        {
            var _payerId = 0;
            try
            {
                _payerId = int.Parse(payerId);
            }
            catch
            {
                PayerDto payerDto = new PayerDto
                {
                    PayerType = null,
                    dateadded = null,
                    AccountCatId = null,
                    AccountCategory = null

                };
                return payerDto;
            }

            var result = await _context.Payer.Where(p => p.PayerId == _payerId)
                .Select(c => new PayerDto()
                {
                    AccountCategory = _context.AccountCategory.Where(ca => ca.Accountcatid == c.accountcatid).FirstOrDefault(),
                    AccountCatId = c.accountcatid,
                    dateadded = c.dateadded,
                    PayerId = c.PayerId,
                    PayerType = c.PayerType
                }).FirstOrDefaultAsync();

            return result;
        }
    }
}
