using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class JournalEntriesController : Controller
    {
        // GET: JournalEntriesController
        public IActionResult ListJournalEntries()
        {
            return View();
        }

    }
}
