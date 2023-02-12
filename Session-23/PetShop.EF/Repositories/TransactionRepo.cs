using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PetShop.EF.Repositories
{
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        public void Add(Transaction entity)
        {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbPetShop = context.Pets.Where(transaction => transaction.Id == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            context.Remove(dbPetShop);
            context.SaveChanges();
        }

        public IList<Transaction> GetAll()
        {
            using var context = new PetShopDbContext();

            return context.Transactions.Include(transaction => transaction.Customer).Include(transaction => transaction.Employee).
                Include(transaction => transaction.Pet).Include(transaction => transaction.PetFood).ToList();
        }

        public Transaction? GetById(int id)
        {
            using var context = new PetShopDbContext();
            return context.Transactions.Include(transaction => transaction.Customer).Include(transaction => transaction.Employee).
                Include(transaction => transaction.Pet).Include(transaction => transaction.PetFood).
                Where(transaction => transaction.Id == id).SingleOrDefault();
        }

        public void Update(int id, Transaction entity)
        {
            using var context = new PetShopDbContext();
            var dbPetshop = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            dbPetshop.Date= DateTime.Now;
            dbPetshop.PetPrice = entity.PetPrice;
            dbPetshop.PetFoodPrice= entity.PetFoodPrice;
            dbPetshop.PetFoodQty= entity.PetFoodQty;
            dbPetshop.TotalPrice= entity.TotalPrice;
            dbPetshop.CustomerId = entity.CustomerId;
            dbPetshop.EmployeeId = entity.EmployeeId;
            dbPetshop.PetId = entity.PetId;
            dbPetshop.PetFoodId = entity.PetFoodId;

        }
    }
}
