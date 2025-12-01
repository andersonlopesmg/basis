import { Routes } from '@angular/router';
import { MainPagePrivate } from './main/main-private.page';
import { HomePrivate } from './home/home-private';

export const routes: Routes = [
    {
        path: '',
        component: MainPagePrivate,
        children: [
            {
                path: '',
                redirectTo: 'home',
                pathMatch: 'full'
            },
            {
                path: 'home',
                component: HomePrivate
            },
            {
                path: 'livros',
                loadChildren: () => import('./catalogo/livros/livros.routes').then(m => m.routes)
            }
        ]
    },

];