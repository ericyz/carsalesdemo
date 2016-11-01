# CarSales Demo Design Documentation
## Overview
<p>This project is a demo for car-displaying website. This document includes the requirement, design and major decision made during the development. This repo is the source code for the demo website and the project has also been deployed to Azure web service. Please redirect to <a>http://carsalesdomo.azurewebsites.net/</a>.</p> The web api endpoints declaration also available in the <a> href='#appendix'>appendix</a>.

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


## Design Decision


## Waiting Room
<i>Development</i>
- Automate deployement process with testing and production configuration 
- Add simple authentication to protect web API
- Move datasource to relational database such as MySQL or SQL server

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
