using Fuel.Station.Blazor.Shared;
using Fuel.Station.Model;
using Fuel.Solution.EF.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Fuel.Station.Blazor;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fuel.Station.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // Properties
        private readonly IEntityRepo<Customer> _customerRepo;

        // Constructors
        public CustomerController(IEntityRepo<Customer> cutomerRepo)
        {
            _customerRepo = cutomerRepo;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        public async Task<IEnumerable<CustomerListDto>> Get()
        {
            var result = await Task.Run(() => { return _customerRepo.GetAll(); });
            var selectCustomerList = result.Select(customer => new CustomerListDto
            {
                Id = customer.Id,
                Name = customer.Name,
                Surname = customer.Surname,
                CardNumber = customer.CardNumber,
            });
            return selectCustomerList;
        }

        // GET: api/<CustomersController>
        [HttpGet("{id}")]
        public async Task<CustomerEditDto?> GetById(int id)
        {
            var result = await Task.Run(() => { return _customerRepo.GetById(id); });
            if (result == null)
            {
                return null;
            }
#pragma warning disable CS8601 // Possible null reference assignment.
            CustomerEditDto customer = new CustomerEditDto
            {
                Id = id,
                Name = result.Name,
                Surname = result.Surname,
                CardNumber = result.CardNumber,
            };
#pragma warning restore CS8601 // Possible null reference assignment.
            return customer;
        }

        // POST api/<CustomersController>
        [HttpPost]
        public async Task<ActionResult> Post(CustomerEditDto customer)
        {
            var newCustomer = new Customer(customer.Name, customer.Surname, customer.CardNumber);
            try
            {
                await Task.Run(() => { _customerRepo.Add(newCustomer); });
                return Ok();
            }          

            catch (DbUpdateException exception)
            when (exception?.InnerException?.Message.Contains("Cannot insert duplicate key row in object") ?? false)
            {
                return BadRequest("This CardNumber is already in use,try again.");
            }

        }

        // PUT api/<CustomersController>/5
        [HttpPut]
        public async Task<ActionResult> Put(CustomerEditDto customer)
        {
            var dbCustomer = await Task.Run(() => { return _customerRepo.GetById(customer.Id); });
            if (dbCustomer == null)
            {
                // TODO if customer is null
                return BadRequest("Can not found. Please try again."); ;
            }
            dbCustomer.Name = customer.Name;
            dbCustomer.Surname = customer.Surname;
            dbCustomer.CardNumber = customer.CardNumber;
            _customerRepo.Update(customer.Id, dbCustomer);

            try
            {
                await Task.Run(() => { _customerRepo.Update(customer.Id, dbCustomer); });
                return Ok();
            }
            catch (DbUpdateException exception)
            when (exception?.InnerException?.Message.Contains("Cannot insert duplicate key row in object") ?? false)
            {
                return BadRequest("This CardNumber is already in use,try again.");
            }
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await Task.Run(() => { _customerRepo.Delete(id); });
            }
            catch (DbException)
            {
                return BadRequest(new { message = "The customer cannot be deleted because they are in Transactions" });
            }
            return Ok();

        }
    }
}
