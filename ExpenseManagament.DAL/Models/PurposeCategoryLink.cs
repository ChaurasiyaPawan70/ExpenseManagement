using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagament.DAL.Models
{
    public class PurposeCategoryLink 
    {
        [Key]
        public int RecId { get; set; }
        public int PurposeId { get; set; }
        public int CategoryId { get; set; }
        public int Active { get; set; }
    }
}
