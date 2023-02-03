using Microsoft.EntityFrameworkCore;
using ClassLibrary1;
using EF.PetShop.Orm.Configuration;
using EF.PetShop.Orm.Configurations;

namespace EF.Course.Orm.AppDBContext
{
    public class AppDBContext : DbContext
    {

        public DbSet<Customer> Cutomers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());

            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());




        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PetShopDb;Integrated Security=True; Connect" +
                " Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}