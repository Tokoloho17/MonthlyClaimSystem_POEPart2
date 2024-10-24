Contract Monthly Claim System (CMCS)
Overview
The Contract Monthly Claim System (CMCS) helps lecturers submit their monthly claims easily. It allows Programme Coordinators and Academic Managers to review and approve these claims. The system also has features to upload documents and track the status of each claim in a clear and organized way.

Features
Submit Claims: Lecturers can enter details like hours worked, hourly rate, and any extra notes when submitting a claim.
Document Upload: Lecturers can upload supporting documents like .pdf, .docx, and .xlsx with their claims.
Claim Approval: Programme Coordinators and Academic Managers can see all pending claims and choose to approve or reject them.
Track Claims: Users can easily see if a claim is "Pending," "Approved," or "Rejected."
Real-Time Updates: The status of claims changes immediately when approved or rejected.
Technologies Used
ASP.NET Core MVC for building the website.
Entity Framework Core to manage the database.
Bootstrap for making the website look nice and responsive.
In-Memory Database for testing.
Unit Testing with xUnit and Moq.
Folder Structure
Copy code
MonthlyClaimSystem_POEPart2/
│
├── Controllers/
│   └── ClaimsController.cs
├── Models/
│   ├── ApplicationDbContext.cs
│   └── Claim.cs
├── Views/
│   └── Claims/
│       ├── SubmitClaim.cshtml
│       ├── ManageClaims.cshtml
│       └── TrackStatus.cshtml
├── wwwroot/
│   ├── css/
│   └── js/
├── appsettings.json
├── Program.cs
└── Startup.cs
How to Get Started
What You’ll Need
.NET Core SDK (version 6.0 or later)
SQL Server Express (or any other SQL database)
Steps to Set It Up
Clone the project from GitHub:

bash
Copy code
git clone https://github.com/yourusername/MonthlyClaimSystem_POEPart2.git
Open the project folder:

bash
Copy code
cd MonthlyClaimSystem_POEPart2
Update the database connection string in appsettings.json:

json
Copy code
"ConnectionStrings": {
  "DefaultConnection": "data source=labG9AEB3\\SQLEXPRESS;initial catalog=YourDatabaseName;trusted_connection=true;TrustServerCertificate=true"
}
Restore the required packages:

bash
Copy code
dotnet restore
Apply database migrations:

bash
Copy code
dotnet ef database update
Run the project:

bash
Copy code
dotnet run
Running Unit Tests
To run the unit tests, use this command:

bash
Copy code
dotnet test
Error Handling
The system has good error handling to show helpful error messages when something goes wrong. This makes sure the system runs smoothly, even if there are problems.
