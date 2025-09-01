using System.ComponentModel.DataAnnotations;

namespace ERP_Demo;

public class SystemUser
{
    [Key]
    public int Id { get; set; }


    public string Username { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? Role { get; set; }

    public int? EmployeeID { get; set; }

    public virtual Employee? Employee { get; set; }
}
