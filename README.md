# CarSales Demo Design Documentation
## Overview
<p>This project is a demo for a car-displaying website. This document includes the requirement, design and major decision made during the development. This repo is the source code for the demo website and the project has also been deployed to Azure web service. Please redirect to <a>http://carsalesdomo.azurewebsites.net/</a>.</p> The web API endpoints declaration also available in the <a href='#appendix'>appendix</a>.

## Requirement Analysis
The project aims to provide a website like car galleries. Users can view them, both in a list or on a separate page, and filter them by seller type.

<strong>Functional Requirement</strong>
<li>The website can provide users car information in a list</li>
<li>Users can filter them by its seller type</li>
<li>Users can view in detail by clicking any item in the list</li>

<strong>Non-functional Requirement</strong>
<li>The website will provide error page when error occurs.</li>
<li>Users will be able to navigate between each module, such as detail page and list page.</li>
<li>Users will be able to have a proper page display with mobile or tablet devices.</li>

## Software Architecture
The software solution is built with service-oriented architecture (SOA). In this project, one JavaScript app client communicates with one RESTful API. Even though the requirement given is not complex, a well-design software should keep the cost of extending functionalities as lowest as possible.

In the backend, the key idea is to decouple services, including business services and data access services. In the high-level web API, difference services are constructed according to the web config and inject them in the API controller constructors.

The data access layer is used with the factory pattern. It receives information about data configuration, which is from the web.config and returns the repository with read, update, delete and create operation for each entity.

The project has the following hierarchy.
- <i><u>Client</u></i>: Client Applications such as JavaScript Application, Mobile Application or Desktop Application
  - <i><u>CarSalesDemo.Angular</u></i>: JavaScript Application with Angular2
- <i><u>Server</u></i>: Server projects with different layers
  - <i><u>CarSalesDemo.Api</u></i>: High-level API layer, which is used to communicate with client applications
  - <i><u>CarSalesDemo.Repository</u></i>: Data Access Layer with Repository
  - <i><u>CarSalesDemo.Model</u></i>: Domains for this projects
- <i>Test</i>: Unit Test projects
  - <i>CarSalesDemo.Api.Tests</i>: Unit test for API project
  
The following are the frameworks and libraries are used in the project.
- Angular 2.1
- Semantic UI 2.2
- .Net 4.6
- ASP.NET MVC 5.2.3
- Newtonsoft.Json 6.0.4
- NUnit 3.5.0
- Moq 4.5.23

## Design Decision
### Why choose SOA
The key point to use SOA is to to decouple software components. SAO allows a structure that a centralized web API serves different clients, such as iOS apps, Desktop apps and web apps. In this case, every client and server is a separate component and the uri is the interface allowing them. This will reduce the development expense when new devices such as mobiles are required with futhure development, which is because they shared the same business logics to read, update, delete and create data.

## Authentication
Currently, there is no logging module in the requirement. Therefore, the API is public at the moment. When the project has role-based operation or user data, the authentication will be introduced to protect the API resources. Since JavaScript app is operated on client side or untrusted client, when using OAuth2, only implicit or resource owner password credentials grant could be applied, but which to use will be determined by the security requirement for client applications.

### Where to Store Data
Since the client only requires read access to the data. A data is stored in a Json file located in the Web API server. In order to support other data source when the client needs concurrent writing operation such as SQL-server relational database, the factory pattern is used to obtain the data repository.

With the help of Factory design pattern, only further development is to change the web.config, refer to <a href='#appendix'>the appendix</a>, and implement the data access layer for new data source.

### How to Display Image
Car images are stored in the server side. When requesting car information in Angular page, rather than sending them together with the car information in a byte array, its image source URL is constructed in the Angular app with the name of car and image is received from the image API (refer to <a href='#appendix'>appendix</a>).

### Why to User Observable in Angular Service
Compared with Angular 1.5.x, Angular 2 is more flexible in data transferring. In this demo, Observables are used to bind the data received from API to the views. In Angular 1.5.x, Promise $q is an injected Angular component for making HTTP request. The promise provides a straight-forward approach to process retrieved data, but they are not re-usable. In Angular 2, Observable have an advantage over Promises with its flexibility. With subscribing an observable, operations such as filtering and ordering could be applied to the same data.

### Error Handling and Waiting Image
The error occurs in Web API will be handled in try catch block and return 500 internal service error code. This 500 error code will be handled in the Angular service and redirect to error page.

Because Observables are the asynchronized stream, it might take some time for the Angular app to retrieve data from Web API; therefore, a spinner has been placed while the data is being retrieved.

## Waiting Room
Due to the time constraint, there are several aspects this project can be further improved in terms of development and user interaction.

<i>Development</i>
- Automate deployment process with testing and production configuration.
- Add simple authentication to protect web API.
- The service can be extracted to a sperated layer from web API when the project goes large.
- Move datasource to relational database such as MySQL or SQL server.
- It is an efficient practice that using Jasmine and NUnit to write test cases on interfaces when the project goes large.
- When loading car list webpage, compressed images could be transferred rather than origin images, because the images take about 0.5s to render.

<i>Usability Improvement</i>
- Add CSS styles or separate view for mobile or tablets users
- When entering car detail page, the previous will remain displayed before new car image is rendered. This could be resolved by removing all content before retrieving the new car data.

## <span id='appendix'>Appendix</span>
### Web API
The endpoints are available http://carsalesdeomo.azurewebsites.net. The endpoints are shown as the following.

<strong>Car Endpoints</strong>
- api/cars: obtain all the cars avaiable
- api/cars/{id}: request car information by car id
- api/cars?type={type}: request car information by seller type

<i>Image Endpoints</i>
- api/images?name={name}: request image response by file name

<i>Allowed Crossed Domains</i>
- Azure deployment: http://carsalesdomo.azurewebsites.net/ 
- Local testing environment: http://localhost:63024

<i>Configuration</i>
In the web config, the following parameters are required to work with Json data provider.
- DataFolder: the location where json folder is
- DataProvider: currently only supports 'json'

### Browser Minimum Support
<li>Chrome</li>
<li>Firefox</li>
<li>IE 9</li>
<li>Safari 7</li>
<li>iOS 7</li>
<li>IE Mobile 11</li>
<li>Android 4.1</li>

### Declaration
All the information and the images used in this demo are sourced from <a>www.carsales.com.au</a>.
