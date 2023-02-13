using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;
using PetShop.Model;

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
            var dbTransactions = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
            if (dbTransactions is null)
                return;
            context.Remove(dbTransactions);
            context.SaveChanges();
        }

        public IList<Transaction> GetAll()
        {
            using var context = new PetShopDbContext();

            return context.Transactions.Include(customer => customer.Customer).Include(employee => employee.Employee).
                Include(pet => pet.Pet).Include(petFood => petFood.PetFood).ToList();
        }

        public Transaction? GetById(int id)
        {
            using var context = new PetShopDbContext();
            return context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
        }

        public void Update(int id, Transaction entity)
        {
            using var context = new PetShopDbContext();
            var dbPetshop = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            dbPetshop.Date= entity.Date;
            dbPetshop.PetPrice = entity.PetPrice;
            dbPetshop.PetFoodPrice= entity.PetFoodPrice;
            dbPetshop.PetFoodQty= entity.PetFoodQty;
            dbPetshop.TotalPrice= entity.TotalPrice;
            dbPetshop.CustomerId = entity.CustomerId;
            dbPetshop.EmployeeId = entity.EmployeeId;
            dbPetshop.PetId = entity.PetId;
            dbPetshop.PetFoodId = entity.PetFoodId;
            context.SaveChanges();

        }
    }
}
