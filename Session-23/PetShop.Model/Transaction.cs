﻿namespace PetShop.Model
{
    public class Transaction
    {
        public Transaction(decimal petPrice, int petFoodQty, decimal petFoodPrice, decimal totalPrice)
        {
            
            PetPrice = petPrice;
            PetFoodPrice = petFoodPrice;
            PetFoodQty = petFoodQty;
            TotalPrice = totalPrice;
        }

        public Transaction()
        {

        }

        public Transaction(DateTime? date, decimal petPrice, int petFoodQty, decimal petFoodPrice, 
            decimal totalPrice, int customerId,  int employeeId,  int petId,int petFoodId)
        {
            Date = (DateTime)date;
            PetPrice = petPrice;
            PetFoodQty = petFoodQty;
            PetFoodPrice = petFoodPrice;
            TotalPrice = totalPrice;
            CustomerId = customerId;
            EmployeeId = employeeId;
            PetId = petId;
            PetFoodId = petFoodId;
        }

        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public decimal PetPrice { get; set; }
        public int PetFoodQty { get; set; }
        public decimal PetFoodPrice { get; set; }
        public decimal TotalPrice { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; } = null!;

        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; } = null!;

        public int PetId { get; set; }
        public Pet? Pet { get; set; } = null!;

        public int PetFoodId { get; set; }
        public PetFood? PetFood { get; set; } = null!;
    }
}
