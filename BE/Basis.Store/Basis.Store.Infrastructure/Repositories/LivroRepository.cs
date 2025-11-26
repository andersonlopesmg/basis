using Basis.Store.Application.Common.Repositories;
using Basis.Store.Domain.Catalogo.Entities;
using Basis.Store.Infrastructure.Data;

namespace Basis.Store.Infrastructure.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public LivroRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }


        public Task AdicionarAsync(Livro livro)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarAsync(Livro livro)
        {
            throw new NotImplementedException();
        }

        public Task<Livro?> DetalharPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Livro>> ListarAsync()
        {
            throw new NotImplementedException();
        }
    }
}
