namespace Basis.Store.Domain.Catalogo.Entities
{
    public class Assunto
    {

        public string Descricao { get; private set; } = string.Empty;

        private Assunto()
        {
        }
        

        public static Assunto Criar(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                throw new ArgumentException("A descrição do assunto não pode ser vazia.", nameof(descricao));
            }
            if (descricao.Length > 100)
            {
                throw new ArgumentException("A descrição do assunto não pode exceder 100 caracteres.", nameof(descricao));
            }


            return new Assunto
            {
                Descricao = descricao.Trim()
            };
        }
    }
}
