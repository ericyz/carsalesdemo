import {Component} from '@angular/core';
import { Car } from './car';

@Component({
    selector: 'carsales-app',
    template: `<div class='carsales-app'>
                   <car-list [cars]='cars' (carWasSelected)="onCarSelected($event)"></car-list>     
                </div>
                `
})
export class CarSalesApp {
    cars: Car[];

    public constructor() {
        this.cars = [
            new Car(1, "2016 Hyundai Tucson Active X Auto 2WD MY17", "private seller", "/resource/black-shoes.jpg", 0.1),
            new Car(2, "This is Car2222 222 22222222", "dealer", "/resource/black-shoes.jpg", 0.2),
            new Car(2, "This is Car2222 22222 222222", "dealer", "/resource/black-shoes.jpg", 0.2),
            new Car(2, "This is Car222 222222222222", "dealer", "/resource/black-shoes.jpg", 0.2),
            new Car(2, "This is Car222 22222 2222222", "dealer", "/resource/black-shoes.jpg", 0.2),
            new Car(2, "This is Car22 22222222 22222", "dealer", "/resource/black-shoes.jpg", 0.2),
        ];
    }

    onCarSelected(car: Car): void {
        alert(car + "Car was selected");
    }
}


