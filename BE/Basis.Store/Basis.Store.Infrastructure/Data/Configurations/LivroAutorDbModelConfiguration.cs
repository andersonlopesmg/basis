using Basis.Store.Infrastructure.Entities.Catalogo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Basis.Store.Infrastructure.Data.Configurations
{
    public class LivroAutorDbModelConfiguration : IEntityTypeConfiguration<LivroAutorDbModel>
    {
        public void Configure(EntityTypeBuilder<LivroAutorDbModel> builder)
        {
            builder.ToTable("Livro_Autor");

            builder.HasKey(x => new { x.LivroId, x.AutorId });

            builder.HasOne(x => x.Livro)
                   .WithMany(x => x.LivroAutores)
                   .HasForeignKey(x => x.LivroId);
        }
    }
}
