using System.ComponentModel.DataAnnotations;

namespace ERP_Demo;

public class ProjectFinancialSummary
{
    [Key]
    public int ProjectSummaryID { get; set; }

    public int ProjectID { get; set; }

    public DateOnly SummaryDate { get; set; }

    public decimal? ActualRevenue { get; set; }

    public decimal? ActualExpenses { get; set; }

    public decimal? ActualProfit { get; set; }

    public decimal? BudgetVariance { get; set; }

    public decimal? PercentComplete { get; set; }

    public decimal? LaborCost { get; set; }

    public decimal? MaterialCost { get; set; }

    public decimal? EquipmentCost { get; set; }

    public decimal? SubcontractorCost { get; set; }

    public virtual Project Project { get; set; } = null!;
}
