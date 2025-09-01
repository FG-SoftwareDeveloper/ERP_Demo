using System.ComponentModel.DataAnnotations;

namespace ERP_Demo;

public class RFI
{
    [Key]
    public int RFIID { get; set; }

    public int ProjectID { get; set; }

    public DateOnly RequestDate { get; set; }

    public DateOnly? ResponseDate { get; set; }

    public int RequestedBy { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public virtual Project Project { get; set; } = null!;

    public virtual Employee RequestedByNavigation { get; set; } = null!;
}
