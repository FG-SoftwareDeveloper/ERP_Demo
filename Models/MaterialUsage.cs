namespace ERP_Demo;

public class MaterialUsage
{
    public int MaterialUsageID { get; set; }

    public int ProjectID { get; set; }

    public int MaterialID { get; set; }

    public decimal QuantityUsed { get; set; }

    public DateOnly UsageDate { get; set; }

    public virtual Material Material { get; set; } = null!;

    public virtual Project Project { get; set; } = null!;
}
