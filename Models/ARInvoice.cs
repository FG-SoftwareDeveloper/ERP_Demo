using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Demo;

public class ARInvoice
{
    [Key]
    public int ARInvoiceID { get; set; }

    [ForeignKey("Customer")]
    public int CustomerID { get; set; }

    [ForeignKey("Project")]
    public int? ProjectID { get; set; }

    public DateTime InvoiceDate { get; set; }

    public DateTime? DueDate { get; set; }

    public decimal Amount { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Project? Project { get; set; }

    public virtual ICollection<Receipt> Receipts { get; set; } = new List<Receipt>();
}
