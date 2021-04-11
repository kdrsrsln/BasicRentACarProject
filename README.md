# Basic Rent A Car Project
![Basic Rent A Car Project Banner](https://user-images.githubusercontent.com/9069103/113979253-ad294980-984d-11eb-8551-d78810dfeb45.jpg)

<p align="center">
<a href="https://github.com/kdrsrsln/BasicRentACarProject" target="_blank">
  <img src="https://img.shields.io/github/last-commit/kdrsrsln/BasicRentACarProject?style=plastic" alt="Github last commit">
</a>
<p>

## Introduction
This repository developed as an inspiration of Car Rental Systems following **SOLID principles** using **multi layer architecture**. This project doesn't cover whole Rent A Car system, it only covers main topics to show coding style with C# and .Net Core skills.

### Key Features
* Multi Layer Architecture
* ORM
  - Entity Framework Core
* Clean Code
* Aspect Oriented Programming
  - Validation Aspect
  - Cache Aspect
  - Performance Aspect
  - Transaction Aspect
* Autofac
  - IoC
  - Interceptors
* Fluent Validation
* Json Web Token implementation
* Restful API
* Cross Plaftorm
  - Windows, macOS, and Linux ready
* Angular FrontEnd
  - **Angular CLI 11.1**
* Boostrap

### Dependencies
* .Net Core 3.1+
* Node.js 14.15+

### WIP
* AngularJS Front End
* Multiple File uploads
* Dockerizing the repo
* Unit Testing

## Getting Started

#### To run the demo:

**1.** Clone/Fork/Download this repository.

**2.** Create the database on your SQL Server Express LocalDB by using sql file
:page_with_curl: <a href="https://github.com/kdrsrsln/BasicRentACarProject/blob/master/BasicRentACarDB.sql">BasicRentACarDb.sql</a>

**3.** Install Angular CLI if necessary. `npm install -g @angular/cli`

**4.** Install project dependencies.
<pre><code>BasicRentACarProject\FrontEnd> npm install</code></pre>

**5.** Run the Angular CLI dev server to build and run the Angular app.
<pre><code>BasicRentACarProject\FrontEnd> ng serve</code></pre>
  - **Important:** This must be running on the default http://localhost:4200

**6.** Build/Run the `BasicRentACarProject.sln` solution using your preferred method: Visual Studio,  VSCode, dotnet CLI.
  - **Important:** This must be running on http://localhost:44319

**7.** Point a browser to `http://localhost:4200` to access the Angular client.

**8.** Use the *Signup* and *Login* functions to perform the authentication flow, then try and access the *Top Secret Area* to hit the protected ASP.NET Core Web API.
