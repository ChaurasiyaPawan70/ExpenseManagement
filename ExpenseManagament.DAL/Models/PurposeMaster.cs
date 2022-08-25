using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagament.DAL.Models
{
    public class PurposeMaster
    {
        [Key]
        public int purposeid { get; set; }
        public string purpose { get; set; }
       

    }
}
