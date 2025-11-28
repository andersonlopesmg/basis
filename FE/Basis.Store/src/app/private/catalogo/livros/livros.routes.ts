import { Routes } from '@angular/router';
import { InserirLivro } from './features/inserir-livro/inserir-livro';
import { ListarLivros } from './features/listar-livros/listar-livros';


export const routes: Routes = [
    {
        path: 'inserir',
        component: InserirLivro,
    },
    {
        path: 'listar',
        component: ListarLivros,
    },
    {
        path:'',
        redirectTo: 'listar',
        pathMatch: 'full'
    }
];