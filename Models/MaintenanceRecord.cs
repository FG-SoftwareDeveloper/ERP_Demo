using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Demo
{
    public class MaintenanceRecord
    {
        [Key]
        public int MaintenanceID { get; set; } // PK

        [ForeignKey("Equipment")]
        public int EquipmentID { get; set; } // FK to Equipment

        public DateOnly MaintenanceDate { get; set; }

        public string? Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Cost { get; set; }

        [ForeignKey("PerformedByEmployee")]
        public int? PerformedBy { get; set; } // FK to Employee, optional

        public string? MaintenanceType { get; set; } // e.g., Preventative, Repair

        public virtual Equipment Equipment { get; set; } = null!;

        public virtual Employee? PerformedByEmployee { get; set; } // Optional
    }
}