import { Component, OnInit} from '@angular/core';
import {Car} from './../Car';
import { Router, ActivatedRoute, Params } from '@angular/router';

@Component({
    selector: 'car-detail',
    templateUrl: 'app/car-detail/car-detail.component.html',
    styleUrls: ['app/car-detail/car-detail.component.css']
})
export class CarDetail implements OnInit{
    car: Car;

    constructor(private route: ActivatedRoute) {
        
    }
    ngOnInit(): void {
        this.route.params.forEach((params: Params) => {
            let id = +params['id']; // (+) converts string 'id' to a number
            this.car = new Car(1,
                "2016 Hyundai Tucson Active X Auto 2WD MY17",
                "private seller",
                "/resource/black-shoes.jpg",
                0.1);
        });
    }
}