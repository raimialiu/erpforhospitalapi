using medicloud.emr.api.Data;
using medicloud.emr.api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.Services
{
    public interface ISetupRepository
    {
        Task<List<OrderCategory>> GetOrderCategoryList(int accountId);
        Task<List<OrderType>> GetOrderTypeList(int accountId);
        Task<List<OrderCategory>> GetOrderCategoryByOrdeTypeIdList(int accountId, int orderTypeId);
        Task<OrderType> GetOrderTypeById(int accountId, int orderTypeId);
        Task<OrderCategory> GetOrderCategoryById(int accountId, int orderCategoryId);
        Task DelelteOrderCategory(int accountId, int orderCatId);
        Task DelelteOrderTypeById(int accountId, int orderTypeId);
        Task<List<Diagnosis>> GetDiagnosisList(int accountId, string searchWord);
        Task<List<Diagnosissubgroup>> GetDiagnosisSupGroupListByGroupId(int groupId, string searchWord);
        Task<List<Diagnosisgroup>> GetDiagnosisGroupList(string searchWord);
        Task<List<DiagnosisType>> GetDiagnosisTypeList(int accountId);
        Task<List<DiagnosisProblems>> GetDiagnosisProblemList(int accountId);
        Task<Diagnosis> GetDiagnosisByCode(int accountId, string icdCode);
    }

    public class SetupRepository : ISetupRepository
    {
        private readonly DataContext _context;

        public SetupRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<OrderType>> GetOrderTypeList(int accountId)
        {
            var ordertypes = await _context.OrderType.Where(o => o.ProviderID == accountId).OrderBy(p => p.Ordername).ToListAsync();
            return ordertypes;
        }
        
        public async Task<List<DiagnosisType>> GetDiagnosisTypeList(int accountId)
        {
            var diagtypes = await _context.DiagnosisType.Where(o => o.ProviderId == accountId).OrderBy(p => p.description).ToListAsync();
            return diagtypes;
        }
        
        public async Task<List<DiagnosisProblems>> GetDiagnosisProblemList(int accountId)
        {
            var diagtypes = await _context.DiagnosisProblems.Where(o => o.ProviderID == accountId).ToListAsync();
            return diagtypes;
        }

        public async Task<List<OrderCategory>> GetOrderCategoryList(int accountId)
        {
            var orderCategories = await _context.OrderCategory.Where(o => o.ProviderID == accountId).OrderBy(p => p.Ordercategory1).ToListAsync();
            return orderCategories;
        }

        public async Task<List<OrderCategory>> GetOrderCategoryByOrdeTypeIdList(int accountId, int orderTypeId)
        {
            var orderCategories = await _context.OrderCategory.Where(o => o.ProviderID == accountId && o.Ordertypeid == orderTypeId).OrderBy(p => p.Ordercategory1).ToListAsync();
            return orderCategories;
        }

        public async Task<OrderCategory> GetOrderCategoryById(int accountId, int orderCategoryId)
        {
            var orderCategory = await _context.OrderCategory.Where(o => o.ProviderID == accountId && o.Ordercategoryid == orderCategoryId).FirstOrDefaultAsync();
            return orderCategory;
        }
        
        public async Task<OrderType> GetOrderTypeById(int accountId, int orderTypeId)
        {
            var orderType = await _context.OrderType.Where(o => o.ProviderID == accountId && o.Ordertypeid == orderTypeId).FirstOrDefaultAsync();
            return orderType;
        }
        
        public async Task DelelteOrderTypeById(int accountId, int orderTypeId)
        {
            var ordertype = await _context.OrderType.Where(o => o.ProviderID == accountId && o.Ordertypeid == orderTypeId).FirstOrDefaultAsync();

            _context.OrderType.Remove(ordertype);
            await _context.SaveChangesAsync();
        }
        
        public async Task DelelteOrderCategory(int accountId, int orderCatId)
        {
            var ordertype = await _context.OrderCategory.Where(o => o.ProviderID == accountId && o.Ordertypeid == orderCatId).FirstOrDefaultAsync();

            _context.OrderCategory.Remove(ordertype);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Diagnosis>> GetDiagnosisList(int accountId, string searchWord)
        {
            if (!string.IsNullOrEmpty(searchWord))
            {
                var diagnosis = await _context.Diagnosis.Where(a => a.ProviderID == accountId).ToListAsync();

                var _diagnosisSearch = diagnosis.Where(a => a.Name.ToUpper().Contains(searchWord.ToUpper() ))
                .OrderBy(p => p.Name).ToList();

                return _diagnosisSearch;
            }

            var _diagnosis = await _context.Diagnosis.Where(a => a.ProviderID == accountId).Take(15).OrderBy(p => p.Name).ToListAsync();

            return _diagnosis;
        }
        
        public async Task<Diagnosis> GetDiagnosisByCode(int accountId, string icdCode)
        {
            var _diagnosis = await _context.Diagnosis.Where(a => a.ProviderID == accountId && a.Code == icdCode).FirstOrDefaultAsync();

            return _diagnosis;
        }
        
        public async Task<List<Diagnosisgroup>> GetDiagnosisGroupList(string searchWord)
        {
            if (!string.IsNullOrEmpty(searchWord))
            {
                var diagnosisGroup = await _context.Diagnosisgroup.ToListAsync();

                var _diagnosisGroupSearch = diagnosisGroup.Where(a => a.groupname.ToUpper().Contains(searchWord.ToUpper() ))
                .OrderBy(p => p.groupname).ToList();

                return _diagnosisGroupSearch;
            }

            var _diagnosisGroup = await _context.Diagnosisgroup.Take(15).OrderBy(p => p.groupname).ToListAsync();

            return _diagnosisGroup;
        }
        
        public async Task<List<Diagnosissubgroup>> GetDiagnosisSupGroupListByGroupId(int groupId, string searchWord)
        {
            if (!string.IsNullOrEmpty(searchWord))
            {
                var diagnosisSubGroup = await _context.Diagnosissubgroup.Where(g => g.groupid == groupId).ToListAsync();

                var _diagnosisSubGroupSearch = diagnosisSubGroup.Where(a => a.subgroupname.ToUpper().Contains(searchWord.ToUpper() ))
                .OrderBy(p => p.subgroupname).ToList();

                return _diagnosisSubGroupSearch;
            }

            var _diagnosisSubGroup = await _context.Diagnosissubgroup.Where(g => g.groupid == groupId).Take(15).OrderBy(p => p.subgroupname).ToListAsync();

            return _diagnosisSubGroup;
        }


    }
}
