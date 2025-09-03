using ERP_Demo;
using ERP_Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class ARInvoicesController : Controller
    {
        // Sample data
        private static readonly List<ARInvoice> _aRInvoices = new()
        {
            new() { ARInvoiceID = 1, InvoiceDate = DateTime.Today.AddDays(-10), Amount = 1250.75m, Status = "Open" },
            new() { ARInvoiceID = 2, InvoiceDate = DateTime.Today.AddDays(-6), Amount = 480.00m, Status = "Paid" },
            new() { ARInvoiceID = 3, InvoiceDate = DateTime.Today.AddDays(-2), Amount = 2199.99m, Status = "Overdue" },
        };

        // Matches sidebar: /ARInvoices/ListARInvoices
        public IActionResult ListARInvoices()
        {
            var model = _aRInvoices.OrderByDescending(i => i.InvoiceDate).ToList();
            return View(model);
        }

        // Optional: /ARInvoices redirects to ListARInvoices
        public IActionResult Index() => RedirectToAction(nameof(ListARInvoices));


    }
}
