using Basis.Store.Domain.Common;

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
                throw new BusinessValidationException("A descrição do assunto não pode ser vazia");
            }
            if (descricao.Length > 100)
            {
                throw new BusinessValidationException("A descrição do assunto não pode exceder 100 caracteres");
            }


            return new Assunto
            {
                Descricao = descricao.Trim()
            };
        }
    }
}
