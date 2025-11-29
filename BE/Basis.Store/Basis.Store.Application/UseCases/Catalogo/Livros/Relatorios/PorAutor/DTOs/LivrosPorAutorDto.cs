namespace Basis.Store.Application.UseCases.Catalogo.Livros.Relatorios.PorAutor.DTOs
{
    public class LivrosPorAutorDto
    {
        public int CodigoAutor { get; set; }
        public string NomeAutor { get; set; } = null!;
        public int CodigoLivro { get; set; }    
        public string TituloLivro { get; set; } = null!;
        public string Editora { get; set; } = null!;
        public string AnoPublicacao { get; set; } 
        public string PrecoBase { get; set; } = null!;
        public string Assuntos { get; set; } = null!;
    }
}
