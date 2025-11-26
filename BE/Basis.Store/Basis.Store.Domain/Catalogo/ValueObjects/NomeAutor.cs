namespace Basis.Store.Domain.Catalogo.ValueObjects
{
    public record NomeAutor
    {
        public string Valor { get; init; }

        public NomeAutor(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException("O nome do autor não pode ser vazio.", nameof(valor));
            }
            if (valor.Length > 100)
            {
                throw new ArgumentException("O nome do autor não pode exceder 100 caracteres.", nameof(valor));
            }

            Valor = valor.Trim();
        }
    }
}
