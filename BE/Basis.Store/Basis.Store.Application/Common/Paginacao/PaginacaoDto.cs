namespace Basis.Store.Application.Common.Paginacao
{
    public record PaginacaoDto
    {
        public int Pagina { get; set; } = 1;
        public int TamanhoDaPagina { get; set; } = 10;
        public string? ColunaOrdenacao { get; set; }
        public OrientacaoOrdenacaoConst Orientacao { get; set; } = OrientacaoOrdenacaoConst.Asc;
    }
}
