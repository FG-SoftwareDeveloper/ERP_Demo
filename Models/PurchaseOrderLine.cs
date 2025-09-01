using System.ComponentModel.DataAnnotations;

namespace ERP_Demo;

public class PurchaseOrderLine
{
    [Key]
    public int POLineID { get; set; }

    public int POID { get; set; }

    public int MaterialID { get; set; }

    public decimal QuantityOrdered { get; set; }

    public decimal UnitPrice { get; set; }

    public virtual Material Material { get; set; } = null!;

    public virtual PurchaseOrder PO { get; set; } = null!;
}
