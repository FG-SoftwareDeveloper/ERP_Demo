using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class EmployeesController : Controller
    {
        // GET: EmployeesController
        public IActionResult ListEmployees()
        {
            return View();
        }

    }
}
