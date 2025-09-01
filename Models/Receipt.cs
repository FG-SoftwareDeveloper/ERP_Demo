using System.ComponentModel.DataAnnotations;

namespace ERP_Demo;

public class Receipt
{
    [Key]
    public int ReceiptID { get; set; }

    public int ARInvoiceID { get; set; }

    public int BankID { get; set; }

    public DateOnly ReceiptDate { get; set; }

    public decimal Amount { get; set; }

    public string? PaymentMethod { get; set; }

    public virtual ARInvoice ARInvoice { get; set; } = null!;

    public virtual BankAccount Bank { get; set; } = null!;
}
