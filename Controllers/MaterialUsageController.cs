using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class MaterialUsageController : Controller
    {
        // GET: MaterialUsageController
        public IActionResult ListMaterialUsage()
        {
            return View();
        }

    }
}
