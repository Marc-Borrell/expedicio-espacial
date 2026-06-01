# Gestor de Expediciones Espaciales

![Static Badge](https://img.shields.io/badge/C%23-%23239120?style=for-the-badge&logo=csharp)
![Static Badge](https://img.shields.io/badge/.NET-8-0080FF?style=for-the-badge&logo=dotnet)
![Static Badge](https://img.shields.io/badge/Windows%20Forms-blue?style=for-the-badge)
![Static Badge](https://img.shields.io/badge/MySQL-4479A1?style=for-the-badge&logo=mysql)

## Description

This is a desktop application developed in **C#** using **Windows Forms** and **.NET 8**.  
The application allows users to register and log in to manage a system for space expeditions.  

It features a **user registration system**, login authentication, and connects to a **MySQL database** to store user information.  
The system uses **parameterized SQL queries** to prevent SQL injection.

The application is designed for desktop use, providing a simple and intuitive interface for managing users.

## Set Up

### Requirements

Before running the project, make sure you have the following software installed:

- Visual Studio 2022 or newer
- .NET 8 SDK
- MySQL Server
- MySQL Connector/NET

### Installation

1. Clone the repository:

```bash
git clone https://github.com/Marc-Borrell/expedicio-espacial.git
```

2. Open the solution (.sln) in Visual Studio.
3. Restore NuGet packages if prompted (MySql.Data is required).
4. Configure your database connection in the Database class.
5. Build the project by selecting Build > Build Solution.
6. Run the application by clicking Start in Visual Studio.

## Features

- User registration with password confirmation.
- Login authentication.
- SQL queries with parameterized statements.
- Windows Forms UI with masked password fields.
- Password show/hide toggle.
- Error handling and user-friendly messages.

## Technologies Used
- C#
- .NET 8
- Windows Forms
- MySQL
- MySql.Data (ADO.NET)

## DEMO
<p>Main section</p>


<img width="851" height="550" alt="image" src="https://github.com/user-attachments/assets/d63e0b22-3bbb-4702-b616-1f3da1bf957a" />

<p>Sign up section</p>

<img width="813" height="540" alt="image" src="https://github.com/user-attachments/assets/39e276e6-df57-4426-8480-f08a47eb9dbe" />

<p>Spaceships CRUD</p>

<img width="790" height="467" alt="image" src="https://github.com/user-attachments/assets/af8faf77-8f0c-4c0e-adda-d667a64f2a0e" />
<p>Astronatus CRUD</p>

<img width="799" height="479" alt="image" src="https://github.com/user-attachments/assets/801c3c3c-2c96-4d89-ba71-34f02ba8073a" />
<p>Expeditions CRUD</p>

<img width="764" height="560" alt="image" src="https://github.com/user-attachments/assets/3ee800fa-39cc-405b-9658-d501b7263281" />





