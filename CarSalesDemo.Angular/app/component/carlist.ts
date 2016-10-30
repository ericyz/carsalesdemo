import { Component, EventEmitter, ElementRef } from '@angular/core';
import { Car } from './car';


@Component({
    selector: 'car-list',
    template: `<div class='ui items' [style.cursor]='getCursorStatus()' style="width: 100%;" *ngFor='let car of cars'>
                    <car-row [car]='car' (click)='clicked(car)'></car-row>
                  </div>
                 `,
    inputs: ['cars'],
    outputs: ['carWasSelected']
})
export class CarList {
    private element: HTMLElement;

    cars: Car[];
    carWasSelected: EventEmitter<Car>;

    public constructor(el: ElementRef) {
        this.element = el.nativeElement;
        this.carWasSelected = new EventEmitter<Car>();
    }
    clicked(car: Car): void {
        this.carWasSelected.emit(car);
    }

    getCursorStatus(): string {
        return "pointer";
    }
}





