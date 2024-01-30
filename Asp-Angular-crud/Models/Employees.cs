using System.ComponentModel.DataAnnotations;

namespace Asp_Angular_crud.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; } = string.Empty;

        public int EmployeeAge { get; set; }
    }
}
