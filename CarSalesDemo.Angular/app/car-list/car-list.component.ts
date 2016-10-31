import { Component, EventEmitter, OnInit } from '@angular/core';
import { Car } from './../car';
import { Router, ActivatedRoute, } from '@angular/router';
import {CarService} from './../service/car.service';
import { Observable, BehaviorSubject } from 'rxjs';

@Component({
    selector: 'car-list',
    templateUrl: "app/car-list/car-list.component.html",
    styleUrls: ["app/car-list/car-list.component.css"]
})
export class CarList implements OnInit{

    cars: Car[];
//    carWasSelected: EventEmitter<Car>;

    public constructor(private router: Router, private carService: CarService) {
//        this.carWasSelected = new EventEmitter<Car>();
//        this.cars = [
//            new Car(1, "2016 Hyundai Tucson Active X Auto 2WD MY17", "private seller", "/resource/black-shoes.jpg", 0.1),
//            new Car(2, "This is Car2222 222 22222222", "dealer", "/resource/black-shoes.jpg", 0.2),
//            new Car(2, "This is Car2222 22222 222222", "dealer", "/resource/black-shoes.jpg", 0.2),
//            new Car(2, "This is Car222 222222222222", "dealer", "/resource/black-shoes.jpg", 0.2),
//            new Car(2, "This is Car222 22222 2222222", "dealer", "/resource/black-shoes.jpg", 0.2),
//            new Car(2, "This is Car22 22222222 22222", "dealer", "/resource/black-shoes.jpg", 0.2),
//        ];
    }
    clicked(car: Car): void {
        this.getCars();
        console.log('car was selected  ' + JSON.stringify(car));
        // Redirect
        this.router.navigate(['/detail', car.id]);
    }

    getCursorStatus(): string {
        return "pointer";
    }

    private getCars(): void {
        this.carService.getCars()
            .subscribe((a: any) => {console.log("receive a")},
                error => console.error('Error when fetching cars', error),
                () => { console.log('Complete car fetching'); });
    }

    ngOnInit(): void {}
}