using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using static PetShop.Model.Employee;

namespace PetShop.Web.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEntityRepo<Employee> _employeeRepo;
        public EmployeeController(IEntityRepo<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        // GET: EmployeeController
        public ActionResult Index()
        {
            var employees = _employeeRepo.GetAll();
            return View(model: employees);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeCreateDto employee)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbEmployee = new Employee(employee.Name, employee.Surname, employee.EmployeeType, employee.SalaryPerMonth);
            _employeeRepo.Add(dbEmployee);
            return RedirectToAction("Index");
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbEmployee = _employeeRepo.GetById(id);
            if (dbEmployee == null)
            {
                return NotFound();
            }
            var viewemployee = new EmployeeEditDto();
            {
                viewemployee.Name = dbEmployee.Name;
                viewemployee.Surname = dbEmployee.Surname;
                viewemployee.EmployeeType = dbEmployee.EmployeeType;
                viewemployee.SalaryPerMonth = dbEmployee.SalaryPerMonth;
            };
            return View(model: employee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection employee)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbEmployee = _employeeRepo.GetById(id);
            if (dbEmployee == null)
            {
                return NotFound();
            }
            dbEmployee.Name = employee.Name;
            dbEmployee.Surname = employee.Surname;
            dbEmployee.EmployeeType = employee.EmployeeType;
            dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;
            _employeeRepo.Update(id, dbEmployee);
            return RedirectToAction(nameof(Index));
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
