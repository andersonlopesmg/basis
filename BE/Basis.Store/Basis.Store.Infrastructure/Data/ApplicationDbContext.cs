using Basis.Store.Infrastructure.Data.Seeds;
using Basis.Store.Infrastructure.Entities.Catalogo;
using Basis.Store.Infrastructure.Entities.Catalogo.Views;
using Microsoft.EntityFrameworkCore;

namespace Basis.Store.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<AssuntoDbModel> Assunto { get; set; }
        public DbSet<AutorDbModel> Autor { get; set; }
        public DbSet<LivroAssuntoDbModel> LivroAssunto { get; set; }
        public DbSet<LivroAutorDbModel> LivroAutor { get; set; }
        public DbSet<LivroDbModel> Livro { get; set; }

        public DbSet<LivrosPorAutorViewModel> LivrosPorAutorViewModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            CargaInicialGenerator.Seed(modelBuilder);
        }
    }
}
