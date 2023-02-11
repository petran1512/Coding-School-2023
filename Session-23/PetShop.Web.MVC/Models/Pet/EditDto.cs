using PetShop.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Web.MVC.Models.Pet
{
    public class PetEditDto
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "Type less than 50 characters")]
        public string Breed { get; set; } = null!;

        [Display(Name = "Animal Type")]
        public AnimalType AnimalType { get; set; }

        [Display(Name = "Animal Type")]
        public PetStatus PetStatus { get; set; }

        [Range(0, 100000.99, ErrorMessage = "Range 0 to 100000.99 characters")]
        public decimal Price { get; set; }

        [Range(0, 100000.99, ErrorMessage = "Range 0 to 100000.99 characters")]
        public decimal Cost { get; set; }
    }
}
