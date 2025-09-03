using ERP_Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class APInvoicesController : Controller
    {
        // Hard-coded sample data
            private static readonly List<APInvoice> _invoices = new()
        {
            new() {
                APInvoiceID = 1,
                VendorID = 1,
                CustomerID = 1,
                ProjectID = null,
                InvoiceDate = DateTime.Today.AddDays(-10),
                DueDate = DateTime.Today.AddDays(-3),
                Amount = 1250.75m,
                Status = "Open",
                Description = "AP-1001: Contoso Supplies"
            },
            new() {
                APInvoiceID = 2,
                VendorID = 2,
                CustomerID = 2,
                ProjectID = null,
                InvoiceDate = DateTime.Today.AddDays(-6),
                DueDate = DateTime.Today.AddDays(1),
                Amount = 480.00m,
                Status = "Paid",
                Description = "AP-1002: Northwind Traders"
            },
            new() {
                APInvoiceID = 3,
                VendorID = 3,
                CustomerID = 3,
                ProjectID = null,
                InvoiceDate = DateTime.Today.AddDays(-2),
                DueDate = DateTime.Today.AddDays(5),
                Amount = 2199.99m,
                Status = "Overdue",
                Description = "AP-1003: Fabrikam, Inc."
            },
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

