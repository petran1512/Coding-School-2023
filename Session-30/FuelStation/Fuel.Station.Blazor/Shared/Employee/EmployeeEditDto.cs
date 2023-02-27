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

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:01/01/2021}")]
        [Range(typeof(DateTime), "01/01/2021", "01/01/2100")]
        public DateTime HireDateStart { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? HireDateEnd { get; set; }

        [Required]
        [Range(0, 99999, ErrorMessage = "The range is from 0 to 99999!")]

        public decimal SallaryPerMonth { get; set; }

        public EmployeeType employeeType { get; set; }
    }
}
