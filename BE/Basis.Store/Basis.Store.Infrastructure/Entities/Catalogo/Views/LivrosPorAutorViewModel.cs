namespace Basis.Store.Infrastructure.Entities.Catalogo.Views
{
    public class LivrosPorAutorViewModel
    {
        public int CodigoAutor { get; set; }
        public string NomeAutor { get; set; } = null!;
        public int CodigoLivro { get; set; }
        public string TituloLivro { get; set; } = null!;
        public string Editora { get; set; } = null!;
        public string AnoPublicacao { get; set; }
        public decimal PrecoBase { get; set; }
        public string Assuntos { get; set; } = null!;
    }
}
