using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class PurchaseOrdersController : Controller
    {
        // GET: PurchaseOrdersController
        public IActionResult ListPurchaseOrders()
        {
            return View();
        }

    }
}
