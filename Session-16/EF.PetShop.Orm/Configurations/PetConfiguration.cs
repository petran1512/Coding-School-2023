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
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("Pet");
            
            builder.HasKey(pet => pet.ID);

            builder.HasKey(pet => pet.TransactionID);

            builder.Property(pet => pet.Breed).HasMaxLength(30);
            
            builder.Property(pet => pet.Price).HasPrecision(5,5);
            
            builder.Property(pet => pet.Cost).HasPrecision(5,5);
            
            builder.Property(pet => pet.Bought).HasMaxLength(25);

            builder.Property(pet => pet.Animaltype).HasMaxLength(10); ;

            builder.Property(pet => pet.Petstatus).HasMaxLength(10);

        }
    }
}
