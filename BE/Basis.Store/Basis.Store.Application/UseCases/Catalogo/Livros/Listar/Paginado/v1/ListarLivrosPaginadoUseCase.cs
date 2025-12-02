using Basis.Store.Application.Common.Paginacao;
using Basis.Store.Application.Common.Repositories.Catalogo;
using Basis.Store.Application.UseCases.Catalogo.Livros.Listar.Paginado.v1.DTOs;
using Basis.Store.Application.UseCases.Catalogo.Livros.Listar.Paginado.v1.Interfaces;

namespace Basis.Store.Application.UseCases.Catalogo.Livros.Listar.Paginado.v1
{
    public class ListarLivrosPaginadoUseCase : IListarLivrosPaginadoUseCase
    {
        private readonly ILivroRepository repository;

        public ListarLivrosPaginadoUseCase(ILivroRepository repository)
        {
            this.repository = repository;
        }

        public async Task<ResultadoPaginado<ListarLivrosPaginadoResponse>> Executar(ListarLivrosPaginadoRequest request)
        {
            var livros = await repository.ConsultarPaginado(request.Filtro, request.Paginacao);

            var response = livros.Itens.Select(livro => new ListarLivrosPaginadoResponse
            {
                AnoPublicacao = livro.AnoPublicacao,
                Edicao = livro.Edicao,
                Editora = livro.Editora,
                Id = livro.Id.Value,
                PrecoBaseVenda = livro.PrecoBaseVenda,
                Titulo = livro.Titulo.Valor,
            }).ToList();

            return new ResultadoPaginado<ListarLivrosPaginadoResponse>(response, livros.TotalDeItens, livros.PaginaAtual, livros.TamanhoDaPagina);
        }
    }
}
