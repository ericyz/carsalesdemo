import { Component } from '@angular/core';
import { Car } from './car';

@Component({
    selector: "car-price",
    template: `<span class="price">\${{price}}</span>`,
    inputs: ['price']

})
export class CarPrice {
    price: number;
}
