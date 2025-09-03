using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class RolesController : Controller
    {
        // GET: RolesController
        public IActionResult ListRoles()
        {
            return View();
        }

    }
}
