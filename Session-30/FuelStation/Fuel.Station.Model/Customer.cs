using Microsoft.EntityFrameworkCore;

namespace Fuel.Station.Model
{
    [Index(nameof(CardNumber), IsUnique = true)]

    public class Customer
    {
        //Properties
        public int Id { get; set; }    

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? CardNumber { get; set; }


        //Constructors
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Customer()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Customer( string? name, string? surname, string? cardNumber)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            Name = name;
            Surname = surname;
            CardNumber = cardNumber;
        }


        //Relations
        public List<Transaction> Transactions { get; set; }

    }
}
