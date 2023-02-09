using PetShop.EF.Context;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{
    internal class PetFoodRepo : IEntityRepo<PetFood>
    {
        public void Add(PetFood entity)
        {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbPetShop = context.PetFoods.Where(petfood => petfood.Id == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            context.Remove(dbPetShop);
            context.SaveChanges();
        }

        public IList<PetFood> GetAll()
        {
            using var context = new PetShopDbContext();
            return context.PetFoods.ToList();
        }

        public PetFood GetById(int id)
        {
            using var context = new PetShopDbContext();
            return context.PetFoods.Where(petfood => petfood.Id == id).SingleOrDefault();
        }

        public void Update(int id, PetFood entity)
        {
            throw new NotImplementedException();
        }
    }
}
