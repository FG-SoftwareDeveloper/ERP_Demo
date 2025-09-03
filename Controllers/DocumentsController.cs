using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class DocumentsController : Controller
    {
        // GET: DocumentsController
        public IActionResult ListDocuments()
        {
            return View();
        }

    }
}
