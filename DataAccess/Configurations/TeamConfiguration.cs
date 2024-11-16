using Entities.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("Teams");

            builder.Property(x => x.Fullname)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.PhotoUrl)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.LinkedinLink)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.FacebookLink)
                .IsRequired()
                .HasMaxLength(200);

            builder.HasOne(x => x.Position)
                .WithMany(x => x.Teams)
                .HasForeignKey(x => x.PositionId);

            builder.HasIndex(x => x.Fullname);

            builder.HasIndex(x => new { x.Fullname, x.Deleted })
                .IsUnique();
        }
    }
}
