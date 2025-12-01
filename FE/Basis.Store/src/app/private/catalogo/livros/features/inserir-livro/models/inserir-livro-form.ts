import { FormControl } from "@angular/forms";

export interface InserirLivroForm {
  titulo: FormControl<string>;
  editora: FormControl<string>;
  edicao: FormControl<number>;
  anoPublicacao: FormControl<number>;
  precoBase: FormControl<number>;

  codigosAutores: FormControl<number[]>;
  codigosAssuntos: FormControl<number[]>;
}