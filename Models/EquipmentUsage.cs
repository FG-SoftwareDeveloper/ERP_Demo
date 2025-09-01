using System.ComponentModel.DataAnnotations;

namespace ERP_Demo
{
    public class EquipmentUsage
    {
        [Key]
        public int UsageID { get; set; }

        public int EquipmentID { get; set; }

        public int? ProjectID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal? UsageHours { get; set; }

        public string? UsageUnits { get; set; }

        public int? OperatorID { get; set; }

        public virtual Equipment Equipment { get; set; } = null!;

        public virtual Employee? Operator { get; set; }

        public virtual Project? Project { get; set; }
    }
}