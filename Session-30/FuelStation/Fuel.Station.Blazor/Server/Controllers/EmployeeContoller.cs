using Microsoft.AspNetCore.Mvc;
using Fuel.Station.Blazor.Shared;
using Fuel.Solution.EF.Repositories;
using Fuel.Station.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Microsoft.AspNetCore.Authorization;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace Fuel.Station.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
        {
        // Properties
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IValidator _validator;
        private String _errorMessage;

        // Constructors
        public EmployeeController(IEntityRepo<Employee> employeeRepo, IValidator validator)
        {
            _employeeRepo = employeeRepo;
            _errorMessage = String.Empty;
            _validator = validator;
        }

        // GET: /<EmployeesController>
        [HttpGet]
        [Authorize(Roles = "Administrator")]
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

        // GET: /<EmployeesController>/5
        [HttpGet("{id}")]
        [Authorize(Roles = "Administrator")]
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

        // POST /<EmployeesController>
        [HttpPost]
        public async Task<ActionResult> Post(EmployeeEditDto employee)
        {
            var newEmployee = new Employee(employee.Name, employee.Surname, employee.employeeType)
            {
                HireDateStart = employee.HireDateStart,
                HireDateEnd = employee.HireDateEnd,
                SallaryPerMonth = employee.SallaryPerMonth,
            };
            if (_validator.ValidateAddEmployee(employee.employeeType, _employeeRepo.GetAll().ToList(), out _errorMessage, newEmployee))
            {
                try
                {
                    await Task.Run(() => { _employeeRepo.Add(newEmployee); });
                    return Ok();
                }
                catch (DbException ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            else
            {
                return BadRequest(_errorMessage);
            }
        }

        // PUT /<EmployeesController>/5
        [HttpPut]
        public async Task Put(EmployeeEditDto employee)
        {
            var dbEmployee = await Task.Run(() => { return _employeeRepo.GetById(employee.Id); });
            if (dbEmployee == null)
            {
                // TODO if employee is null
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

        // DELETE /<EmployeesController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await Task.Run(() => {
                _employeeRepo.Delete(id);
            });
        }
    }
}

