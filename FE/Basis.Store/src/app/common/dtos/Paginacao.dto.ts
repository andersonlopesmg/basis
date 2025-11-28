export interface PaginacaoDto {
    pagina: number;
    tamanhoDaPagina: number;
    colunaOrdenacao?: string;
    orientacao?: string;
}