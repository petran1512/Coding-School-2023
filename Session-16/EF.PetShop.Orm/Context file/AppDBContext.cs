using EF.Course.Orm.CustomerConfigurations;
using Microsoft.EntityFrameworkCore;
using ClassLibrary1;

namespace EF.Course.Orm.AppDBContext
{
    public class AppDBContext : DbContext
    {

        public DbSet<Customer> Cutomers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            base.OnModelCreating(modelBuilder);


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PetShopDb;Integrated Security=True; Connect" +
                " Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}