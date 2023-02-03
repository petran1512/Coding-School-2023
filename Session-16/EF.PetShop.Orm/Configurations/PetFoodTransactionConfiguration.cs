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
    public class PetFoodTransactionConfiguration : IEntityTypeConfiguration<PetFoodTransaction>
    {
        public void Configure(EntityTypeBuilder<PetFoodTransaction> builder)
        {
            builder.ToTable("PetFoodTransaction");

            builder.HasKey(petfoodtransaction => petfoodtransaction.ID);

            builder.Property(petfoodtransaction => petfoodtransaction.ID).HasMaxLength(30).IsRequired(true);

            builder.Property(petfoodtransaction => petfoodtransaction.Qty).HasPrecision(5, 5);

            builder.Property(petfoodtransaction => petfoodtransaction.Date).HasMaxLength(10);
        }
    }
}
