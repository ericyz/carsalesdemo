import { Component } from '@angular/core';
import { Car } from './car';
@Component(
    {
        selector: 'car-image',
        template: `<div class='car-image'>
                         <img src="{{car.imageUrl}}">
                   </div>
                    `,
        inputs: ['car'],
        host: { 'class': 'ui small image' }
    })
export class CarImage {
    car: Car;
}