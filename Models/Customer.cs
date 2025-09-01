namespace ERP_Demo;

public class Customer
{
    public int CustomerID { get; set; }

    public string CustomerName { get; set; } = null!;

    public string? ContactPerson { get; set; }

    public string? Address { get; set; }

    public string? BillingTerms { get; set; }

    public int CompanyID { get; set; }

    public virtual ICollection<ARInvoice> ARInvoices { get; set; } = new List<ARInvoice>();

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<ServiceAgreement> ServiceAgreements { get; set; } = new List<ServiceAgreement>();

    public virtual ICollection<ServiceOrder> ServiceOrders { get; set; } = new List<ServiceOrder>();
}
