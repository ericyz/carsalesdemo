# CarSales Demo Design Documentation
## Overview
<p>This project is a demo for car-displaying website. This document includes the requirement, design and major decision made during the development. This repo is the source code for the demo website and the project has also been deployed to Azure web service. Please redirect to <a>http://carsalesdomo.azurewebsites.net/</a>.</p> The web api endpoints declaration also available in the <a>< href='#appendix'>appendix</a>.

## Requirement Analysis
The project aims to provide a website like car galleries. Users can view them, both in list or in a seperate page, and filter them by seller type.

<strong>Functional Requirement</strong>
<li>The website can provide users car information in a list</li>
<li>Users can filter them by its seller type</li>
<li>Users can view in detail by clicking any item in the list</li>

<strong>Non-funciton Requirement</strong>
<li>The website will provide error page when error occurs.<li>
<li>Users will be able to navigate between each modules, such as detail page and list page.<li>
<li>Users will be able to have a propery page display with mobile or tabliet devices.<li>

## Software Architecture
The software solution is built with service-orientied archietecture (SOA). In this project, one JavaScript app client talks with one RESTful API. 

In the backend, the key idea is to decouple services, including business services and data accesss services. In the high-level web api, difference services are constructed according to the web config and inject them in the API controller constructors.

The data access layer is used with factory pattern. It receives information about data configuration, which is from the web.config and return the repository with read, update, delete and create operation for each entities.

The project has the following hirearchy.
- <i>Client</i>: Client Applications such as JavaScript Application, Mobile Application or Desktop Application
  - <i>CarSalesDemo.Angular</i>: JavaScript Application with Angular2
- <i>Server</i>: Server projects with different layers
  - <i>CarSalesDemo.Api</i>: High-level API layer, which is used to communicate with client applications
  - <i>CarSalesDemo.Repository</i>: Data Access Layer with Repository
  - <i>CarSalesDemo.Model</i>: Domains for this projects
- <i>Test</i>: Unit Test projects
  - <i>CarSalesDemo.Api.Tests</i>: Unit test for API project
  
The following are the framework and libraries are used in the project.
- Angular

## Design Decision


## Waiting Room
Due to the time constrant, there are several aspects this project can be further improved in terms of development and user interaction.

<i>Development</i>
- Automate deployement process with testing and production configuration.
- Add simple authentication to protect web API.
- The service can be extracted to a sperated layer from web api when the project goes large.
- Move datasource to relational database such as MySQL or SQL server.
- It is an efficient practice that using Jasmine and NUnit to write test cases on interfaces when project goes large.

<i>Usaiblity Improvement</i>
- Notify users when error occurs
- Notify users when the page is loading
- Add css or seperate view for mobile or tablets users

## <span id='appendix'>Appendix</span>
### Web API
The endpoints are available http://carsalesdeomo.azurewebsites.net. The endpoints are shown as the following.

<strong>Car Endpoints</strong>
- api/cars: obtain all the cars avaiable
- api/cars/{id}: request car information by car id
- api/cars?type={type}: request car information by seller type

<i>Image Endpoints</i>
- api/images?name={name}: request image response by file name

<i>Allowed Origins</i>
- Azure deployment: http://carsalesdomo.azurewebsites.net/ 
- Local testing environment: http://localhost:63024

### Browser Minimum Support
<li>Chrome</li>
<li>Firefox</li>
<li>IE 9</li>
<li>Safari 7</li>
<li>iOS 7</li>
<li>IE Mobile 11</li>
<li>Android 4.1</li>

