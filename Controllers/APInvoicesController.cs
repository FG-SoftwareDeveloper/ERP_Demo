using ERP_Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class APInvoicesController : Controller
    {
        // Hard-coded sample data
        private static readonly List<APInvoiceViewModel> _invoices = new()
        {
            new() { Id = 1, Vendor = "Contoso Supplies", InvoiceNumber = "AP-1001", InvoiceDate = DateTime.Today.AddDays(-10), Amount = 1250.75m, Status = "Open" },
            new() { Id = 2, Vendor = "Northwind Traders",  InvoiceNumber = "AP-1002", InvoiceDate = DateTime.Today.AddDays(-6),  Amount =  480.00m, Status = "Paid" },
            new() { Id = 3, Vendor = "Fabrikam, Inc.",     InvoiceNumber = "AP-1003", InvoiceDate = DateTime.Today.AddDays(-2),  Amount = 2199.99m, Status = "Overdue" },
        };

        // Matches your nav/link: /APInvoices/ListAPInvoice
        public IActionResult ListAPInvoice()
        {
            var model = _invoices.OrderByDescending(i => i.InvoiceDate).ToList();
            return View(model);
        }

        // Optional: /APInvoices redirects to ListAPInvoice
        public IActionResult Index() => RedirectToAction(nameof(ListAPInvoice));
    }

}

