import { Component } from '@angular/core';
import { Car } from './../car';

@Component({
    selector: 'car-row',
    templateUrl: 'car-row.component.html',
    host: { 'class': 'item' },
    inputs: ['car']
})
export class CarRow {
    car: Car;
}