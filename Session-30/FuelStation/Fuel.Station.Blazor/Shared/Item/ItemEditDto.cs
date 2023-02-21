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
    public class ItemEditDto
    {
        public int Id { get; set; }
        [Required]
        public string? Code { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Limit of Description 100 characters")]
        [LettersValidator(ErrorMessage = "The Description must contain only Letters.")]
        public string? Description { get; set; }
        [Required]
        public ItemType itemType { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Cost { get; set; }
    }
}
