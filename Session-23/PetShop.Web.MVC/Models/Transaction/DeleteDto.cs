﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Web.MVC.Models.Transaction
{
    public class TransactionDeleteDto
    {
        public int Id { get; set; }
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
        public Model.Customer Customers { get; set; } = null!;
        public Model.Employee Employees { get; set; } = null!;
        public Model.Pet Pets { get; set; } = null!;
        public Model.PetFood PetFoods { get; set; } = null!;
    }
}
