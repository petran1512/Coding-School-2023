﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;

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
        //public ActionResult Details(int id)
        //{
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var customers = _customerRepo.GetById(id.Value);
            //if (customers == null)
            //{
            //    return NotFound();
            //}
            //return View();
        //}

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
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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
