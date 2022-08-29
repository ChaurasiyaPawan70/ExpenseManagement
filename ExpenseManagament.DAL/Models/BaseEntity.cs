using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagament.DAL.Models
{
    public class BaseEntity
    {
       
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int Active { get; set; }
        public int DeactivatedBy { get; set; }
        public DateTime DeactivatedOn { get; set; }
    }
}
