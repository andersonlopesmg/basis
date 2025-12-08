using Basis.Store.Application.Common.Repositories.Catalogo;
using Basis.Store.Domain.Catalogo.Entities;
using Basis.Store.Infrastructure.Data;
using Basis.Store.Infrastructure.Mappers.Catalogo;
using Microsoft.EntityFrameworkCore;

namespace Basis.Store.Infrastructure.Repositories.Catalogo
{
    public class AutorRepository : IAutorRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public AutorRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<Autor?> DetalharPorIdAsync(int autorId)
        {
            var result = await this.applicationDbContext.Autor.Where(x => x.Id == autorId).FirstOrDefaultAsync();

            return result.ToDomain();
            
        }
    }
}
