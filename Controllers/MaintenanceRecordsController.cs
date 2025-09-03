using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class MaintenanceRecordsController : Controller
    {
        // GET: MaintenanceRecordsController
        public IActionResult ListMaintenanceRecords()
        {
            return View();
        }

    }
}
