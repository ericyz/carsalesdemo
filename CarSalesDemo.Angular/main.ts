﻿import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { enableProdMode } from '@angular/core';
import { environment } from './environments/environment';
import { CarSaleAppModule } from './app/index';
if (environment.production) {
    enableProdMode();
}

platformBrowserDynamic().bootstrapModule(CarSaleAppModule);
