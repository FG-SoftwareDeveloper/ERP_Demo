using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class PurchaseOrderLinesController : Controller
    {
        // GET: PurchaseOrderLinesController
        public IActionResult ListPurchaseOrderLines()
        {
            return View();
        }

    }
}
