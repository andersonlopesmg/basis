namespace Basis.Store.Domain.Catalogo.ValueObjects
{
    public record Titulo
    {
        public string Valor { get; init; }

        public Titulo(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException("O título não pode ser vazio.", nameof(valor));
            }
            if (valor.Length > 100)
            {
                throw new ArgumentException("O título não pode exceder 100 caracteres.", nameof(valor));
            }

            Valor = valor;
        }
        public static implicit operator string(Titulo titulo) => titulo.Valor;
        public static implicit operator Titulo(string valor) => new Titulo(valor);
    }
}
