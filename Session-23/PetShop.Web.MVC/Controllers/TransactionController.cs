﻿using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.EF;
using PetShop.Model.Enums;
using PetShop.Web.MVC.Models.PetFood;
using PetShop.Web.MVC.Models.Transaction;
using Transaction = PetShop.Model.Transaction;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PetShop.Web.MVC.Controllers
{
    public class TransactionController : Controller
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Pet> _petRepo;
        private readonly IEntityRepo<PetFood> _petFoodRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo,
            IEntityRepo<Employee> employeeRepo, IEntityRepo<Pet> petRepo, IEntityRepo<PetFood> petFoodRepo)
        {

            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _employeeRepo = employeeRepo;
            _petRepo = petRepo;
            _petFoodRepo = petFoodRepo;
        }

        // GET: TransactionController
        public ActionResult Index()
        {
            var transactions = _transactionRepo.GetAll();
            return View(model: transactions);
        }

        // GET: TransactionController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = _transactionRepo.GetById(id.Value);
            if (transaction == null)
            {
                return NotFound();
            }

            var viewtransaction = new TransactionDetailsDto
            {
                Id = id.Value,
                Date = transaction.Date,
                PetPrice = transaction.PetPrice,
                PetFoodQty = transaction.PetFoodQty,
                PetFoodPrice = transaction.PetFoodPrice,
                TotalPrice = transaction.TotalPrice,
                CustomerId = transaction.CustomerId,
                EmployeeId = transaction.EmployeeId,
                PetId = transaction.PetId,
                PetFoodId = transaction.PetFoodId,
                //Customers = transaction.Customer,
                //Employees = transaction.Employee,
                //Pets = transaction.Pet,
                //PetFoods = transaction.PetFood,
            };

            return View(model: viewtransaction);
        }

        // GET: TransactionController/Create
        public ActionResult Create()
        {
            var newTransaction = GetDataForCreateCombo();
            return View(model: newTransaction);
        }

        // POST: TransactionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionCreateDto transaction)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var customer = _customerRepo.GetById(transaction.CustomerId);
            var pet = _petRepo.GetById(transaction.PetId);
            var employee = _employeeRepo.GetById(transaction.EmployeeId);
            var petFood = _petFoodRepo.GetById(transaction.PetFoodId);
            var date = transaction.Date;
            var petfoodprice = transaction.PetFoodPrice;
            var petFoodQty = transaction.PetFoodQty;
            var petprice = transaction.PetPrice;
            decimal totalPrice;

            if (pet.AnimalType != 0)
            {
                totalPrice = pet.Price + petFoodQty * petFood.Price;
                petFoodQty++;
            }
            else
            {
                totalPrice = petFoodQty * petFood.Price;
            }

            var dbTransaction = new Transaction((DateTime)transaction.Date,
                pet.Price, petFoodQty, petFood.Price,
                totalPrice, transaction.CustomerId,
                transaction.EmployeeId, transaction.PetId, transaction.PetFoodId
                );

            _transactionRepo.Add(dbTransaction);
            return RedirectToAction("Index");
        }

        // GET: TransactionController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null)
            {
                return NotFound();
            }

            var viewtransaction = new TransactionEditDto();
            {
                viewtransaction.Date = dbTransaction.Date;
                viewtransaction.PetPrice = dbTransaction.PetPrice;
                viewtransaction.PetFoodQty = dbTransaction.PetFoodQty;
                viewtransaction.PetFoodPrice = dbTransaction.PetFoodPrice;
                viewtransaction.TotalPrice = dbTransaction.TotalPrice;
                viewtransaction.CustomerId = dbTransaction.CustomerId;
                viewtransaction.EmployeeId = dbTransaction.EmployeeId;
                viewtransaction.PetId = dbTransaction.PetId;
                viewtransaction.PetFoodId = dbTransaction.PetFoodId;
            };
            return View(model: viewtransaction);
        }

        // POST: TransactionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionEditDto transaction)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null)
            {
                return NotFound();
            }


            var pet = _petRepo.GetById(transaction.PetId);
            var petFood = _petFoodRepo.GetById(transaction.PetFoodId);
            var petFoodQty = transaction.PetFoodQty;
            decimal totalPrice;

            if ((pet.AnimalType != 0) && (transaction.PetFoodQty != transaction.PetFoodQty))
            {
                totalPrice = pet.Price + petFoodQty * petFood.Price;
                petFoodQty++;
            }
            else
            {
                totalPrice = petFoodQty * petFood.Price;
            }

#pragma warning disable CS8629 // Nullable value type may be null.
            dbTransaction.Date = (DateTime)transaction.Date;
#pragma warning restore CS8629 // Nullable value type may be null.
            dbTransaction.PetPrice = transaction.PetPrice;
            dbTransaction.PetFoodQty = transaction.PetFoodQty;
            dbTransaction.PetFoodPrice = transaction.PetFoodPrice;
            dbTransaction.TotalPrice = transaction.TotalPrice;
            dbTransaction.CustomerId = transaction.CustomerId;
            dbTransaction.EmployeeId = transaction.EmployeeId;
            dbTransaction.PetId = transaction.PetId;
            dbTransaction.PetFoodId = transaction.PetFoodId;
            _transactionRepo.Update(id, dbTransaction);
            return RedirectToAction(nameof(Index));

        }

        // GET: TransactionController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null)
            {
                return NotFound();
            }

            var viewtransaction = new TransactionDeleteDto
            {
                Date = dbTransaction.Date,
                PetPrice = dbTransaction.PetPrice,
                PetFoodQty = dbTransaction.PetFoodQty,
                PetFoodPrice = dbTransaction.PetFoodPrice,
                TotalPrice = dbTransaction.TotalPrice,
                CustomerId = dbTransaction.CustomerId,
                EmployeeId = dbTransaction.EmployeeId,
                PetId = dbTransaction.PetId,
                PetFoodId = dbTransaction.PetFoodId,
            };

            //viewtransaction.Customers = _customerRepo.GetById(viewtransaction.CustomerId);
            //viewtransaction.Employees = _employeeRepo.GetById(viewtransaction.EmployeeId);
            //viewtransaction.Pets = _petRepo.GetById(viewtransaction.PetId);
            //viewtransaction.PetFoods = _petFoodRepo.GetById(viewtransaction.PetFoodId);

            return View(model: viewtransaction);
        }

        // POST: TransactionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _transactionRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        public TransactionCreateDto GetDataForCreateCombo()
        {
            var transaction = new TransactionCreateDto();
            var customers = _customerRepo.GetAll();
            var employees = _employeeRepo.GetAll();
            var pets = _petRepo.GetAll().Where(pet => pet.PetStatus != PetStatus.Unhealthy);
            var petFoods = _petFoodRepo.GetAll();

            foreach (var customer in customers)
            {
                transaction.Customers.Add(new SelectListItem(customer.Surname + " " + customer.Name, customer.Id.ToString()));
            }
            foreach (var employee in employees)
            {
                transaction.Employees.Add(new SelectListItem(employee.Surname + " " + employee.Name, employee.Id.ToString()));
            }
            foreach (var pet in pets)
            {
                transaction.Pets.Add(new SelectListItem(pet.Breed + ", " + pet.AnimalType + " - " + pet.Price + "€", pet.Id.ToString()));
            }
            foreach (var petFood in petFoods)
            {
                transaction.PetFoods.Add(new SelectListItem(petFood.AnimalType.ToString() + " - " + petFood.Price + "€", petFood.Id.ToString()));
            }

            return transaction;
        }
    }
}
