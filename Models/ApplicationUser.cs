namespace ERP_Demo;

public class ApplicationUser
{
    public int? EmployeeID { get; set; } // FK to your Employees table
    public Employee? Employee { get; set; } // Optional: navigation

    // Optional extras
    public string? DisplayName { get; set; }
    public DateTime? LastLoginDate { get; set; }
    public bool IsActive { get; set; } = true;

}
