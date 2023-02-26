using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Station.Model
{
    public class Ledger
    {
        //Properties
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }

        //Constructors

        public Ledger(int year, int month,decimal income,decimal expenses)
        {
            Year = year;
            Month = month;
            Income = income;
            Expenses = expenses;
            Total = income - expenses;
        }

        public Ledger(DateTime datetime)
        {
            Year = datetime.Year;
            Month = datetime.Month;
        }

        public void AddRent(decimal rent)
        {
            Expenses += rent;
        }

    }
}
