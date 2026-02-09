# Garage Management System

A web-based Garage Management System built with **ASP.NET Core MVC** as part of the Basic course assignment.

The application allows garage staff to manage cars, owners, and employees through a clean dashboard interface with full CRUD functionality.

## Intended Use

The application is designed for use by a **garage receptionist or administrative staff**, focusing on simplicity, clarity, and ease of use.


## Features

- Dashboard overview with garage statistics
- Manage Cars (Create, Read, Update, Delete)
- Manage Owners (Create, Read, Update, Delete)
- Manage Employees (Create, Read, Update, Delete)
- Entity relationships between Cars and Owners
- Dark mode / Light mode toggle
- Responsive UI using Bootstrap


## Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Bootstrap
- HTML, CSS
- Git & GitHub


## Entity Models

The system includes the following entity models:

- **Car**
- **Owner**
- **Employee**

Relationships:
- A Car belongs to one Owner
- An Owner can have multiple Cars


## Controllers

- HomeController (Dashboard)
- CarsController
- OwnersController
- EmployeesController


## Development Notes

Some UI enhancements, including the Dark Mode implementation, were developed with assistance from AI tools.  
All code was reviewed, understood, and integrated manually as part of the learning process and to explore modern workflows.



## How to Run the Project

1. Clone the repository:
   ```bash
   git clone <your-repo-url>

2. Open the solution in Visual Studio

3. Update the connection string in appsettings.json

4. Run database migrations:

dotnet ef database update

5. Run the app!

###
NOTE
In order to create a Car, you must first create an Owner as every car MUST have one


## Author

Created by Plamen Kuzev  
2026
