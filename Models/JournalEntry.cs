using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Demo;

public class JournalEntry
{
    [Key]
    public int JournalEntryID { get; set; }

    public DateOnly EntryDate { get; set; }

    public string? Description { get; set; }

    [ForeignKey("Company")]
    public int CompanyID { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<JournalEntryLine> JournalEntryLines { get; set; } = new List<JournalEntryLine>();
}
