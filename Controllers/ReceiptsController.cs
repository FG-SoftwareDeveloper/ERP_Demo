using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class ReceiptsController : Controller
    {
        // GET: ReceiptsController
        public IActionResult ListReceipts()
        {
            return View();
        }

    }
}
