using Fuel.Station.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.EF.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            //Table Name
            builder.ToTable("Employees");

            //Primary Key
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            //Properties
            builder.Property(t => t.Name).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Surname).HasMaxLength(100).IsRequired();
            builder.Property(t => t.SallaryPerMonth).HasPrecision(10, 3).IsRequired();
            builder.Property(t => t.HireDateStart).IsRequired();
            builder.Property(t => t.HireDateEnd).IsRequired();
            builder.Property(t => t.employeeType).IsRequired();
        }
    }
}
