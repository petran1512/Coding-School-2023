using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Web.MVC.Models.Customer;
using PetShop.Web.MVC.Models.Employee;
using PetShop.Web.MVC.Models.Pet;

namespace PetShop.Web.MVC.Controllers
{
    public class PetController : Controller
    {
        private readonly IEntityRepo<Pet> _petRepo;
        public PetController(IEntityRepo<Pet> petRepo)
        {
            _petRepo = petRepo;
        }

        // GET: PetController
        public ActionResult Index()
        {
            var pets = _petRepo.GetAll();
            return View(model: pets);
        }

        // GET: PetController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = _petRepo.GetById(id.Value);
            if (pet == null)
            {
                return NotFound();
            }
            return View();
        }

        // GET: PetController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PetCreateDto pet)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbPet = new Pet(pet.Breed, pet.AnimalType, pet.PetStatus, pet.Price, pet.Cost);
            _petRepo.Add(dbPet);
            return RedirectToAction("Index");
        }

        // GET: PetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PetController/Edit/5
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

        // GET: PetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PetController/Delete/5
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
