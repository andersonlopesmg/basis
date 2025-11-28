namespace Basis.Store.Application.UseCases.Catalogo.Livros.Listar
{
    public record LivroFilter
    {
        public string? Titulo { get; set; }
        public string? NomeAutor { get; set; }
    }
}
