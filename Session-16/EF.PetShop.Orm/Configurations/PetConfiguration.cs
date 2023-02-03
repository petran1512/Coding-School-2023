using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace EF.PetShop.Orm.Configurations
{
    internal class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("Pet");
            
            builder.HasKey(transaction => transaction.ID);

            builder.HasKey(transaction => transaction.TransactionID);

            builder.Property(transaction => transaction.Breed).HasMaxLength(30);
            
            builder.Property(transaction => transaction.Price).HasPrecision(5,5);
            
            builder.Property(transaction => transaction.Cost).HasPrecision(5,5);
            
            builder.Property(transaction => transaction.Bought).HasMaxLength(25);

            builder.Property(transaction => transaction.Animaltype).HasMaxLength(10); ;

            builder.Property(transaction => transaction.Petstatus).HasMaxLength(10);

        }
    }
}
