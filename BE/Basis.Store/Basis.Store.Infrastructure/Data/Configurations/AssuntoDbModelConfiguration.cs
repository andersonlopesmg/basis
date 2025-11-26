using Basis.Store.Infrastructure.Entities.Catalogo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Basis.Store.Infrastructure.Data.Configurations
{
    public class AssuntoDbModelConfiguration : IEntityTypeConfiguration<AssuntoDbModel>
    {
        public void Configure(EntityTypeBuilder<AssuntoDbModel> builder)
        {
            builder.ToTable("Assunto");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("CodAs");

            builder.Property(x => x.Descricao)
                .HasColumnType("VARCHAR(20)")
                .IsRequired();
        }
    }
}
