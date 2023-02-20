namespace Fuel.Station.Model
{
    public class Customer
    {
        //Properties
        public int Id { get; set; }    

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? CardNumber { get; set; }


        //Constructors
        public Customer()
        {

        }
        public Customer( string? name, string? surname, string? cardNumber)
        {
            Name = name;
            Surname = surname;
            CardNumber = cardNumber;
        }


        //Relations
        public List<Transaction> Transactions { get; set; }


    }
}
