using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Demo;

public class Document
{
    [Key]
    public int DocumentID { get; set; }

    public string DocumentName { get; set; } = null!;

    public string? DocumentType { get; set; }

    public string? FilePathURL { get; set; }

    public DateTime? UploadDate { get; set; }

    [ForeignKey("Project")]
    public int? ProjectID { get; set; }

    // Polymorphic association fields
    public int? RelatedEntityID { get; set; }

    public string? RelatedEntityType { get; set; }

    public virtual Project? Project { get; set; }

}
