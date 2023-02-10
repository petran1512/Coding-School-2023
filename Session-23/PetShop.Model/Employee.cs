using PetShop.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Model
{
    public class Employee
    {
        public Employee(string name, string surname, EmployeeType employeeType, int salaryPerMonth)
        {
            Name = name;
            Surname = surname;
            EmployeeType = employeeType;
            SalaryPerMonth = salaryPerMonth;

            Transactions = new List<Transaction>();
        }

        public Employee()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public int SalaryPerMonth { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
        public class EmployeeCreateDto
        {
            [MaxLength(50, ErrorMessage = "Type less than 50 characters")]
            public string Name { get; set; } = null!;
            [MaxLength(100, ErrorMessage = "Type less than 100 characters")]
            public string Surname { get; set; } = null!;
            [Display(Name = "Employee Type")]
            public EmployeeType EmployeeType { get; set; }
            [Display(Name = "Salary Per Month")]
            public int SalaryPerMonth { get; set; }
        }
    public class EmployeeEditDto
    {
        [MaxLength(50, ErrorMessage = "Type less than 50 characters")]
        public string Name { get; set; } = null!;
        [MaxLength(100, ErrorMessage = "Type less than 100 characters")]
        public string Surname { get; set; } = null!;
        [Display(Name = "Employee Type")]
        public EmployeeType EmployeeType { get; set; }
        [Display(Name = "Salary Per Month")]
        public int SalaryPerMonth { get; set; }
    }
}

