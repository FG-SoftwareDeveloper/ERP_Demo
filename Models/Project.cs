using ERP_Demo.Models;

namespace ERP_Demo;

public class Project
{
    public int ProjectID { get; set; }

    public string ProjectName { get; set; } = null!;

    public int? ProjectManagerID { get; set; }

    public int? CustomerID { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Status { get; set; }

    public decimal? BudgetAmount { get; set; }

    public int CompanyID { get; set; }

    public virtual ICollection<APInvoice> APInvoices { get; set; } = new List<APInvoice>();

    public virtual ICollection<ARInvoice> ARInvoices { get; set; } = new List<ARInvoice>();

    public virtual Company Company { get; set; } = null!;

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    public virtual ICollection<EquipmentUsage> EquipmentUsages { get; set; } = new List<EquipmentUsage>();

    public virtual ICollection<ForecastedFinancial> ForecastedFinancials { get; set; } = new List<ForecastedFinancial>();

    public virtual ICollection<KPI> KPIs { get; set; } = new List<KPI>();

    public virtual ICollection<MaterialUsage> MaterialUsages { get; set; } = new List<MaterialUsage>();

    public virtual ICollection<ProjectFinancialSummary> ProjectFinancialSummaries { get; set; } = new List<ProjectFinancialSummary>();

    public virtual Employee? ProjectManager { get; set; }

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<RFI> RFIs { get; set; } = new List<RFI>();

    public virtual ICollection<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();

    public virtual ICollection<Transmittal> Transmittals { get; set; } = new List<Transmittal>();
}
