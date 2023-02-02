using Microsoft.EntityFrameworkCore;
using EF.Course.Model;
using EF.Course.Orm.TodoConfigurations;
using System.Collections.Generic;
using System.Reflection.Emit;
using EF.Course.Orm.CustomerConfigurations;
using ClassLibrary1;

namespace EF.Course.Orm.AppContext
{
    public class AppContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public DbSet<Customer> Cutomers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TodoConfiguration());
            

            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            base.OnModelCreating(modelBuilder);


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TodoDb;Integrated Security=True; Connect" +
                " Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}