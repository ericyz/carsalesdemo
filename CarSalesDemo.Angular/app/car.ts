export interface CarJson {
    id: number;
    imageName: string;
    sellerType: number;
    title: string;
    price: number;
}

export class Car {
    public constructor(public id: number, public title: string, public type: string, public imageUrl: string, public price: number) { }

    public static fromJson(json: CarJson): Car {
        let article = Object.create(Car.prototype);
        let ret =  Object.assign(article,
            json,
            {
                id: json.id,
                title: json.title,
                type: json.sellerType == 0 ? 'dealer' : 'private seller',
                imageUrl: json.imageName,
                price: json.price
            });
//        console.log(ret);
        return ret;
    }
}





