using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Station.Model
{
    public class Transaction
    {
        //Properties
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }

        //Constructors
        public Transaction()
        {

        }

        public Transaction(DateTime date, PaymentMethod paymentMethod, decimal totalValue, int employeeId, int customerId)
        {
            Date = date;
            PaymentMethod = paymentMethod;
            TotalValue = totalValue;
            EmployeeId = employeeId;
            CustomerId = customerId;
        }

        //Relations

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }


    }
}
