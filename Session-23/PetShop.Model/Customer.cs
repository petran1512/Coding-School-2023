using System.ComponentModel.DataAnnotations;

namespace PetShop.Model
{
    public class Customer
    {
        public Customer(string name, string surname, string phone, string tin)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Tin = tin;

            Transactions = new List<Transaction>();
        }

        public Customer()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Tin { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }

    public class CustomerCreateDto
    {
        [MaxLength(50, ErrorMessage = "Type less than 50 characters")]
        public string Name { get; set; } = null!;
        [MaxLength(100, ErrorMessage = "Type less than 100 characters")]
        public string Surname { get; set; } = null!;
        [MaxLength(15, ErrorMessage = "Type less than 15 characters")]
        public string Phone { get; set; } = null!;
        [MaxLength(15, ErrorMessage = "Type less than 15 characters")]
        public string Tin { get; set; } = null!;
    }
}
