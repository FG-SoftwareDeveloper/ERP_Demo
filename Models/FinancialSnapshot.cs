using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Demo;

public class FinancialSnapshot
{
    [Key]
    public int SnapshotID { get; set; }

    public DateOnly SnapshotDate { get; set; }

    public int CompanyID { get; set; }

    public decimal? TotalRevenue { get; set; }

    public decimal? TotalExpenses { get; set; }

    public decimal? NetProfit { get; set; }

    public decimal? CashBalance { get; set; }

    public decimal? AccountsReceivableBalance { get; set; }

    public decimal? AccountsPayableBalance { get; set; }

    public decimal? PayrollCost { get; set; }

    public decimal? EquipmentCost { get; set; }

    public decimal? MaterialCost { get; set; }

    public decimal? OtherFinancialMetric1 { get; set; }

    public decimal? OtherFinancialMetric2 { get; set; }

    [ForeignKey("CompanyID")]
    public virtual Company Company { get; set; } = null!;
}
