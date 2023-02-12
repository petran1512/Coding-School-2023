using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Web.MVC.Models.Transaction;
using System.Data.Common;

namespace PetShop.Web.MVC.Controllers
{
    public class TransactionController : Controller
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo)
        {

            _transactionRepo = transactionRepo;
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

            var viewtransaction = new TransactionDetailsDto();
            viewtransaction.Date = transaction.Date;
            viewtransaction.PetPrice = transaction.PetPrice;
            viewtransaction.PetFoodQty = transaction.PetFoodQty;
            viewtransaction.PetFoodPrice = transaction.PetFoodPrice;
            viewtransaction.TotalPrice = transaction.TotalPrice;

            return View(model: viewtransaction);
        }

        // GET: TransactionController/Create
        public ActionResult Create()
        {
            return View();
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
            var dbPetFood = new Transaction(transaction.PetPrice, transaction.PetFoodQty, transaction.PetFoodPrice, transaction.TotalPrice);
            _transactionRepo.Add(dbPetFood);
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
            dbTransaction.Date=dbTransaction.Date;
            dbTransaction.PetPrice = dbTransaction.PetPrice;
            dbTransaction.PetFoodQty = dbTransaction.PetFoodQty;
            dbTransaction.PetFoodPrice = dbTransaction.PetFoodPrice;
            dbTransaction.TotalPrice = dbTransaction.TotalPrice;
            _transactionRepo.Update(id, dbTransaction);
            return RedirectToAction(nameof(Index));

        }

        // GET: TransactionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TransactionController/Delete/5
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
