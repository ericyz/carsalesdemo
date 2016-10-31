
export interface ICarJSON {
     id: number;
     price: number;
     title: string;
     type: string;
     imageUrl: string;
}

export class Car  {
   public constructor(public id: number, public title: string, public type: string, public imageUrl: string, public price: number) {  }

    public static fromJson(json: ICarJSON) {
        
    }
}





