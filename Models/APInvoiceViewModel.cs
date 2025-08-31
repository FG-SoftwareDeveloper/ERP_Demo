namespace ERP_Demo.Models
{
    public class APInvoiceViewModel
    {
        public int Id { get; set; }
        public string Vendor { get; set; } = "";
        public string InvoiceNumber { get; set; } = "";
        public DateTime InvoiceDate { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; } = "Open"; // Open, Paid, Overdue, etc.
    }
}
