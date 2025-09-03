using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class ServiceAgreementsController : Controller
    {
        // GET: ServiceAgreementsController
        public IActionResult ListServiceAgreements()
        {
            return View();
        }

    }
}
