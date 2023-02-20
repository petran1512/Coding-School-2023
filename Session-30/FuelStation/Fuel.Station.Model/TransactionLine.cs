using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Station.Model
{
    public class TransactionLine
    {
        //Properties
        public int Id { get; set; }
        public decimal Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }

        //Constructors
        public TransactionLine()
        {

        }

        public TransactionLine(int transactionId, int itemId)
        {
            TransactionId= transactionId;
            ItemId= itemId;
        }

        //Relations

        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
