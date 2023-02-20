using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Station.Blazor.Shared.Customer
{
    public class CustomerDetailsDto
    {
            public int Id { get; set; }
            public string Name { get; set; } = null!;
            public string Surname { get; set; } = null!;
            public string CardNumber { get; set; } = null!;
    }
}
