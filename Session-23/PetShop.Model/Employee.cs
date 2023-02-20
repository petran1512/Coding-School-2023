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
}

