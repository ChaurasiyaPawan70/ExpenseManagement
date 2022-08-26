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
        [Column("Currencyid")]
        public int currencyid { get; set; }
        [Column("currencycode")]
        public string Currencycode { get; set; }
    }
}
