using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Web.MVC.Models.Customer;

namespace PetShop.Web.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        public CustomerController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo = customerRepo;
        }

        // GET: CustomerController
        public ActionResult Index()
        {
            var customers = _customerRepo.GetAll();
            return View(model: customers);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = _customerRepo.GetById(id.Value);
            if (customer == null)
            {
                return NotFound();
            }
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerCreateDto customer)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbCustomer = new Customer(customer.Name,customer.Surname, customer.Phone, customer.Tin);
            _customerRepo.Add(dbCustomer);
            return RedirectToAction("Index");
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null)
            {
                return NotFound();
            }
            var viewcustomer = new CustomerEditDto();
            {
                viewcustomer.Name = dbCustomer.Name;
                viewcustomer.Surname = dbCustomer.Surname;
                viewcustomer.Phone = dbCustomer.Phone;
                viewcustomer.Tin = dbCustomer.Tin;
            };
            return View(model: viewcustomer);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerEditDto customer)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null)
            {
                return NotFound();
            }
            dbCustomer.Name = customer.Name;
            dbCustomer.Surname = customer.Surname;
            dbCustomer.Phone = customer.Phone;
            dbCustomer.Tin = customer.Tin;
            _customerRepo.Update(id, dbCustomer);
            return RedirectToAction(nameof(Index));
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
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
