import { Routes } from '@angular/router';
import { MainPagePublic } from './main/main-public.page';
import { HomePublic } from './home/home-public';



export const routes: Routes = [
    {
        path: '',
        component: MainPagePublic,
        children: [
            {
                path: 'home',
                component: HomePublic
            },
            {
                path: '',
                redirectTo: 'home',
                pathMatch: 'full'
            }
        ]
    },
];