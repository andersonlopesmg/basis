export interface ResultadoPaginado<T> {
    itens: T[];
    totalDeItens: number;
    paginaAtual: number;
    tamanhoDaPagina: number;
    totalDePaginas: number;
}