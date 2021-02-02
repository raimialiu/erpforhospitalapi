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
        Task<List<PatientPayorTypesDto>> GetPatientPayerList(string payerId, string patientid);
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

        public async Task<List<PatientPayorTypesDto>> GetPatientPayerList(string payerId, string patientid)
        {
            var _payerId = 0;
            try
            {
                _payerId = !string.IsNullOrEmpty(payerId) ? int.Parse(payerId) : 0;
            }
            catch
            {
                //PayerDto payerDto = new PayerDto
                //{
                //    PayerType = null,
                //    dateadded = null,
                //    AccountCatId = null,
                //    AccountCategory = null

                //};
                return null;
            }

            var patientPayorTypeslist = await _context.PatientPayorTypes.Where(p => p.Patientid == patientid).ToListAsync();

            var patientPayorTypes = await _context.PatientPayorTypes.Where(p => p.Patientid == patientid)
                .Select(c => new PatientPayorTypesDto()
                {
                    sponsor = c.sponsor,
                    accountid = c.accountid,
                    plantype = c.plantype,
                    Id = c.Id,
                    accountcategory = c.accountcategory,
                    Patientid = c.Patientid,
                    Payerid = int.Parse(c.Payor),
                    //PayerType = _context.Payer.Where(p => p.PayerId == int.Parse(c.Payor)).Select(p => p.PayerType).FirstOrDefault()
                }).ToListAsync();


            if (patientPayorTypes.Any(p => p.Payor != payerId ))
            {
                var result = await _context.Payer.Where(p => p.PayerId == _payerId)
                .Select(c => new PatientPayorTypesDto()
                {
                    sponsor = null,
                    accountid = null,
                    //plantype = c.plantype,
                    Payor = c.PayerId.ToString(),
                    Payerid = c.PayerId,
                    accountcategory = c.accountcatid.ToString(),
                    //Patientid = c.Patientid,
                    PayerType = _context.Payer.Where(p => p.PayerId == c.PayerId).Select(p => p.PayerType).FirstOrDefault()
                }).FirstOrDefaultAsync();

                if (result != null) patientPayorTypes.Add(result);

            }
            
            if (patientPayorTypes.Count() == 0 || patientPayorTypes.Any(p => p.Payor != 1162.ToString()))
            {
                var result = await _context.Payer.Where(p => p.PayerId == 1162)
                .Select(c => new PatientPayorTypesDto()
                {
                    sponsor = null,
                    accountid = null,
                    //plantype = c.plantype,
                    Payor = c.PayerId.ToString(),
                    Payerid = c.PayerId,
                    accountcategory = c.accountcatid.ToString(),
                    //Patientid = c.Patientid,
                    PayerType = _context.Payer.Where(p => p.PayerId == c.PayerId).Select(p => p.PayerType).FirstOrDefault()
                }).FirstOrDefaultAsync();

                if (result != null) patientPayorTypes.Add(result);

            }

            foreach (var item in patientPayorTypes)
            {
                item.PayerType = string.IsNullOrEmpty(item.PayerType) ? _context.Payer.Where(p => p.PayerId == item.Payerid).Select(p => p.PayerType).FirstOrDefault() : item.PayerType;
            };

            return patientPayorTypes;
        }
    }
}

