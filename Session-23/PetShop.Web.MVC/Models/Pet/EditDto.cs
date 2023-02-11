using PetShop.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Web.MVC.Models.Pet
{
    public class PetEditDto
    {
        [MaxLength(50, ErrorMessage = "Type less than 50 characters")]
        public string Breed { get; set; } = null!;

        [Display(Name = "Animal Type")]
        public AnimalType AnimalType { get; set; }

        [Display(Name = "Animal Type")]
        public PetStatus PetStatus { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }
    }
}
