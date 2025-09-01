using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Demo;

public class BankAccount
{
    [Key]
    public int BankID { get; set; }

    public string AccountName { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public string? BankName { get; set; }

    [ForeignKey("Company")]
    public int CompanyID { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Receipt> Receipts { get; set; } = new List<Receipt>();

}
