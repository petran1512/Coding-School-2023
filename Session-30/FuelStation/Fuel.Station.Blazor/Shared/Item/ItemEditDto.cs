using Fuel.Station.Blazor.Shared.Validator;
using FuelStation.Model.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Station.Blazor.Shared
{
    public class ItemEditDto
    {
        public int Id { get; set; }

        [Required]
        //[Index("Code", IsUnique = true)]
        [MaxLength(5, ErrorMessage = "Type less than 6 characters")]
        public string? Code { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Limit of Description 100 characters")]
        [LettersValidator(ErrorMessage = "The Description must contain only Letters.")]
        public string? Description { get; set; }
        [Required]
        public ItemType itemType { get; set; }

        [Required]
        [Range(0, 99999, ErrorMessage = "Enter a number greater than 0!")]
        public decimal Price { get; set; }
        [Required]
        [Range(0, 99999, ErrorMessage = "Enter a number greater than 0!")]

        public decimal Cost { get; set; }
    }
}
