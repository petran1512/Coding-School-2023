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
    internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");

            builder.HasKey(transaction => transaction.ID);

            builder.Property(transaction => transaction.Date).HasMaxLength(15);

            builder.Property(transaction => transaction.CustomerID).HasMaxLength(50);

            builder.Property(transaction => transaction.EmployeeID).HasMaxLength(50);

            builder.Property(transaction => transaction.PetID).HasMaxLength(50);

            builder.Property(transaction => transaction.PetFoodID).HasMaxLength(50);

            builder.Property(transaction => transaction.PetPrice).HasPrecision(5);

            builder.Property(transaction => transaction.PetFoodQty).HasPrecision(5);

            builder.Property(transaction => transaction.PetFoodPrice).HasPrecision(5);

            builder.Property(transaction => transaction.TotalPrice).HasPrecision(5);

        }
    }
}
