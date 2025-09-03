using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class PaymentsController : Controller
    {
        // GET: PaymentsController
        public IActionResult ListPayments()
        {
            return View();
        }

    }
}
