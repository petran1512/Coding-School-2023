using PetShop.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Web.MVC.Models.PetFood
{
    public class PetFoodEditDto
    {
        [Display(Name = "Animal Type")]
        public AnimalType AnimalType { get; set; }

        [Range(0, 100000.99, ErrorMessage = "Range 0 to 100000.99 characters")]
        public decimal Price { get; set; }

        [Range(0, 100000.99, ErrorMessage = "Range 0 to 100000.99 characters")]
        public decimal Cost { get; set; }
    }
}
