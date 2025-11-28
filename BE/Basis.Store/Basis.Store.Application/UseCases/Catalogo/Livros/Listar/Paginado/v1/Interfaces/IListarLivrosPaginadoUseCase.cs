using Basis.Store.Application.Common.Paginacao;
using Basis.Store.Application.UseCases.Catalogo.Livros.Listar.Paginado.v1.DTOs;

namespace Basis.Store.Application.UseCases.Catalogo.Livros.Listar.Paginado.v1.Interfaces
{
    public interface IListarLivrosPaginadoUseCase
    {
        Task<ResultadoPaginado<ListarLivrosPaginadoResponse>> Executar(ListarLivrosPaginadoRequest request); 
    }
}
