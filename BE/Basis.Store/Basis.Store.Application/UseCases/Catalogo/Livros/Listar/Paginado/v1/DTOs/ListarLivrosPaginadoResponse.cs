namespace Basis.Store.Application.UseCases.Catalogo.Livros.Listar.Paginado.v1.DTOs
{
    public record ListarLivrosPaginadoResponse
    {
        public int Id { get; init; }
        public required string Titulo { get; init; }
        public required string Editora { get; init; }
        public int Edicao { get; init; }
        public int AnoPublicacao { get; init; }
        public required decimal PrecoBaseVenda { get; init; }
    }
}
