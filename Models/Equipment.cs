using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Demo;

public class Equipment
{
    public int EquipmentID { get; set; }

    public string EquipmentName { get; set; } = null!;

    public string? SerialNumber { get; set; }

    public DateOnly? PurchaseDate { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal? PurchaseCost { get; set; }

    public string? CurrentLocation { get; set; }

    public string? Status { get; set; } // e.g., "In Use", "Available"

    [ForeignKey("Company")]
    public int CompanyID { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<EquipmentUsage> EquipmentUsages { get; set; } = new List<EquipmentUsage>();

    public virtual ICollection<MaintenanceRecord> MaintenanceRecords { get; set; } = new List<MaintenanceRecord>();

}
