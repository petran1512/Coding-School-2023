using Fuel.Station.Model;
using FuelStation.EF.Context;
using Microsoft.EntityFrameworkCore;


namespace Fuel.Solution.EF.Repositories {
    public class CustomerRepo : IEntityRepo<Customer> {
        public void Add(Customer entity) {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new FuelStationDbContext();
            var dbCustomer = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (dbCustomer is null)
                return;
            context.Remove(dbCustomer);
            context.SaveChanges();
        }

        public IList<Customer> GetAll() {
            using var context = new FuelStationDbContext();
            return context.Customers
                .Include(customer => customer.Transactions).ToList();
        }

        public Customer? GetById(int id) {
            using var context = new FuelStationDbContext();
            return context.Customers.Where(customer => customer.Id == id)
                .Include(customer => customer.Transactions).SingleOrDefault();
        }

        public void Update(int id, Customer entity) {
            using var context = new FuelStationDbContext();
            var dbCustomer = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (dbCustomer is null)
                return;
            dbCustomer.Name = entity.Name;
            dbCustomer.Surname = entity.Surname;
            dbCustomer.CardNumber = entity.CardNumber;
            dbCustomer.Transactions = entity.Transactions;
            context.SaveChanges();
        }


    }
}
