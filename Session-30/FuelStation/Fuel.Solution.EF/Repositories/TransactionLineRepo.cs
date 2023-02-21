using Fuel.Station.Model;
using FuelStation.EF.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Solution.EF.Repositories
{
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        public void Add(TransactionLine entity)
        {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new FuelStationDbContext();
            var dbTransactionLine = context.TransactionLines.Where(t => t.Id == id).SingleOrDefault();
            if (dbTransactionLine == null)
            {
                throw new Exception($"Transaction Line with id: {id} not found ");
            }
            context.Remove(dbTransactionLine);
            context.SaveChanges();
        }

        public IList<TransactionLine> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.TransactionLines
                .Include(t => t.Transaction)
                .Include(t => t.Item)
                .ToList();
        }

        public TransactionLine? GetById(int id)
        {
            using var context = new FuelStationDbContext();
            return context.TransactionLines
                .Where(t => t.Id == id)
                .Include(t => t.Transaction)
                .Include(t => t.Item)
                .SingleOrDefault();
        }

        public void Update(int id, TransactionLine entity)
        {
            using var context = new FuelStationDbContext();
            var dbTransactionLine = context.TransactionLines.Where(t => t.Id == id).SingleOrDefault();
            if (dbTransactionLine == null)
            {
                throw new Exception($"TransactionLine with id: {id} not found");
            }
             context.SaveChanges();
        }
    }
}
