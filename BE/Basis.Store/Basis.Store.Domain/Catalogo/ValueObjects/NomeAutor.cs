using Basis.Store.Domain.Common;

namespace Basis.Store.Domain.Catalogo.ValueObjects
{
    public record NomeAutor
    {
        public string Valor { get; init; }

        public NomeAutor(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new BusinessValidationException("O nome do autor não pode ser vazio");
            }
            if (valor.Length > 100)
            {
                throw new BusinessValidationException("O nome do autor não pode exceder 100 caracteres");
            }

            Valor = valor.Trim();
        }
    }
}
