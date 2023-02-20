using Fuel.Station.Model;
using FuelStation.EF.Context;
using FuelStation.EF.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Fuel.Solution.EF.Repositories
{
    internal class TransactionRepo : IEntityRepo<Transaction>
    {
        public void Add(Transaction entity)
        {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new FuelStationDbContext();
            var dbTransaction = context.Transactions.Where(t => t.Id == id).SingleOrDefault();
            if (dbTransaction == null)
            {
                throw new Exception($"Transaction with id: {id} not found");
            }
            context.Remove(dbTransaction);
            context.SaveChanges();
        }

        public IList<Transaction> GetAll()
        {
            using var context = new FuelStationDbContext();
            var t = context.Transactions.
                Include(t => t.TransactionLines)
               .Include(t => t.Customer)
               .Include(t => t.Employee)
               .ToList();

            return (IList<Transaction>)t;
        }

        public Transaction? GetById(int id)
        {
            using var context = new FuelStationDbContext();
            return context.Transactions
                .Where(t => t.Id == id)
                .Include(t => t.TransactionLines)
                .Include(t => t.Customer)
                .Include(t => t.Employee)
                .SingleOrDefault();
        }

        public void Update(int id, Transaction entity)
        {
            using var context = new FuelStationDbContext();
            var dbTransaction = context.Transactions.Where(t => t.Id == id)
                .Include(t => t.TransactionLines).SingleOrDefault();
            if (dbTransaction == null)
            {
                throw new Exception($"Transaction with id: {id} not found");
            }
            dbTransaction.Date = entity.Date;
            dbTransaction.TotalValue = entity.TotalValue;
            dbTransaction.PaymentMethod = entity.PaymentMethod;
            dbTransaction.CustomerId = entity.CustomerId;
            dbTransaction.EmployeeId = entity.EmployeeId;
            dbTransaction.TransactionLines = entity.TransactionLines;
            context.SaveChanges();
        }
    }
}
