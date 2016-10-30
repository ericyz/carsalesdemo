import { Component } from '@angular/core';
import { Car } from './../car';
@Component(
    {
        selector: 'car-image',
        templateUrl: 'car-image.component',
        inputs: ['car'],
        host: { 'class': 'ui small image' }
    })
export class CarImage {
    car: Car;
}