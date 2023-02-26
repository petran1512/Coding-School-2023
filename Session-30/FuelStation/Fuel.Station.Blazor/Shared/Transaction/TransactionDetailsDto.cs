
using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Station.Blazor.Shared
{
    public class TransactionDetailsDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }

        public int CustomerId { get; set; }
        public CustomerListDto Customer { get; set; } = null!;

        public int EmployeeId { get; set; }
        public EmployeeListDto Employee { get; set; } = null!;

        public List<TransactionLineDetailsDto> TransactionLines { get; set; } = new();

    }
}
