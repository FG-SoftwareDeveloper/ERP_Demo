using System.ComponentModel.DataAnnotations;

namespace ERP_Demo;

public class Transmittal
{
    [Key]
    public int TransmittalID { get; set; }

    public int ProjectID { get; set; }

    public DateOnly TransmittalDate { get; set; }

    public int SentBy { get; set; }

    public string? Recipient { get; set; }

    public string? Description { get; set; }

    public virtual Project Project { get; set; } = null!;

    public virtual Employee SentByNavigation { get; set; } = null!;
}

