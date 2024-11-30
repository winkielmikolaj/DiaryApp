Features 🚀
View Entries: See a list of all saved diary entries.
Create New Entries: Add new notes by providing a title, content, and date.
Edit Entries: Modify existing entries to fix errors or update information.
Delete Entries: Remove unnecessary or outdated notes.
Application UI 🎨
Diary Entries View

Project Structure 📂
Controllers: Application logic, responsible for processing user requests (e.g., DiaryEntriesController.cs).
Models: Contains data models such as DiaryEntry.cs.
Views: Razor views responsible for displaying the user interface:
Create.cshtml, Edit.cshtml, Delete.cshtml, Index.cshtml.
Data: Includes ApplicationDbContext.cs, which configures the database connection.
Technologies and Tools 🛠️
ASP.NET Core MVC: Web framework.
Entity Framework Core: Database access and operations.
C#: Programming language.
Bootstrap: For styling the user interface.
Running the Project 🖥️
Clone the repository:

Copy code
git clone https://github.com/your_username/DiaryApp.git
cd DiaryApp
Install dependencies:
Open the project in Visual Studio and install any missing NuGet packages if required.

Apply database migrations: Run the command:

bash
Copy code
dotnet ef database update
Run the application:
Click the run button in Visual Studio or use:

bash
Copy code
dotnet run
Database Structure 🗃️
The DiaryEntries table includes:

Id: Primary key.
Title: Entry title.
Content: Entry content.
Date: Entry date.
Author 📌
Name/Nickname: Mikołaj Winkiel
License: MIT
