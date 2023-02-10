﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;

namespace PetShop.Web.MVC.Controllers
{
    public class PetFoodController : Controller
    {
        private readonly IEntityRepo<PetFood> _petfoodRepo;
        public PetFoodController(IEntityRepo<PetFood> petfoodRepo)
        {
            _petfoodRepo = petfoodRepo;
        }

        // GET: PetFoodController
        public ActionResult Index()
        {
            var petfoods = _petfoodRepo.GetAll();
            return View(model: petfoods);
        }

        // GET: PetFoodController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PetFoodController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetFoodController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: PetFoodController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PetFoodController/Edit/5
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

        // GET: PetFoodController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PetFoodController/Delete/5
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
