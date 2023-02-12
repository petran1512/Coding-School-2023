using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Web.MVC.Models.Employee;
using PetShop.Web.MVC.Models.Pet;
using PetShop.Web.MVC.Models.PetFood;

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
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var petfood = _petfoodRepo.GetById(id.Value);
            if (petfood == null)
            {
                return NotFound();
            }

            var viewpetfood = new PetFoodDetailsDto
            {
                Id = id.Value,
                AnimalType = petfood.AnimalType,
                Price = petfood.Price,
                Cost = petfood.Cost
            };
            return View(model: viewpetfood);
        }

        // GET: PetFoodController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetFoodController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PetFoodCreateDto petfood)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbPetFood = new PetFood(petfood.AnimalType,petfood.Price,petfood.Cost);
            _petfoodRepo.Add(dbPetFood);
            return RedirectToAction("Index");
        }

        // GET: PetFoodController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbPetFood = _petfoodRepo.GetById(id);
            if (dbPetFood == null)
            {
                return NotFound();
            }

            var viewpetfood = new PetFoodEditDto();
            {
                viewpetfood.AnimalType = dbPetFood.AnimalType;
                viewpetfood.Price = dbPetFood.Price;
                viewpetfood.Cost = dbPetFood.Cost;
            };
            return View(model: viewpetfood);
        }

        // POST: PetFoodController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PetFoodEditDto petfood)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbPetFood = _petfoodRepo.GetById(id);
            if (dbPetFood == null)
            {
                return NotFound();
            }
            dbPetFood.AnimalType = petfood.AnimalType;
            dbPetFood.Price = petfood.Price;
            dbPetFood.Cost = petfood.Cost;
            _petfoodRepo.Update(id, dbPetFood);
            return RedirectToAction(nameof(Index));
        }

        // GET: PetFoodController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbPetFood = _petfoodRepo.GetById(id);
            if (dbPetFood == null)
            {
                return NotFound();
            }

            var viewpetfood = new PetFoodDeleteDto
            {
                AnimalType = dbPetFood.AnimalType,
                Price = dbPetFood.Price,
                Cost = dbPetFood.Cost,
            };
            return View(model: viewpetfood);
        }

        // POST: PetFoodController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _petfoodRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
