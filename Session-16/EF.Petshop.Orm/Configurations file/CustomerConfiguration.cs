using ClassLibrary1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.Course.Orm.CustomerConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasKey(customer => customer.ID);

            builder.Property(customer => customer.Phone).HasMaxLength(10).IsRequired(true);

            builder.HasKey(customer => customer.TIN);
        }
    }
}