import { Injectable } from '@angular/core';
//import { Observable, BehaviorSubject } from 'rxjs';
import { Http, URLSearchParams, Response } from '@angular/http';
import { Car, CarJson } from './../Car';
import { environment } from './../environments/environment';
import { Observable, BehaviorSubject } from 'rxjs/Rx';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';

@Injectable()
export class CarService {

    private _cars: BehaviorSubject<Car[]> = new BehaviorSubject<Car[]>([]);
    private _selectedCar: BehaviorSubject<Car> = new BehaviorSubject<Car>(null);

    // Operations
    private _refreshSubject: BehaviorSubject<string> = new BehaviorSubject<string>('');
    private _refreshSingleSubject: BehaviorSubject<string> = new BehaviorSubject<string>('');
    //    private _filterBySellerType: BehaviorSubject<string> = new BehaviorSubject<string>('');

    // Expose to public for subscribing the change
    public cars: Observable<Car[]> = this._cars.asObservable();
    public selectedCar: Observable<Car> = this._selectedCar.asObservable();


    constructor(private http: Http) {
        console.log("car service: constructor");

        this._refreshSubject.subscribe(this.getCars.bind(this));
        this._refreshSingleSubject.subscribe(this.getCarById.bind(this));
    }

    // Call API
    getCars(type?: string) {
        console.log("type = " + type);
        var request: any;
        if ((type || '') !== '') {
            request = { type: type }
        }
        console.log("car service: getCars");
        this._makeHttpRequest("cars", this._generateSearchParameter(request)).subscribe(json => {
            const cars = json.map((carJson: CarJson) => Car.fromJson(carJson));
            console.log(`"car results: ${cars}`);
            this._cars.next(cars);
        });
    }

    getCarById(id: string) {
        if (id && id !== '') {
            this._makeHttpRequest(`cars/${id}`)
                .subscribe(json => {
                    var car = Car.fromJson(json);
                    console.log(car);
                    this._selectedCar.next(car);
                });
        }
    }

    // Trigger api call
    public updateType(type?: string) {
        this._refreshSubject.next(type);
    }

    public updateId(id: number) {
        console.log("update by id " + id);
        this._refreshSingleSubject.next(id.toString());
    }

    // helper
    private _makeHttpRequest(path: string, params?: URLSearchParams): Observable<any> {
        let url: string = `${environment.baseUrl}/${path}`;
        console.log(`calling uri =  ${url}, parameters =${params} `);
        return this.http.get(url, { search: params })
            .map(res => res.json());
        //            .map((json): CarJson[] => json.map(carJson => Car.fromJson((carJson) as any)));

    }

    private _generateSearchParameter(json?: any): URLSearchParams {
        if (json !== null) {
            var request = new URLSearchParams();
            for (var name in json) {
                request.set(name, json[name]);
                return request;
            }
        }
        return null;
    }

    //    let baseUrl: string = environment.baseUrl;
    //        return this.http.get(`${baseUrl}/cars`)
    //            .map(response => response.json())
    //            .map(cars => cars.map((car: any) => car));

}