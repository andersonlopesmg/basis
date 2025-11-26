namespace Basis.Store.Infrastructure.Entities.Catalogo
{
    public class LivroAutorDbModel
    {
        #region Chaves estrangeiras
        
        public int LivroId { get; set; }
        public int AutorId { get; set; }

        #endregion

        #region Propriedades de navegação
        public LivroDbModel Livro { get; set; } = null!;
        public AutorDbModel Autor { get; set; } = null!;
        #endregion
    }
}
