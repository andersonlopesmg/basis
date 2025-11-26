using Basis.Store.Domain.Common;

namespace Basis.Store.Domain.Catalogo.ValueObjects
{
    public record Titulo
    {
        public string Valor { get; init; }

        public Titulo(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new BusinessValidationException("O título não pode ser vazio");
            }

            if (valor.Length < 3 && valor.Length > 40)
            {
                throw new BusinessValidationException("O título deve ter entre 3 e 40 caracteres");
            }

            Valor = valor;
        }
        public static implicit operator string(Titulo titulo) => titulo.Valor;
        public static implicit operator Titulo(string valor) => new Titulo(valor);
    }
}
