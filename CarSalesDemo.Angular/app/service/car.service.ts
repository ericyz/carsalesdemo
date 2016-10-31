import { Injectable } from '@angular/core';
import { Observable, BehaviorSubject } from 'rxjs';
import { Http} from '@angular/http';
import { Car } from './../Car';
import { environment } from './../environments/environment';


@Injectable()
export class CarService {

    constructor(private http: Http) {
        
    }

    getCars(): Observable<any> {

        let baseUrl: string = environment.baseUrl;
        return this.http.get(`${baseUrl}/cars`)
            .map(response => response.json());

    }
}