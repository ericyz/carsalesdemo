import { Routes, RouterModule } from '@angular/router';
import { CarList } from './car-list/car-list.component';
import { CarDetail } from './car-detail/car-detail.component';

const routes: Routes = [
    {
        path: '',
        redirectTo: 'home',
        pathMatch: 'full'
    },
    {
        path: 'home',
        component: CarList
    },
    {
        path: 'detail/:keyId',
        component: CarDetail
    }
];


export const appRoutes =
    RouterModule.forRoot(routes);
