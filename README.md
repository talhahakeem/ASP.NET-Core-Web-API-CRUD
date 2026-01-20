# ASP.NET Core Web API - Student Management System

A robust RESTful API designed to manage student records efficiently. Built using **.NET 8**, **Entity Framework Core (Code-First)**, and **SQL Server**.

## 🚀 Tech Stack
* **Framework:** ASP.NET Core Web API (.NET 8)
* **Database:** SQL Server
* **ORM:** Entity Framework Core
* **Tools:** Swagger UI, Postman

## ✨ Features
* **Create Student:** Add new student records with details (Name, Email, Phone, Fees).
* **Read Data:** Fetch all students or search for a specific student by ID.
* **Update Records:** Modify existing student details.
* **Delete Records:** Remove student data from the database.
* **Swagger Integration:** Interactive API documentation included.

## 🛠️ How to Run Locally

1.  **Clone the Repository**
    ```bash
    git clone [https://github.com/talhahakeem/ASP.NET-Core-Web-Api-CRUD.git](https://github.com/talhahakeem/ASP.NET-Core-Web-Api-CRUD.git)
    ```

2.  **Configure Database**
    Update the connection string in `appsettings.json` if necessary.

3.  **Run Migrations**
    Open Package Manager Console and run:
    ```powershell
    Update-Database
    ```

4.  **Run the Application**
    Press `F5` or `Ctrl + F5` in Visual Studio.
    Navigate to `https://localhost:7xxx/swagger` to test the API.

## 🔗 API Endpoints

| Method | Endpoint | Description |
| :--- | :--- | :--- |
| `GET` | `/api/students` | Get all students |
| `GET` | `/api/students/{id}` | Get student by ID |
| `POST` | `/api/students` | Add a new student |
| `PUT` | `/api/students/{id}` | Update a student |
| `DELETE` | `/api/students/{id}` | Delete a student |

---
**Developed by Muhammad Talha Hakeem**
