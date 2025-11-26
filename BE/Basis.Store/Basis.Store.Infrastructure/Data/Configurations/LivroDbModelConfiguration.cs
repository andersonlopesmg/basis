using Basis.Store.Infrastructure.Entities.Catalogo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Basis.Store.Infrastructure.Data.Configurations
{
    public class LivroDbModelConfiguration : IEntityTypeConfiguration<LivroDbModel>
    {
        public void Configure(EntityTypeBuilder<LivroDbModel> builder)
        {
            builder.ToTable("Livro");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Cod");

            builder.Property(x => x.Titulo)
                .HasColumnType("VARCHAR(40)")
                .IsRequired();

            builder.Property(x => x.Editora)
                .HasColumnType("VARCHAR(40)")
                .IsRequired();

            builder.Property(x => x.AnoPublicacao)
                .HasColumnType("VARCHAR(4)")
                .IsRequired();

            builder.Property(x => x.PrecoBase)
                .HasPrecision(18, 2);
        }
    }
}
