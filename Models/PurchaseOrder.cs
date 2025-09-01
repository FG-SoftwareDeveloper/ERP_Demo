using System.ComponentModel.DataAnnotations;

namespace ERP_Demo;

public class PurchaseOrder
{
    [Key]
    public int POID { get; set; }

    public int VendorID { get; set; }

    public DateOnly OrderDate { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string? Status { get; set; }

    public int? ProjectID { get; set; }

    public virtual Project? Project { get; set; }

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual Vendor Vendor { get; set; } = null!;
}
