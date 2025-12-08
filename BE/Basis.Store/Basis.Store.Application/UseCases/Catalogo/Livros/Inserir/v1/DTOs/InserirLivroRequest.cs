namespace Basis.Store.Application.UseCases.Catalogo.Livros.Inserir.v1.DTOs
{
    public record InserirLivroRequest
    {
        public string Titulo { get; set; } = null!;
        public string Editora { get; set; } = null!;
        public int Edicao { get; set; }
        public int AnoPublicacao { get; set; }
        public decimal PrecoBaseVenda { get; set; }

        public List<int> Autores { get; set; } = [];
        public List<int> Assuntos { get; set; } = [];

    }
}