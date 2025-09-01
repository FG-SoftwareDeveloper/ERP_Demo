using System.ComponentModel.DataAnnotations;

namespace ERP_Demo;

public class ServiceOrder
{
    [Key]
    public int ServiceOrderID { get; set; }

    public int? AgreementID { get; set; }

    public int CustomerID { get; set; }

    public string? ServiceLocation { get; set; }

    public DateOnly RequestDate { get; set; }

    public DateOnly? CompletionDate { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public int? AssignedTechnicianID { get; set; }

    public virtual ServiceAgreement? Agreement { get; set; }

    public virtual Employee? AssignedTechnician { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
