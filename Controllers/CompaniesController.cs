using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class CompaniesController : Controller
    {
        // GET: CompaniesController
        public IActionResult ListCompanies()
        {
            return View();
        }

    }
}
