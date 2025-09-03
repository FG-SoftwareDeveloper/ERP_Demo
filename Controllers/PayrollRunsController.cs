using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class PayrollRunsController : Controller
    {
        // GET: PayrollRunsController
        public IActionResult ListPayrollRuns()
        {
            return View();
        }

    }
}
