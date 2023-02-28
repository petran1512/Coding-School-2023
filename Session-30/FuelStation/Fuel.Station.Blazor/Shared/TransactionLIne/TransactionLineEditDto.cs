using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Station.Blazor.Shared
{
    public class TransactionLineEditDto
    {
        public int Id { get; set; }
        [Range(0, 99999, ErrorMessage = "Enter a number greater than 0!")]
        public decimal Quantity { get; set; }
        [Range(0, 99999, ErrorMessage = "Enter a number greater than 0!")]
        public decimal ItemPrice { get; set; }
        [Range(0, 99999, ErrorMessage = "Enter a number greater than 0!")]
        public decimal NetValue { get; set; }

        [Range(0, 99999, ErrorMessage = "Enter a number greater than 0!")]
        public decimal DiscountPercent { get; set; }

        [Range(0, 99999, ErrorMessage = "Enter a number greater than 0!")]
        public decimal DiscountValue { get; set; }

        [Range(0, 99999, ErrorMessage = "Enter a number greater than 0!")]
        public decimal TotalValue { get; set; }

        public int TransactionId { get; set; }
        public int ItemId { get; set; }
        //public ItemListDto Item { get; set; } = null!;

    }
}
