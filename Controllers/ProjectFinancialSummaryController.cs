using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class ProjectFinancialSummaryController : Controller
    {
        // GET: ProjectFinancialSummaryController
        public IActionResult ListProjectFinancialSummary()
        {
            return View();
        }

    }
}
