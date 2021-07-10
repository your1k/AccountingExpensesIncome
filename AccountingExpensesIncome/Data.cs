using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingExpensesIncome
{
    public class Data
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual Users User { get; set; }
        [Required]
        public virtual Operations Operation { get; set; }
        [Required]
        public virtual Categories Category { get; set; }
        public string Description { get; set; }
        public double TransactionAmount { get; set; }
        public double Balance { get; set; }
    }
}
