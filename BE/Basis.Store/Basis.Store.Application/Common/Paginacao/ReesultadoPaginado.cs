namespace Basis.Store.Application.Common.Paginacao
{
    public record ResultadoPaginado<T>
    {
        public IEnumerable<T> Itens { get; init; } = new List<T>();
        public int TotalDeItens { get; init; }
        public int PaginaAtual { get; init; }
        public int TotalDePaginas => (int)Math.Ceiling((double)TotalDeItens / TamanhoDaPagina);
        public int TamanhoDaPagina { get; init; }

        public ResultadoPaginado(IEnumerable<T> itens, int totalDeItens, int paginaAtual, int tamanhoDaPagina)
        {

            Itens = itens;
            TotalDeItens = totalDeItens;
            PaginaAtual = paginaAtual;
            TamanhoDaPagina = tamanhoDaPagina;
        }
    }
}
