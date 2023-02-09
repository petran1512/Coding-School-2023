using PetShop.EF.Context;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{
    internal class PetRepo : IEntityRepo<Pet>
    {
        public void Add(Pet entity)
        {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbPetShop = context.Pets.Where(pet => pet.Id == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            context.Remove(dbPetShop);
            context.SaveChanges();
        }

        public IList<Pet> GetAll()
        {
            using var context = new PetShopDbContext();
            return context.Pets.ToList();
        }

        public Pet GetById(int id)
        {
            using var context = new PetShopDbContext();
            return context.Pets.Where(pet => pet.Id == id).SingleOrDefault();
        }

        public void Update(int id, Pet entity)
        {
            throw new NotImplementedException();
        }
    }
}
