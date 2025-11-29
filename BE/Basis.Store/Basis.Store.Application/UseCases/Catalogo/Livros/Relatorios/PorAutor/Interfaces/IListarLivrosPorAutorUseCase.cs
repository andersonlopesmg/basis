using Basis.Store.Application.UseCases.Catalogo.Livros.Relatorios.PorAutor.DTOs;

namespace Basis.Store.Application.UseCases.Catalogo.Livros.Relatorios.PorAutor.Interfaces
{
    public interface IListarLivrosPorAutorUseCase
    {
        Task<ListarLivrosPorAutorResponse> Execute();
    }
}
