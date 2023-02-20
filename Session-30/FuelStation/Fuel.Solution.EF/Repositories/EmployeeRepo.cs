using Fuel.Station.Model;
using FuelStation.EF.Context;
using FuelStation.EF.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Fuel.Solution.EF.Repositories
{
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        public void Add(Employee entity)
        {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new FuelStationDbContext();
            var dbEmployee = context.Employees.Where(employee => employee.Id == id).SingleOrDefault();
            if (dbEmployee is null)
                return;
            context.Remove(dbEmployee);
            context.SaveChanges();
        }

        public IList<Employee> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.Employees.Include(transactions => transactions.Transactions).ToList();
        }

        public Employee? GetById(int id)
        {
            using var context = new FuelStationDbContext();
            return context.Employees.Where(employee => employee.Id == id)
                .Include(transactions => transactions.Transactions)
                .SingleOrDefault();
        }

        public void Update(int id, Employee entity)
        {
            using var context = new FuelStationDbContext();
            var dbEmployee = context.Employees.Where(employee => employee.Id == id).SingleOrDefault();
            if (dbEmployee is null)
                return;
            dbEmployee.Name = entity.Name;
            dbEmployee.Surname = entity.Surname;
            dbEmployee.SallaryPerMonth = entity.SallaryPerMonth;
            dbEmployee.employeeType = entity.employeeType;
            dbEmployee.HireDateStart = entity.HireDateStart;
            dbEmployee.HireDateEnd = entity.HireDateEnd;
            context.SaveChanges();
        }
    }
}
