using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class ProjectsController : Controller
    {
        // GET: ProjectsController
        public IActionResult ListProjects()
        {
            return View();
        }

    }
}
