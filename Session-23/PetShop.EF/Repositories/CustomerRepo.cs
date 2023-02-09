using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        public void Add(Customer entity)
        {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var PetShop = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (PetShop is null)
                return;
            context.Remove(PetShop);
            context.SaveChanges();
        }

        public IList<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Customer entity)
        {
            throw new NotImplementedException();
        }

        //public IList<Customer> GetAll()
        //{
        //    using var context = new PetShopDbContext();
        //    return context.Customers.Include(customer => customer./*TodoInfo).Include(customer => customer.TodoComments).*/ToList();
        //}

        //public Customer GetById(int id)
        //{
        //using var context = new PetShopDbContext();
        //return context.Customers.Where(customer => customer.Id == id)
        //    .Include(customer => customer.CustomerInfo)
        //    .Include(customer => customer.CustomerComments).SingleOrDefault();
        //}

        //public void Update(int id, Customer entity)
        //{
        //    using var context = new AppDbContext();
        //    var dbTodo = context.Todos.Where(todo => todo.Id == id).SingleOrDefault();
        //    if (dbTodo is null)
        //        return;
        //    dbTodo.Title = entity.Title;
        //    dbTodo.Finished = entity.Finished;
        //    dbTodo.TodoComments = entity.TodoComments;
        //    dbTodo.TodoInfo = entity.TodoInfo;
        //    context.SaveChanges();
        //}
    }
}
