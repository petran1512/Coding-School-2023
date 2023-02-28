using Fuel.Station.Model;
using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Station.Blazor.Shared
{
    public class TransactionEditDto
    {
        public int Id { get; set; }

        [Required]
        [Range(typeof(DateTime), "01/01/2022", "01/01/2100")]
        public DateTime Date { get; set; }

        [Required]
        [Range(0, 1, ErrorMessage = "You must choose a Payment Method!")]
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }

        public int CustomerId { get; set; }

        public int EmployeeId { get; set; }

        public List<TransactionLineEditDto>? TransactionLines { get; set; }
    }
}
