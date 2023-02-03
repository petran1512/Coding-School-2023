using ClassLibrary1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.PetShop.Orm.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");

            builder.HasKey(employee => employee.ID);

            builder.Property(employee => employee.Name).HasMaxLength(15).IsRequired(true);

            builder.Property(employee => employee.Surname).HasMaxLength(15).IsRequired(true);

            builder.Property(employee => employee.EmpType).HasMaxLength(30);

            builder.Property(employee => employee.SalaryPerMonth).HasMaxLength(10);
        }
    }
}
