import { NgModule, Component } from '@angular/core';
import { BrowserModule } from "@angular/platform-browser";
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { RouterModule, Routes } from '@angular/router';
//import { CarSalesApp as CarSalesAppComponent } from './component/main';
import { CarSalesAppComponent} from './app.component';
import { Car } from './car';
import { CarList } from './car-list/car-list.component';
import { CarRow } from './car-list/car-row.component';
import { CarImage } from './car-list/car-image.component';
import { CarDetail } from './car-detail/car-detail.component';
import { LocationStrategy, HashLocationStrategy } from '@angular/common';
import { appRoutes } from './app.routes';

@NgModule({
    declarations: [
        // Main
        CarSalesAppComponent,
       
        CarRow,
        CarImage,
        CarList,
//        // Detail Page
        CarDetail
    ],
    imports: [BrowserModule, appRoutes],
    bootstrap: [CarSalesAppComponent],
    providers: [{ provide: LocationStrategy, useClass: HashLocationStrategy }]
})
export class CarSaleAppModule {
}