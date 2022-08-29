using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManagament.DAL.Models
{
    public class PurposeMaster 
    {
        [Key]
        public int PurposeId { get; set; }
        public string Purpose { get; set; }
        public int Active { get; set; }
    }
}
