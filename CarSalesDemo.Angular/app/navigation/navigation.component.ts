import { Component, Input, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Router, ActivatedRoute, } from '@angular/router';
import { CarService } from './../service/car.service';
import { FormBuilder, FormGroup, AbstractControl } from '@angular/forms';
import { RouteUtil } from './../utility/route.util';
@Component({
    selector: 'carsales-nav',
    templateUrl: 'app/navigation/navigation.component.html',
    styleUrls: ['app/navigation/navigation.component.css']

})
export class CarSalesNavBar {
    sellerTypeContoller: AbstractControl;
    formGroup: FormGroup;
    constructor(private activeRoute: ActivatedRoute, private carService: CarService, formBuilder: FormBuilder, router: Router) {
        console.log('activeRoute.queryParams' + activeRoute.queryParams);
        activeRoute.queryParams.subscribe(p => {
//            console.log('CarSalesNavBar constructor = ' + p['type']);
//            this.sellerType = p['type'] || "";
//            console.log(`seller type = ${this.sellerType}`);
            var sellerType = RouteUtil.getValidateType(p);

//            sellerType = p['type'];
            this.formGroup = formBuilder.group({
                'type': [sellerType]
            });
            this.sellerTypeContoller = this.formGroup.controls['type'];
//            console.log(`seller type controller = ${this.sellerTypeContoller}`);

            // Watch the change
            this.sellerTypeContoller.valueChanges.subscribe(
                (type: string) => {
                    console.log(`seller Type value change = ${type}`);
                    router.navigateByUrl(`home?type=${type}`);
                }
            );
        });
    }

  

    onSubmit(form: any): void {
        console.log(form);
    }
}