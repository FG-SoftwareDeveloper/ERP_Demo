using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class BankAccountsController : Controller
    {
        // GET: BankAccountsController
        public IActionResult ListBankAccounts()
        {
            return View();
        }

    }
}
