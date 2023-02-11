using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace PetShop.Web.MVC.Models.Transaction
{
    public class TransactionCreateDto
    {
        [Display(Name = "DateTime")]
        public DateTime? Date { get; set; }  

        [Range(0, 100000.99, ErrorMessage = "Range 0 to 100000.99 characters")]
        public decimal PetPrice { get; set; }

        [Display(Name = "Pet Food Quantity")]
        public int PetFoodQty { get; set; }

        [Range(0, 100000.99, ErrorMessage = "Range 0 to 100000.99 characters")]
        public decimal PetFoodPrice { get; set; }

        [Range(0, 100000.99, ErrorMessage = "Range 0 to 100000.99 characters")]
        public decimal TotalPrice { get; set; }

        [Display(Name = "Customer")]
        public int CustomerId { get; set; }

        [Display(Name = "Employee")]
        public int EmployeeId { get; set; }

        [Display(Name = "Pet")]
        public int PetId { get; set; }

        [Display(Name = "Pet Food")]
        public int PetFoodId { get; set; }
    }
}