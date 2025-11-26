namespace Basis.Store.Infrastructure.Entities.Catalogo
{
    public class AutorDbModel
    {
        public int Id { get; set; }
        public required string Nome { get; set; }

        #region Propriedades de navegação
        public ICollection<LivroAutorDbModel> LivroAutores { get; set; } = new List<LivroAutorDbModel>();
        #endregion
    }
}
