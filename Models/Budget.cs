using ERP_Demo.Models;

namespace ERP_Demo
{
    public class Budget
    {
        //general properties
        public int BudgetID { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
    
        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public int Hour { get; set; }

        public int Minute { get; set; }


        public int Second { get; set; }

        public decimal Amount { get; set; }

        public int AccountId { get; set; }

        public Account Account { get; set; } = null!;


    }
}