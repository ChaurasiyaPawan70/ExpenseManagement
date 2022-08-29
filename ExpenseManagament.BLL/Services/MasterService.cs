using AutoMapper;
using ExpenseManagament.BLL.Interface;
using ExpenseManagament.DAL.Data;
using ExpenseManagament.DAL.DTO;
using ExpenseManagament.DAL.Enum;
using ExpenseManagament.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagament.BLL.Services
{

    public class MasterService : IMasterService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        public MasterService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IEnumerable<PurposeMasterDTO> GetPurposes()
        {
            var purposes = _dbContext.PurposeMaster.Where(c => c.Active == (int)Status.Active).ToList();
            return _mapper.Map<IEnumerable<PurposeMasterDTO>>(purposes);
        }

        public IEnumerable<CurrencyMasterDTO> GetCurrencies()
        {
            var currencies = _dbContext.CurrencyMaster.Where(c => c.Active == (int)Status.Active).ToList();
            return _mapper.Map<IEnumerable<CurrencyMasterDTO>>(currencies);
        }

        public IEnumerable<CategoryMasterDTO> GetCategories(int purposeId)
        {
            var categories = (from pm in _dbContext.PurposeMaster
                                                  join pcl in _dbContext.PurposeCategoryLink
                                                  on pm.PurposeId equals pcl.PurposeId
                                                  join cm in _dbContext.CategoryMaster
                                                  on pcl.CategoryId equals cm.CategoryId
                                                  where pm.PurposeId == purposeId && pm.Active == (int)Status.Active
                                                  select new CategoryMasterDTO
                                                  {
                                                      CategoryId = cm.CategoryId,
                                                      CategoryName = cm.CategoryName
                                                  }).ToList();
            return _mapper.Map<IEnumerable<CategoryMasterDTO>>(categories);
        }

    }
}
