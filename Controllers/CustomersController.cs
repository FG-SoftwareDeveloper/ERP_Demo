using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class CustomersController : Controller
    {
        // GET: CustomersController
        public IActionResult ListCustomers()
        {
            return View();
        }

    }
}
