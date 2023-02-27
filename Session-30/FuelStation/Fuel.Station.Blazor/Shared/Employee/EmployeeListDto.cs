using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:01/01/2021}")]
        public DateTime HireDateStart { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? HireDateEnd { get; set; }

        public decimal SallaryPerMonth { get; set; }

        public EmployeeType employeeType { get; set; }
    }
}
