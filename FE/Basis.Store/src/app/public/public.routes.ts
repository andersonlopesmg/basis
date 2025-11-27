import { Routes } from '@angular/router';
import { MainPagePublic } from './main/main-public.page';


export const routes: Routes = [
    {
        path: '',
        component: MainPagePublic,
    },
    {
        path:'',
        redirectTo: 'home',
        pathMatch: 'full'
    }
];