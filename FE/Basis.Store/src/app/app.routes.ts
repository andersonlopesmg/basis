import { Routes } from '@angular/router';

export const routes: Routes = [
    {
        path: 'app',
        loadChildren: () => import('./private/private.routes').then(m => m.routes)
    },
    {
        path: '',
        loadChildren: () => import('./public/public.routes').then(m => m.routes)
    },
];
