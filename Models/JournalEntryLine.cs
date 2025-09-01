using ERP_Demo.Models;

namespace ERP_Demo;

public class JournalEntryLine
{
    public int JournalEntryLineID { get; set; }

    public int JournalEntryID { get; set; }

    public int AccountID { get; set; }

    public decimal? DebitAmount { get; set; }

    public decimal? CreditAmount { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual JournalEntry JournalEntry { get; set; } = null!;
}
