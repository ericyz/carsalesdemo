import { NgModule, Component } from '@angular/core';
import { BrowserModule } from "@angular/platform-browser";
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { RouterModule, Routes } from '@angular/router';
import { CarSalesApp } from './component/main';
import { Car } from './component/car';
import { CarList } from './component/carlist';
import { CarRow } from './component/carrow';
import { CarPrice } from './component/carprice';
import { CarImage } from './component/carimage';
import { CarDetail } from './component/cardetail';

@NgModule({
    declarations: [
        // Main
        CarSalesApp,
        CarRow,
        CarImage,
        CarList,
        CarPrice,

        // Detail Page
        CarDetail
    ],
    imports: [BrowserModule],
    bootstrap: [CarSalesApp]
})
class CarSaleAppModule {
}

// Navigation
const routes: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: CarSalesApp },
    { path: 'detail', component: 'CarDetail' },
];
platformBrowserDynamic().bootstrapModule(CarSaleAppModule);