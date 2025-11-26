namespace Basis.Store.Infrastructure.Entities.Catalogo
{
    public class LivroDbModel
    {
        public int Id { get; set; }
        public required string Titulo { get; set; }
        public required string Editora { get; set; }
        public int Edicao { get; set; }
        public int AnoPublicacao { get; set; }
        public decimal PrecoBase { get; set; }


        #region Propriedades de navegação 
        public ICollection<LivroAutorDbModel> LivroAutores { get; set; } = new List<LivroAutorDbModel>();
        public ICollection<LivroAssuntoDbModel> LivroAssuntos { get; set; } = new List<LivroAssuntoDbModel>();
        #endregion
    }
}
