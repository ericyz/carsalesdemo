import { NgModule } from '@angular/core';
import { BrowserModule } from "@angular/platform-browser";
import { CarSalesAppComponent} from './app.component';
import { CarList } from './car-list/car-list.component';
import { CarTypeFilter } from './car-list/car-list-type-filter.component';
import { CarListMainComponent } from './car-list/main.component';
import { CarRow } from './car-list/car-row.component';
import { CarImage } from './car-list/car-image.component';
import { CarDetail } from './car-detail/car-detail.component';
import { CarSalesNavBar } from './navigation/navigation.component';
import { CarService } from './service/car.service';
import { ErrorComponent } from './error/error.component';
import { LocationStrategy, HashLocationStrategy } from '@angular/common';
import { appRoutes } from './app.routes';
import { HttpModule } from '@angular/http';


@NgModule({
    declarations: [
        CarSalesAppComponent,
        // Main
        CarRow,
        CarImage,
        CarList,
        CarTypeFilter,
        CarListMainComponent,
        // Navigation 
        CarSalesNavBar,
//        // Detail Page
        CarDetail,
        // Error Page
        ErrorComponent
    ],
    imports: [BrowserModule, appRoutes, HttpModule],
    bootstrap: [CarSalesAppComponent],
    providers: [{ provide: LocationStrategy, useClass: HashLocationStrategy },CarService]
})
export class CarSaleAppModule {
}