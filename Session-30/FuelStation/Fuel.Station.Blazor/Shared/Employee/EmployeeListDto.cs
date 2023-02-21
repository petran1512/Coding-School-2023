using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Station.Blazor.Shared
{
    public class EmployeeListDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public DateTime HireDateStart { get; set; }

        public DateTime HireDateEnd { get; set; }

        public decimal SallaryPerMonth { get; set; }

        public EmployeeType employeeType { get; set; }
    }
}
