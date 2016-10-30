import { Routes, RouterModule } from '@angular/router';
import { CarList } from './car-list/car-list.component';
import { CarListMainComponent } from './car-list/main.component';
import { CarDetail } from './car-detail/car-detail.component';
import { ErrorComponent } from './error/error.component';

const routes: Routes = [
    {
        path: '',
        redirectTo: 'home',
        pathMatch: 'full'
    },
    {
        path: 'home',
        component: CarListMainComponent
    },
    {
        path: 'detail/:id',
        component: CarDetail
    },
    {
        path: 'error',
        component: ErrorComponent
    }
];


export const appRoutes =
    RouterModule.forRoot(routes);
