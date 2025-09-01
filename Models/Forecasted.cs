using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Demo;

public class Forecasted
{
    [Key]
    public int ForecastID { get; set; }


    public DateOnly ForecastDate { get; set; }

    public DateOnly TargetDate { get; set; }

    public int CompanyID { get; set; }

    public int? ProjectID { get; set; }

    public string ForecastType { get; set; } = null!;

    public decimal? ForecastedValue { get; set; }

    public decimal? ConfidenceIntervalLow { get; set; }

    public decimal? ConfidenceIntervalHigh { get; set; }

    public string? ModelUsed { get; set; }

    [ForeignKey("CompanyID")]
    public virtual Company Company { get; set; } = null!;

    [ForeignKey("ProjectID")]
    public virtual Project? Project { get; set; }
}
