using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class DepartmentsController : Controller
    {
        // GET: DepartmentsController
        public IActionResult ListDepartments()
        {
            return View();
        }

    }
}
