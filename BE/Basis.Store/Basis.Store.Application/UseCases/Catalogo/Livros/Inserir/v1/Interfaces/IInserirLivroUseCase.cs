using Basis.Store.Application.UseCases.Catalogo.Livros.Inserir.v1.DTOs;

namespace Basis.Store.Application.UseCases.Catalogo.Livros.Inserir.v1.Interfaces
{
    public interface IInserirLivroUseCase
    {
        Task<int> Execute(InserirLivroRequest request);
    }
}
