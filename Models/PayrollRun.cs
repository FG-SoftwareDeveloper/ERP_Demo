namespace ERP_Demo;

public class PayrollRun
{
    public int PayrollRunID { get; set; }

    public DateOnly PayPeriodStart { get; set; }

    public DateOnly PayPeriodEnd { get; set; }

    public DateOnly RunDate { get; set; }

    public string? Status { get; set; }

    public int CompanyID { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<EmployeePayDetail> EmployeePayDetails { get; set; } = new List<EmployeePayDetail>();
}
