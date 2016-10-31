import { Component, OnInit } from '@angular/core';
import { Car } from './../Car';
import { CarService } from './../service/car.service';
import { RouteUtil } from './../utility/route.util';
import { Router, ActivatedRoute, Params } from '@angular/router';
import { Observable } from 'rxjs';

@Component({
    selector: 'car-detail',
    templateUrl: 'app/car-detail/car-detail.component.html',
    styleUrls: ['app/car-detail/car-detail.component.css']
})
export class CarDetail implements OnInit {
    car: Observable<Car>;

    constructor(private route: ActivatedRoute, private carService: CarService, private activeRoute: ActivatedRoute) {
        this.car = carService.selectedCar;
    }

    ngOnInit(): void {
        this.activeRoute.params.subscribe(s => {
            var id: number = RouteUtil.ERROR_ID;
            if ((id = RouteUtil.validId(s)) !== RouteUtil.ERROR_ID) {
                this.carService.updateId(id);
            }
        });
        //        this.route.params.forEach((params: Params) => {
        //            let id = + params['id'];
        //            this.car = new Car(1,
        //                "2016 Hyundai Tucson Active X Auto 2WD MY17",
        //                "private seller",
        //                "/resource/black-shoes.jpg",
        //                0.1);
        //        });
    }
}