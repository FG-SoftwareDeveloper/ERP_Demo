using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Demo;

public class Employee
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-increment for PK
    public int EmployeeID { get; set; }

    [Required]
    public string FirstName { get; set; } = null!;

    [Required]
    public string LastName { get; set; } = null!;

    public DateOnly? DateOfHire { get; set; }

    public string? JobTitle { get; set; }

    public string? ContactInfo { get; set; }

    [ForeignKey("Department")]
    public int? DepartmentID { get; set; }

    [ForeignKey("Company")]
    public int CompanyID { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Department? Department { get; set; }

    public virtual ICollection<EmployeePayDetail> EmployeePayDetails { get; set; } = new List<EmployeePayDetail>();
    public virtual ICollection<EquipmentUsage> EquipmentUsages { get; set; } = new List<EquipmentUsage>();
    public virtual ICollection<MaintenanceRecord> MaintenanceRecords { get; set; } = new List<MaintenanceRecord>();
    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
    public virtual ICollection<RFI> RFIs { get; set; } = new List<RFI>();
    public virtual ICollection<ServiceOrder> ServiceOrders { get; set; } = new List<ServiceOrder>();
    public virtual ICollection<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();
    public virtual ICollection<Transmittal> Transmittals { get; set; } = new List<Transmittal>();
    public virtual ICollection<SystemUser> Users { get; set; } = new List<SystemUser>();
}
