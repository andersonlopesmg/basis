import { Routes } from '@angular/router';
import { MainPagePrivate } from './main/main-private.page';

export const routes: Routes = [
    {
        path: '',
        component: MainPagePrivate,
        children:[
            {
                path: 'livros',
                loadChildren: () => import('./catalogo/livros/livros.routes').then(m => m.routes)
            }
        ]
    },
];