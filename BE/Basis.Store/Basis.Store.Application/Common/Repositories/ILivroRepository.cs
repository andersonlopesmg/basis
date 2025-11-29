using Basis.Store.Application.Common.Paginacao;
using Basis.Store.Application.UseCases.Catalogo.Livros.Listar;
using Basis.Store.Application.UseCases.Catalogo.Livros.Relatorios.PorAutor.DTOs;
using Basis.Store.Domain.Catalogo.Entities;

namespace Basis.Store.Application.Common.Repositories
{
    public interface ILivroRepository
    {
        Task AdicionarAsync(Livro livro);

        Task AtualizarAsync(Livro livro);

        Task<ResultadoPaginado<Livro>> ConsultarPaginado(LivroFilter livroFilter, PaginacaoDto paginacao);
        
        Task<Livro?> DetalharPorIdAsync(int id);

        Task<List<Livro>> ListarAsync();

        Task<List<LivrosPorAutorDto>> ListarLivrosPorAutor();
    }
}
