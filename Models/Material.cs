namespace ERP_Demo;

public class Material
{
    public int MaterialID { get; set; }

    public string MaterialName { get; set; } = null!;

    public string? UnitOfMeasure { get; set; }

    public decimal? CurrentStock { get; set; }

    public decimal? ReorderLevel { get; set; }

    public int CompanyID { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<MaterialUsage> MaterialUsages { get; set; } = new List<MaterialUsage>();

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();
}
