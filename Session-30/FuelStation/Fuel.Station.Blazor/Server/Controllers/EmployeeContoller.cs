using Microsoft.AspNetCore.Mvc;
using Fuel.Station.Blazor.Shared;
using Fuel.Solution.EF.Repositories;
using Fuel.Station.Model;

namespace Fuel.Station.Blazor.Server.Controllers
{
    public class EmployeeController : Controller
    {
        // Properties
        private readonly IEntityRepo<Employee> _employeeRepo;
        //private readonly IValidator _validator;
        private String _errorMessage;

        // Constructors
        public EmployeeController(IEntityRepo<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;
            //_validator = validator;
            _errorMessage = String.Empty;
        }

        // GET: /<CustomersController>
        [HttpGet]
        public async Task<IEnumerable<EmployeeListDto>> Get()
        {
            var result = await Task.Run(() => { return _employeeRepo.GetAll(); });
            var selectEmployeeList = result.Select(employee => new EmployeeListDto
            {
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                HireDateStart = employee.HireDateStart,
                HireDateEnd = employee.HireDateEnd,
                SallaryPerMonth = employee.SallaryPerMonth,
                employeeType = employee.employeeType,
            });
            return selectEmployeeList;
        }

        // GET: /<CustomersController>/5
        [HttpGet("{id}")]
        public async Task<EmployeeEditDto?> GetById(int id)
        {
            var result = await Task.Run(() => { return _employeeRepo.GetById(id); });
            if (result == null)
            {
                return null;
            }
            EmployeeEditDto employee = new EmployeeEditDto
            {
                Id = id,
                Name = result.Name,
                Surname = result.Surname,
                HireDateStart = result.HireDateStart,
                HireDateEnd = result.HireDateEnd,
                SallaryPerMonth = result.SallaryPerMonth,
                employeeType = result.employeeType,
            };
            return employee;
        }

        // POST /<CustomersController>
        [HttpPost]
        public async Task<ActionResult> Post(EmployeeEditDto employee)
        {
            var newEmployee = new Employee(employee.Name, employee.Surname, employee.employeeType)
            {
                HireDateStart = employee.HireDateStart,
                HireDateEnd = employee.HireDateEnd,
                SallaryPerMonth = employee.SallaryPerMonth,
            };
            await Task.Run(() => { _employeeRepo.Add(newEmployee); });
            return Ok();
            //if (_validator.ValidateAddCustomer(_customerRepo.GetAll().ToList(), out _errorMessage)) {
            //    try {
            //        await Task.Run(() => { _customerRepo.Add(newCustomer); });
            //        return Ok();
            //    }
            //    catch (DbException ex) {
            //        return BadRequest(ex.Message);
            //    }
            //}
            //else {
            //    return BadRequest(_errorMessage);
            //}
        }

        // PUT /<CustomersController>/5
        [HttpPut]
        public async Task Put(EmployeeEditDto employee)
        {
            var dbEmployee = await Task.Run(() => { return _employeeRepo.GetById(employee.Id); });
            if (dbEmployee == null)
            {
                // TODO if customer is null
                return;
            }
            dbEmployee.Name = employee.Name;
            dbEmployee.Surname = employee.Surname;
            dbEmployee.HireDateStart = employee.HireDateStart;
            dbEmployee.HireDateEnd = employee.HireDateEnd;
            dbEmployee.SallaryPerMonth = employee.SallaryPerMonth;
            dbEmployee.employeeType = employee.employeeType;
            _employeeRepo.Update(employee.Id, dbEmployee);
        }

        // DELETE /<CustomersController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await Task.Run(() => {
                _employeeRepo.Delete(id);
            });
        }
    }
}

