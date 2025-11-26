using Basis.Store.Domain.Shared;

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
            if (valor.Length > 100)
            {
                throw new BusinessValidationException("O título não pode exceder 100 caracteres");
            }

            Valor = valor;
        }
        public static implicit operator string(Titulo titulo) => titulo.Valor;
        public static implicit operator Titulo(string valor) => new Titulo(valor);
    }
}
