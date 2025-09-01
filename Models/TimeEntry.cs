using System.ComponentModel.DataAnnotations;

namespace ERP_Demo;

public class TimeEntry
{
    [Key]
    public int TimeEntryID { get; set; }

    public int EmployeeID { get; set; }

    public int? ProjectID { get; set; }

    public DateOnly EntryDate { get; set; }

    public decimal HoursWorked { get; set; }

    public string? ActivityDescription { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual Project? Project { get; set; }
}
