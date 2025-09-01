namespace ERP_Demo;

public class KPI
{
    public int KPIID { get; set; }

    public string KPIName { get; set; } = null!;

    public DateOnly KPIDate { get; set; }

    public decimal? Value { get; set; }

    public int CompanyID { get; set; }

    public int? ProjectID { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Project? Project { get; set; }
}
