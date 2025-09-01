using ERP_Demo.Models;

namespace ERP_Demo;

public class Payment
{
    public int PaymentID { get; set; }

    public int APInvoiceID { get; set; }

    public int BankID { get; set; }

    public DateOnly PaymentDate { get; set; }

    public decimal Amount { get; set; }

    public string? PaymentMethod { get; set; }

    public virtual APInvoice APInvoice { get; set; } = null!;

    public virtual BankAccount Bank { get; set; } = null!;
}
