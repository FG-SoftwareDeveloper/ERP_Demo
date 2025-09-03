using ERP_Demo.Data;
using ERP_Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class AccountsController : Controller
    {
        //Return Accounts.cshtml View
        // In-memory sample data for now. Replace with EF later.
        private static readonly List<Account> _accounts = new()
        {
            new() { Id=1, Name="Cash", AccountType="Asset", CurrentBalance=50000, Company="Contoso", Active=true },
            new() { Id=2, Name="Accounts Payable", AccountType="Liability", CurrentBalance=12000, Company="Contoso", Active=true },
            new() { Id=3, Name="Sales Revenue", AccountType="Revenue", CurrentBalance=250000, Company="Contoso", Active=true },
        };

        public IActionResult ListAccounts() => View(_accounts.OrderBy(a => a.Id));

        public IActionResult Details(int id)
        {
            var m = _accounts.FirstOrDefault(a => a.Id == id);
            if (m == null) return NotFound();
            return View(m);
        }

        public IActionResult Create() => View(new Account());

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(Account model)
        {
            if (!ModelState.IsValid) return View(model);
            var newId = _accounts.Any() ? _accounts.Max(a => a.Id) + 1 : 1;
            var newAccount = new Account
            {
                Id = newId,
                Name = model.Name,
                AccountType = model.AccountType,
                CurrentBalance = model.CurrentBalance,
                Company = model.Company,
                Active = model.Active
            };
            _accounts.Add(newAccount);
            TempData["Msg"] = "Account created.";
            return RedirectToAction(nameof(ListAccounts));
        }

        public IActionResult Edit(int id)
        {
            var m = _accounts.FirstOrDefault(a => a.Id == id);
            if (m == null) return NotFound();
            return View(m);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Account model)
        {
            if (!ModelState.IsValid) return View(model);
            var existing = _accounts.FirstOrDefault(a => a.Id == id);
            if (existing == null) return NotFound();

            existing.Name = model.Name;
            existing.AccountType = model.AccountType;
            existing.CurrentBalance = model.CurrentBalance;
            existing.Company = model.Company;
            existing.Active = model.Active;

            TempData["Msg"] = "Account updated.";
            return RedirectToAction(nameof(ListAccounts));
        }

        public IActionResult Delete(int id)
        {
            var m = _accounts.FirstOrDefault(a => a.Id == id);
            if (m == null) return NotFound();
            return View(m);
        }

        [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var m = _accounts.FirstOrDefault(a => a.Id == id);
            if (m != null) _accounts.Remove(m);
            TempData["Msg"] = "Account deleted.";
            return RedirectToAction(nameof(ListAccounts));
        }

    }
}
