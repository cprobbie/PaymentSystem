# Simple Payment System built with .NET core web api and Angular

The initial template was the default Visual Studio 2019 Angular/.Net Core 2.2 template. 
I then updated the default Angular app to Angular 7.

This App was structured to have simple architecture which only has an Angular 7 app, an API controller, a couple of DTOs and Models.
Due to the purpose of the App, I only ultilised a data repository to simply read/write into DB, the simple business logic was done in DTO.
In this case, no service layer was needed. 

My approach was to disable the frontend app and build the backend server first. Swagger was installed to have an overview and test the APIs.

## Database
Db was setup using SQL Server and accessed by EntityFramework Core and I used EF Code-First approach.
The advantages of Code-First approach allows db creation, data seeding and schema updates all done in CLI.

## DTO
DTOs were used to modify models for tailored data transferring between backend and frontend.


## HOW TO RUN THE APP

### Install Angular CLI if you have not installed it before
`npm install -g @angular/cli`
### Install node.js Modules
`npm install`
### Setup Database in Package Manager Console
`update-database`

### Now you are good to run the program in Visual Studio