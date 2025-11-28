using Basis.Store.Application.Common.Paginacao;

namespace Basis.Store.Application.UseCases.Catalogo.Livros.Listar.Paginado.v1.DTOs
{
    public record ListarLivrosPaginadoRequest
    {
        public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();
        public LivroFilter Filtro { get; set; } = new LivroFilter();
    }
}
