using Basis.Store.Application.Common.Repositories.Catalogo;
using Basis.Store.Domain.Catalogo.Entities;
using Basis.Store.Infrastructure.Data;
using Basis.Store.Infrastructure.Mappers.Catalogo;
using Microsoft.EntityFrameworkCore;

namespace Basis.Store.Infrastructure.Repositories.Catalogo
{
    public class AssuntoRepository : IAssuntoRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public AssuntoRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<Assunto?> DetalharPorIdAsync(int assuntoId)
        {
            var result = await this.applicationDbContext.Assunto.Where(x => x.Id == assuntoId).FirstOrDefaultAsync();
                
            return result.ToDomain();
        }
    }
}
