using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fuel.Station.Blazor.Shared.Validator;

namespace Fuel.Station.Blazor.Shared
{
    public class CustomerEditDto
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
        [MaxLength(10, ErrorMessage = "Max Limit 10 characters")]
        [AValidator(ErrorMessage = "The card number must start with the letter A.")]
        public string CardNumber { get; set; } = null!;
    }
}
