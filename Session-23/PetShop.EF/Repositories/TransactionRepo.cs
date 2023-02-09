//using PetShop.EF.Context;
//using PetShop.Model;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PetShop.EF.Repositories
//{
//    internal class TransactionRepo : IEntityRepo<Transaction>
//    {
//        public void Add(Transaction entity)
//        {
//            using var context = new PetShopDbContext();
//            context.Add(entity);
//            context.SaveChanges();
//        }

//        public void Delete(int id)
//        {
//            using var context = new PetShopDbContext();
//            var dbPetShop = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
//            if (dbPetShop is null)
//                return;
//            context.Remove(dbPetShop);
//            context.SaveChanges();
//        }

//        public IEnumerable<Transaction> GetAll()
//        {
//            throw new NotImplementedException();
//        }

//        public Transaction GetById(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(int id, Transaction entity)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
