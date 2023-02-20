using FuelStation.Model.Enums;

namespace Fuel.Station.Model;

public class Employee
{        
    //Properties
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public DateTime HireDateStart { get; set; } 

    public DateTime HireDateEnd { get;set; }

    public decimal SallaryPerMonth { get; set; }
    
    public EmployeeType employeeType { get; set; }

    //Constructors

    public Employee()
    {

    }

    public Employee(int id, string? name, string? surname,EmployeeType employeetype)
    {
        Id = id;
        Name = name;
        Surname = surname;
        employeeType = employeetype;
    }


    //Relations
    public List<Transaction> Transactions { get; set; }


}
