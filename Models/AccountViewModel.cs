using System.ComponentModel.DataAnnotations;

namespace ERP_Demo.Models
{
    public class AccountViewModel
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

        public bool Active { get; set; } = true;
    }
}
