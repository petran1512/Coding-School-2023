using Fuel.Station.Model;
using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Station.Blazor.Shared { 
        public interface IValidator
        {
        bool ValidateAddEmployee(EmployeeType type, List<Employee> employees, out string errorMessage, Employee employee);
        bool ValidateUpdateEmployee(EmployeeType NewType, Employee dbEmployee, List<Employee> employees, out string errorMessage);
        bool ValidateDeleteEmployee(EmployeeType type, List<Employee> employees, out string errorMessage);
        bool ValidateAddCustomer(List<Customer> customers, out string errorMessage);
        bool ValidateDeleteCustomer(List<Customer> customers, out string errorMessage);
        bool ValidateTransaction(Transaction transaction, out string errorMessage);
    }
}
