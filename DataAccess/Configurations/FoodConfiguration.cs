using Entities.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.ToTable("Foods");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Tag)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(x => x.Price)
                .IsRequired()
                .HasPrecision(6, 2);

            builder.Property(x => x.PhotoUrl)
                .IsRequired()
                .HasMaxLength(500);


            builder.HasIndex(x => x.Name)
                .HasDatabaseName("idx_Food_Name");

            builder.HasIndex(x => new { x.Name, x.Deleted })
                .IsUnique()
                .HasDatabaseName("Idx_Food_Name_Deleted");
        }
    }
}
