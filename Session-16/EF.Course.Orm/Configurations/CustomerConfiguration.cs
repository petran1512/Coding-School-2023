using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Course.Orm.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<CustomerConfiguration>
    {
        public void Configure(EntityTypeBuilder<CustomerConfiguration> builder)
        {
            builder.ToTable("Customer");

            //builder.Property(customer => customer.Phone).HasMaxLength(10).IsRequired(true);

            //builder.HasKey(customer => customer.TIN);
        }
    }
}

