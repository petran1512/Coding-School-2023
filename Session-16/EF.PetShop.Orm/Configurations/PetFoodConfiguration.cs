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
    public class PetFoodConfiguration : IEntityTypeConfiguration<PetFood>
    {
        public void Configure(EntityTypeBuilder<PetFood> builder)
        {
            builder.ToTable("PetFood");

            builder.HasKey(petfood => petfood.ID);

            builder.Property(petfood => petfood.Animaltype).HasMaxLength(10);

            builder.Property(petfood => petfood.Price).HasPrecision(5, 5);

            builder.Property(petfood => petfood.Cost).HasPrecision(5, 5);

            builder.Property(petfood => petfood.Qty).HasPrecision(5,5);    

            builder.Property(petfood => petfood.CurrentStock).HasMaxLength(10);

        }


    }
}
