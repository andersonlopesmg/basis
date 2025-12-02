using Basis.Store.Domain.Catalogo.Entities;

namespace Basis.Store.Application.Common.Repositories.Catalogo
{
    public interface IAssuntoRepository
    {
        Task<Assunto?> DetalharPorIdAsync(int assuntoId);
    }
}
