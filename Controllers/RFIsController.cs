using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class RFIsController : Controller
    {
        // GET: RFIsController
        public IActionResult ListRFIs()
        {
            return View();
        }

    }
}
