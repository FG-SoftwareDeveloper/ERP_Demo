using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Demo.Models
{
    public class APInvoice
    {
    [Key]
    public int APInvoiceID { get; set; }

    public int VendorID { get; set; }

    [ForeignKey("Customer")]
    public int CustomerID { get; set; }

    [ForeignKey("Project")]
    public int? ProjectID { get; set; }

    public DateTime InvoiceDate { get; set; }

    public DateTime DueDate { get; set; }

    public decimal Amount { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual Project? Project { get; set; }

    public virtual Vendor Vendor { get; set; } = null!;
    }
}
