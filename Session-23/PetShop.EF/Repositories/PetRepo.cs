using PetShop.EF.Context;
using PetShop.Model;
using PetShop.Model.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            using var context = new PetShopDbContext();
            var dbPetshop = context.Pets.Where(pet => pet.Id == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            dbPetshop.AnimalType = entity.AnimalType;
            dbPetshop.Breed= entity.Breed;
            dbPetshop.PetStatus= entity.PetStatus;
            dbPetshop.Price= entity.Price;
            dbPetshop.Cost= entity.Cost;
            context.SaveChanges();
        }
    }
}
