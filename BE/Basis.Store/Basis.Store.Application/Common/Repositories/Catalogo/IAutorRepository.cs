using Basis.Store.Domain.Catalogo.Entities;

namespace Basis.Store.Application.Common.Repositories.Catalogo
{
    public interface IAutorRepository
    {
        Task<Autor?> DetalharPorIdAsync(int autorId);
    }
}
