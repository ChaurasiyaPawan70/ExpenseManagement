using ExpenseManagament.BLL.Interface;
using ExpenseManagament.Common.IRepository;
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
        private IRepository<PurposeMaster> _repo;

        public MasterService(IRepository<PurposeMaster> repo)
        {
            _repo = repo;
        }

        public IEnumerable<PurposeMaster> GetPurpose()
        {
           return this._repo.GetAll();
        }
    }
}
