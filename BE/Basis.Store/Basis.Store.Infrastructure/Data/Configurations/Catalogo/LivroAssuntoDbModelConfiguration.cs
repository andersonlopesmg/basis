using Basis.Store.Infrastructure.Entities.Catalogo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Basis.Store.Infrastructure.Data.Configurations.Catalogo
{
    public class LivroAssuntoDbModelConfiguration : IEntityTypeConfiguration<LivroAssuntoDbModel>
    {
        public void Configure(EntityTypeBuilder<LivroAssuntoDbModel> builder)
        {
            builder.ToTable("Livro_Assunto");

            builder.HasKey(x => new { x.LivroId, x.AssuntoId });

            builder.HasOne(x => x.Livro)
                   .WithMany(x => x.LivroAssuntos)
                   .HasForeignKey(x => x.LivroId);
        }
    }
}
