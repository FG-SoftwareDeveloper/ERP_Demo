using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class ServiceOrdersController : Controller
    {
        // GET: ServiceOrdersController
        public IActionResult ListServiceOrders()
        {
            return View();
        }

    }
}
