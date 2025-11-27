import { Routes } from '@angular/router';
import { InserirLivro } from './inserir-livro/inserir-livro';


export const routes: Routes = [
    {
        path: 'inserir',
        component: InserirLivro,
    },
    {
        path:'',
        redirectTo: 'inserir',
        pathMatch: 'full'
    }
];