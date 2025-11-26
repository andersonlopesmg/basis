namespace Basis.Store.Infrastructure.Entities.Catalogo
{
    public class LivroAssuntoDbModel
    {
        #region Chaves estrangeiras
        public int LivroId { get; set; }
        public int AssuntoId { get; set; }

        #endregion

        #region Propriedades de navegação
        public LivroDbModel Livro { get; set; } = null!;
        public AssuntoDbModel Assunto { get; set; } = null!;
        #endregion
    }
}
