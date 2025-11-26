using Basis.Store.Domain.Catalogo.Entities;

namespace Basis.Store.Application.Common.Repositories
{
    public interface ILivroRepository
    {
        Task AdicionarAsync(Livro livro);

        Task AtualizarAsync(Livro livro);

        Task<Livro?> DetalharPorIdAsync(int id);

        Task<List<Livro>> ListarAsync();
    }
}
