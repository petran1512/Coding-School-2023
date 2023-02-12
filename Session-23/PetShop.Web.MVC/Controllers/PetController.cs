using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetShop.EF.Repositories;
using PetShop.Model;
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
            var viewpet = new PetDetailsDto();
            viewpet.Breed = pet.Breed;
            viewpet.AnimalType = pet.AnimalType;
            viewpet.PetStatus = pet.PetStatus;
            viewpet.Price = pet.Price;
            viewpet.Cost = pet.Cost;
            return View(model: viewpet);
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
            var dbPet = _petRepo.GetById(id);
            if (dbPet == null)
            {
                return NotFound();
            }

            var viewpet = new PetEditDto();
            {
                viewpet.Breed = dbPet.Breed;
                viewpet.AnimalType = dbPet.AnimalType;
                viewpet.PetStatus = dbPet.PetStatus;
                viewpet.Price = dbPet.Price;
                viewpet.Cost = dbPet.Cost;
            };
            return View(model: viewpet);
        }

        // POST: PetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PetEditDto pet)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbPet = _petRepo.GetById(id);
            if (dbPet == null)
            {
                return NotFound();
            }
            dbPet.Breed = pet.Breed;
            dbPet.AnimalType = pet.AnimalType;
            dbPet.PetStatus = pet.PetStatus;
            dbPet.Price = pet.Price;
            dbPet.Cost = pet.Cost;
            _petRepo.Update(id, dbPet);
            return RedirectToAction(nameof(Index));
        }

        // GET: PetController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbPet = _petRepo.GetById(id);
            if (dbPet == null)
            {
                return NotFound();
            }

            var viewpet = new PetDeleteDto
            {
                Breed = dbPet.Breed,
                AnimalType = dbPet.AnimalType,
                PetStatus = dbPet.PetStatus,
                Price = dbPet.Price,
                Cost = dbPet.Cost,
            };
            return View(model: viewpet);
        }

        // POST: PetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _petRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
