using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class MaterialsController : Controller
    {
        // GET: MaterialsController
        public IActionResult ListMaterials()
        {
            return View();
        }

    }
}
