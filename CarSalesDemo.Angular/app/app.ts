import { NgModule, Component } from '@angular/core';
import {BrowserModule } from "@angular/platform-browser";
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";



@Component({
    selector: 'carsales-app',
    template: `<div class='carsales-app'>tesdfsfdsft</div>`
})
class CarSalesApp {
    cars: Car[];

    public constructor() {
        this.cars = [
                        new Car(1, "Car1", "http://urltest1", 0.1),
                        new Car(2, "Car2", "http://urltest2", 0.2)
                    ];
    }
}
//
//@Component({
//    selector: 'carsales-app',
//    template: `<div class='carsales-app' [car]='cars[0]'><car-row></car-row></div>`
//})
//class CarSaleApp {
//    cars: Car[];
//
//    public constructor() {
//        this.cars = [
//                        new Car(1, "Car1", "http://urltest1", 0.1),
//                        new Car(2, "Car2", "http://urltest2", 0.2),
//                    ];
//    }
//}


// Model
class Car {
    public constructor(public id: number, public title: string, public imageUrl: string, public price: number) { }
}
//
//@Component({
//    selector: 'car-row',
//    inputs: ['car'],
//    template: `<div class='car-row' [car]='car' >
//                    {{car.id}}
//                    {{car.title}}
//                    {{car.imageUrl}}
//                    {{car.price}}
//                </div>`
//})
//class CarRow {
//
//}
@NgModule({
    declarations: [
        CarSalesApp
    ],
    imports: [BrowserModule],
    bootstrap: [CarSalesApp]
})
class CarSaleAppModule
{
}

platformBrowserDynamic().bootstrapModule(CarSaleAppModule);