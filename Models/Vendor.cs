using ERP_Demo.Models;
using System.ComponentModel.DataAnnotations;

namespace ERP_Demo;

public class Vendor
{
    [Key]
    public int VendorID { get; set; }

    public string VendorName { get; set; } = null!;

    public string? ContactPerson { get; set; }

    public string? Address { get; set; }

    public string? PaymentTerms { get; set; }

    public int CompanyID { get; set; }

    public virtual ICollection<APInvoice> APInvoices { get; set; } = new List<APInvoice>();

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();
}
