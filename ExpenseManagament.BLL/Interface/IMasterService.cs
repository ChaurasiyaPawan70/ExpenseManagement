using ExpenseManagament.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagament.BLL.Interface
{
    public interface IMasterService
    {
        IEnumerable<PurposeMaster> GetPurpose();
    }
}
