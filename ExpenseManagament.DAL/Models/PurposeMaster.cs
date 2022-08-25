using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagament.DAL.Models
{
    public class PurposeMaster
    {
        [Key]
        [Column("purposeid")]
        public int PurposeId { get; set; }
        [Column("purpose")]
        public string Purpose { get; set; }
        [Column("active")]
        public int Active { get; set; }
    }
}
