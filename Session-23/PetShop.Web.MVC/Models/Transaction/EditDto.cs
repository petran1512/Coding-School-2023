﻿using System.ComponentModel.DataAnnotations;

namespace PetShop.Web.MVC.Models.Transaction
{
    public class TransactionEditDto
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
    }
}
