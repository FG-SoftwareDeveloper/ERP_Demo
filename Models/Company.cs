using ERP_Demo.Models;
using System.ComponentModel.DataAnnotations;

namespace ERP_Demo;

public class Company
{
    [Key]
    public int CompanyID { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? Address { get; set; }

    public string? ContactInfo { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();

    public virtual ICollection<FinancialSnapshot> FinancialSnapshots { get; set; } = new List<FinancialSnapshot>();

    public virtual ICollection<ForecastedFinancial> ForecastedFinancials { get; set; } = new List<ForecastedFinancial>();

    public virtual ICollection<JournalEntry> JournalEntries { get; set; } = new List<JournalEntry>();

    public virtual ICollection<KPI> KPIs { get; set; } = new List<KPI>();

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();

    public virtual ICollection<PayrollRun> PayrollRuns { get; set; } = new List<PayrollRun>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<Vendor> Vendors { get; set; } = new List<Vendor>();

}
