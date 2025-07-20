IT Ticket System

A simple system for creating and managing IT support tickets.


🗄️ Restore the Database

1. Open **SQL Server Management Studio (SSMS)**.
2. Create a new database named `IT_ticket_system` (or any name you prefer).
3. Right-click the new database → **Tasks** → **Restore** → **Database**.
4. Choose **Device**, then select the `.bak` file.
5. Restore it. Verify that the tables, stored procedures, and data exist.

🚀 How to Run the Application:

   1. Clone this repository
    git clone https://github.com/Fiki1910/IT_ticket_system.git

   2. Open the solution in Visual Studio.

   3. Update the connection string in appsettings.json (or web.config if it’s an older project) to match your SQL Server instance. Example:
    "ConnectionStrings": { "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=IT_ticket_system;Trusted_Connection=True;" }
    The Database folder contains a .bak file — restore it using SQL Server Management Studio to create the database.

   4. Restore NuGet packages:
    dotnet restore

   5. Build the project:
    dotnet build

   6. Run the project:
    dotnet run

   7. Open your browser and navigate to http://localhost:5000 (or the port specified in your configuration).

📂 Project Structure

    Database/ — Contains the .bak database backup file

    Controllers/, Models/, Views/ — Source files for the ASP.NET Core MVC application

    appsettings.json — Configuration file with the database connection string

✅ Requirements

    .NET SDK

    Visual Studio (or Rider / VS Code)

    SQL Server (e.g. Express) + SSMS to restore the .bak database
