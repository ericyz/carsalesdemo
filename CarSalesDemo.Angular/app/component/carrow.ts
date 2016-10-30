﻿import { Component } from '@angular/core';
import { Car } from './car';

@Component({
    selector: 'car-row',
    template: `
                <car-image [car]='car'></car-image>
                <div class="middle aligned content">
                  <div class="header">{{car.title}}</div>
                  <div class="meta">
                    <span class="type">{{car.type}}</span>
                  <div class="extra">
                    <br/>
                    <br/>
                     <div class="ui right floated">
                     \${{car.price}}
                    </div>
                 </div>
                </div>
            `,
    host: { 'class': 'item' },
    inputs: ['car'],
})
export class CarRow {
    car: Car;
}