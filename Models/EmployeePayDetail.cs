using System.ComponentModel.DataAnnotations;

namespace ERP_Demo
{
    public class EmployeePayDetail
    {
        [Key]
        public int PayDetailID { get; set; }

        public int EmployeeID { get; set; }

        public int PayrollRunID { get; set; }

        public decimal? GrossPay { get; set; }

        public decimal? NetPay { get; set; }

        public decimal? TaxesWithheld { get; set; }

        public decimal? Deductions { get; set; }

        public virtual Employee Employee { get; set; } = null!;

        public virtual PayrollRun PayrollRun { get; set; } = null!;
    }
}