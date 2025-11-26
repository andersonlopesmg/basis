namespace Basis.Store.Domain.Precificacao.ValueObjects
{
    public record Preco
    {
        public decimal Valor { get; init; }
        public Preco(decimal valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("O preço não pode ser negativo.", nameof(valor));
            }
            Valor = valor;
        }

        public static implicit operator decimal(Preco preco) => preco.Valor;
        public static implicit operator Preco(decimal valor) => new(valor);
    }
}
