# IT Ticket System

A simple IT support ticket management system. This project helps IT departments handle support tickets, assign them to technicians, and track their status.

---

## 📁 Project Structure

- **Database:**  
  `IT_ticket_system.bak` — SQL Server backup file.  
- **Application:**  
  Source code for the backend and frontend. Check folders for controllers, views, models, etc.

---

## ⚙️ Requirements

- **Backend:** .NET Core SDK (version X.X — replace with your version)
- **Database:** Microsoft SQL Server
- **IDE:** Visual Studio / Visual Studio Code
- **Package Manager:** NuGet

---

## 🗄️ Restore the Database

1. Open **SQL Server Management Studio (SSMS)**.
2. Create a new database named `IT_ticket_system` (or any name you prefer).
3. Right-click the new database → **Tasks** → **Restore** → **Database**.
4. Choose **Device**, then select the `.bak` file.
5. Restore it. Verify that the tables, stored procedures, and data exist.

---

## 🚀 Running the Application

Clone this repository:
  
   git clone https://github.com/Fiki1910/IT_ticket_system.git

    Open the solution in Visual Studio.

    Update the connection string in appsettings.json (or web.config if it’s an older project) to match your SQL Server instance. Example:

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=IT_ticket_system;Trusted_Connection=True;"
}

Restore NuGet packages:

dotnet restore

Build the project:

dotnet build

Run the project:

    dotnet run

    Open your browser and navigate to http://localhost:5000 (or the port specified).

📌 Features

    Create and submit support tickets

    Assign tickets to IT staff

    Update ticket statuses

    View ticket history and details

✅ Possible improvements for the future

    Add authentication and role-based access.

    Improve the UI design.

    Add email notifications for ticket updates.

    Write unit and integration tests.
