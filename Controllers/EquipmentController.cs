using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class EquipmentController : Controller
    {
        // GET: EquipmentController
        public IActionResult ListEquipment()
        {
            return View();
        }

    }
}
