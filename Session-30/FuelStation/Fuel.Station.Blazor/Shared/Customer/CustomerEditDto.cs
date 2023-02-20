using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fuel.Station.Blazor.Shared.Avalidator;


namespace Fuel.Station.Blazor.Shared.Customer
{
    public class CustomerEditDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Type less than 50 characters")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(50, ErrorMessage = "Type less than 50 characters")]
        public string Surname { get; set; } = null!;

        [Required]
        [MaxLength(100, ErrorMessage = "Type less than 100 characters")]
        [AValidator(ErrorMessage = "The card number must start with the letter A.")]
        public string CardNumber { get; set; } = null!;
    }
}
