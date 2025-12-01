export interface InserirLivroRequest {
    titulo: string;
    editora: string;
    edicao: number;
    anoPublicacao: number;
    precoBase: number;

    codigosAutores: number[];
    codigosAssuntos: number[];
}
