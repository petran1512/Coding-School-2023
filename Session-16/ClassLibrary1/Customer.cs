using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1
{
    public class Customer : User
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public int TIN { get; set; }

        public Customer()
        {

        }
    }
}
   