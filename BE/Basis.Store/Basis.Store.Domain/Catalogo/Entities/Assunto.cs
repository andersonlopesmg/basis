using Basis.Store.Domain.Common;

namespace Basis.Store.Domain.Catalogo.Entities
{
    public class Assunto
    {
        public int Codigo { get; private set; }
        public string Descricao { get; private set; } = string.Empty;

        private Assunto(string descricao)
        {
            Descricao = descricao.Trim();
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

            return new Assunto(descricao);
        }

        public static Assunto Restaurar(int codigo, string descricao)
        {
            if (codigo <= 0)
            {
                throw new BusinessValidationException("Código do assunto é inválido");
            }

            var assunto = new Assunto(descricao);
            assunto.Codigo = codigo;

            return assunto;
        }
    }
}
