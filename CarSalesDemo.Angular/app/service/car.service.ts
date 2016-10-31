import { Injectable } from '@angular/core';
import { Observable, BehaviorSubject } from 'rxjs';
import { Http, URLSearchParams } from '@angular/http';
import { Car } from './../Car';
import { environment } from './../environments/environment';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';

@Injectable()
export class CarService {

    private _cars: BehaviorSubject<Car[]> = new BehaviorSubject<Car[]>([]);

    // Expose to public for subscribing the change
    public cars: Observable<Car[]> = this._cars as Observable<Car[]>;

    constructor(private http: Http) {
        console.log("car service: constructor");

    }

    public getCars() {
        console.log("car service: getCars");
        this._makeHttpRequest("cars").subscribe((json: Car[]) => this._cars.next(json));
    }



    public filteredCars() {

    }

    private _makeHttpRequest(path: string, params?: URLSearchParams): Observable<any> {
        let url: string = `{environment.baseUrl}\\{path}`;
        console.log('calling uri = ' + url);
        return this.http.get(url,
            {
                search: params
            })
            .map(response => response.json());
    }


    //    let baseUrl: string = environment.baseUrl;
    //        return this.http.get(`${baseUrl}/cars`)
    //            .map(response => response.json())
    //            .map(cars => cars.map((car: any) => car));

}