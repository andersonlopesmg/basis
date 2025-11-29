using Basis.Store.Infrastructure.Entities.Catalogo.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Basis.Store.Infrastructure.Data.Configurations.Catalogo.Views
{
    public class LivrosPorAutorViewModelConfiguration : IEntityTypeConfiguration<LivrosPorAutorViewModel>
    {
        public void Configure(EntityTypeBuilder<LivrosPorAutorViewModel> builder)
        {
            builder.HasNoKey();
            builder.ToView("vw_LivrosPorAutor");
        }
    }
}
