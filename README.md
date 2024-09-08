Task Management System
This project is a simple Task Management System built with ASP.NET MVC, Entity Framework (MSSQL), and RESTful API. The system supports user authentication, CRUD operations for tasks, and report generation.

Features
User login functionality
Task creation, editing, viewing, and deletion (CRUD)
Simple report generation
RESTful API endpoints for task operations
Prerequisites
Before running this project, ensure you have the following installed on your machine:

.NET SDK (version 6.0 or higher)
SQL Server or SQL Server Express
Visual Studio 2022 (or newer) with ASP.NET and web development workload installed
Git
Step-by-Step Instructions
1. Clone the Repository
First, clone the repository to your local machine using Git.

bash
Copy code
git clone https://github.com/YOUR_USERNAME/TaskManagementSystem.git
cd TaskManagementSystem
2. Open the Project in Visual Studio
Open Visual Studio.
Select File > Open > Project/Solution.
Navigate to the folder where you cloned the repository and open the .csproj file in the root directory of the project.
3. Configure Database
3.1 Set up Connection String
Open the appsettings.json file in the project root.
Edit the ConnectionStrings section with your SQL Server instance information:
json
Copy code
"ConnectionStrings": {
  "TaskManagementDb": "Server=YOUR_SERVER_NAME;Database=TaskManagementDb;Trusted_Connection=True;"
}
Replace YOUR_SERVER_NAME with the name of your SQL Server instance.
3.2 Apply Database Migrations
In Visual Studio, open the Package Manager Console (Tools > NuGet Package Manager > Package Manager Console) and run the following commands to create the database and apply migrations:

bash
Copy code
Update-Database
This will create the TaskManagementDb database and set up the required tables (like Tasks and Users).

4. Install Dependencies
Ensure that all required NuGet packages are installed. Right-click on your solution and select Manage NuGet Packages. Then, install the following NuGet packages if they aren't already installed:

Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
BCrypt.Net-Next
You can also install these packages via the NuGet Package Manager Console:

bash
Copy code
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package BCrypt.Net-Next
5. Build the Project
In Visual Studio, click Build > Build Solution or press Ctrl + Shift + B.
Ensure that the project builds successfully without any errors.
6. Run the Project
Press F5 or click the Start button to run the project.
The application should open in your default browser.
7. Use the Application
Register a new user through the Register page.
Log in with your credentials.
Once logged in, you can:
Create new tasks.
Edit, view, and delete tasks.
Generate a report of tasks.
