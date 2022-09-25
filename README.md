# Animal Shelter API

#### By: Nick Tse

#### This project is an API for a local animal shelter. Swagger is used for interative API documentation.

## Technologies Used

* C#
* MSTest
* .NET 5 SDK
* ASP.NET Core
* Razor
* HTML
* MySQL
* Entity
* Identity
* Swagger


## Description 

The project is an API that lists the available animals up for adoption at an animal shelter. By going to localhost:5000/api/animals in either the browser or Postman, the user can see a json file of the various animals up for adoption. Visiting localhost:5000/swagger/index.html allows the user to interact with the API using Swagger.

## Setup/Installation Requirements

* _Clone repository from GitHub_
* _Open your terminal and run the command $ git clone https://github.com/n-tse/AnimalShelter.solution_
* _Using the command $ cd AnimalShelter, navigate to the AnimalShelter directory_
* _Within the project directory, create a file called appsettings.json_
* _Add the following code to the new appsettings.json file:_ 
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}

* _Run the command $ dotnet build_
* _Run the command $ dotnet ef database update_
* _Run the command $ dotnet run_
* _In your web browser, type "http://localhost:5000/swagger/index.html"_
* _The browser should now display the web application for the user to interact with_"

## API Endpoints

Swagger allows the user to easiily interact with the API. The following are the available routes:
* GET /api/Animals
* POST /api/Animals
* GET /api/Animals/{id}
* PUT /api/Animals{id}
* DELETE /api/Animals/{id}


## Known Bugs

* no known bugs

## License

_MIT_

Copyright (c) _2022_ _Nick Tse_