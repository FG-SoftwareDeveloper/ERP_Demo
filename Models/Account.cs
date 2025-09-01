using System.ComponentModel.DataAnnotations;

namespace ERP_Demo.Models
{
    public class Account
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = "";

        [Required]                  // Asset, Liability, Equity, Revenue, Expense, Other
        public string AccountType { get; set; } = "Asset";

        [DataType(DataType.Currency)]
        public decimal CurrentBalance { get; set; }

        [StringLength(100)]
        public string? Company { get; set; }

        public decimal Balance { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int CompanyID { get; set; }

        public virtual ICollection<JournalEntryLine> JournalEntryLines { get; set; } = new List<JournalEntryLine>();

        public virtual ICollection<Budget> Budgets { get; set; } = new List<Budget>();
        public bool Active { get; set; } = true;
    }
}
