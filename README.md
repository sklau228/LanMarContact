\# ContactManagerLanMar



\## Overview



This project is a simple contact management web application built using ASP.NET Core MVC and SQL Server.



The application allows users to create, edit, delete, view and search contacts stored in a database.



\---



\## Features



Create contact

Edit contact

Delete contact

Display contact list

Search contacts



\---



\## Technology Stack



ASP.NET Core MVC (.NET 8)

Entity Framework Core

SQL Server LocalDB

Bootstrap



\---



\## Architecture



The application follows MVC architecture:



Controller → handles HTTP requests

Model → represents contact entity

DbContext → manages database interaction



Entity Framework Core is used as ORM for database access.



\---



\## Database



SQL Server LocalDB is used for development.



Database schema is managed using Entity Framework Core migrations.



\---



\## How to Run



Prerequisites:



Visual Studio 2022

.NET 8 SDK

SQL Server LocalDB



Steps:



1\. Clone repository



2\. Restore packages



dotnet restore



3\. Create database



dotnet ef database update



4\. Run application



dotnet run



5\. Open browser



\[https://localhost:xxxx/Contact](https://localhost:xxxx/Contact)



\---



\## Notes



Search functionality allows filtering contacts by first name, last name or email.



Validation is implemented using DataAnnotations.



Async database calls are used to improve scalability.



\---



