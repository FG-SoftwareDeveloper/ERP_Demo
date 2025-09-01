using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Demo;

public class Department
{
    [Key]
    public int DepartmentID { get; set; }

    public string DepartmentName { get; set; } = null!;

    [ForeignKey("Company")]
    public int CompanyID { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

}
