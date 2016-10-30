import { Component } from '@angular/core';
import { Car } from './../car';
@Component(
    {
        selector: 'car-image',
        templateUrl: 'app/car-list/car-image.component.html',
        inputs: ['car'],
        host: { 'class': 'ui small image' }
    })
export class CarImage {
    car: Car;
}