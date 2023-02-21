using Fuel.Station.Blazor.Shared.Validator;
using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Station.Blazor.Shared
{
    public class EmployeeEditDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Type less than 30 characters")]
        [LettersValidator(ErrorMessage = "The Name must contain only Letters.")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(30, ErrorMessage = "Type less than 30 characters")]
        [LettersValidator(ErrorMessage = "The Surname must contain only Letters.")]
        public string Surname { get; set; } = null!;

        public DateTime HireDateStart { get; set; }

        public DateTime HireDateEnd { get; set; }

        //[Required]
        //[MinLength(0, ErrorMessage = "Value must be greater than 0.")]
        public decimal SallaryPerMonth { get; set; }

        //[Required]
        //[Range(1, 4, ErrorMessage = "You must choose a type!")]
        public EmployeeType employeeType { get; set; }
    }
}
