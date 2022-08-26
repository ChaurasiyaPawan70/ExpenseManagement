using ExpenseManagament.BLL.Interface;
using ExpenseManagament.DAL.Data;
using ExpenseManagament.DAL.Enum;
using ExpenseManagament.DAL.Models;
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
        public MasterService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<PurposeMaster> GetPurpose()
        {
            return _dbContext.PurposeMaster.ToList();
        }

        public IEnumerable<CurrencyMaster> GetCurrency() 
        {
            return this._dbContext.CurrencyMaster.ToList(); 
        }


    }
}
