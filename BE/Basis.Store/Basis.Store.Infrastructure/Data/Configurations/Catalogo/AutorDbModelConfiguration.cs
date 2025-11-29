using Basis.Store.Infrastructure.Entities.Catalogo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Basis.Store.Infrastructure.Data.Configurations.Catalogo
{
    public class AutorDbModelConfiguration : IEntityTypeConfiguration<AutorDbModel>
    {
        public void Configure(EntityTypeBuilder<AutorDbModel> builder)
        {
            builder.ToTable("Autor");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("CodAu");

            builder.Property(x => x.Nome)
                .HasColumnType("VARCHAR(40)")
                .IsRequired();
        }
    }
}
