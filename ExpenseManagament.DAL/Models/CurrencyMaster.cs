using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagament.DAL.Models
{
    public class CurrencyMaster 
    {
        [Key]
        public int CurrencyId { get; set; }
        public string CurrencyCode { get; set; }
        public int Active { get; set; }
    }
}
