namespace Basis.Store.Infrastructure.Entities.Catalogo
{
    public class AssuntoDbModel
    {
        public int Id { get; set; }
        public required string Descricao { get; set; }

        #region Propriedades de navegação
        public ICollection<LivroAssuntoDbModel> LivroAssuntos { get; set; } = new List<LivroAssuntoDbModel>();
        #endregion
    }
}
