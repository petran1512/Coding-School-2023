using PetShop.EF.Context;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{
    internal class EmployeeRepo : IEntityRepo<Employee>
    {
        public void Add(Employee entity)
        {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbPetShop = context.Employees.Where(employee => employee.Id == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            context.Remove(dbPetShop);
            context.SaveChanges();
        }

        public IList<Employee> GetAll()
        {
            using var context = new PetShopDbContext();
            return context.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            using var context = new PetShopDbContext();
            return context.Employees.Where(employee => employee.Id == id).SingleOrDefault();
        }

        public void Update(int id, Employee entity)
        {
            using var context = new PetShopDbContext();
            var dbPetshop = context.Employees.Where(employee => employee.Id == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            dbPetshop.Name = entity.Name;
            dbPetshop.Surname = entity.Surname;
            dbPetshop.EmployeeType = entity.EmployeeType;
            dbPetshop.SalaryPerMonth = entity.SalaryPerMonth;
            context.SaveChanges();
        }
    }
}
