using System.ComponentModel.DataAnnotations;

namespace ERP_Demo;

public class ServiceAgreement
{
    [Key]
    public int AgreementID { get; set; }

    public int CustomerID { get; set; }

    public string? AgreementType { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Terms { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<ServiceOrder> ServiceOrders { get; set; } = new List<ServiceOrder>();
}
