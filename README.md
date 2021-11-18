# EvaPetsEF
Entity Framework project done in Mac Mini M1 processor.

Because .NET 6 is not available yet for Mac, I used EF5 with NET5

For using EF commands, it is necessary to follow the next steps:

1. Install Nuget CLI for MAC --> https://docs.microsoft.com/en-us/nuget/reference/nuget-exe-cli-reference
2. Restart VS
3. Install EF Commands --> https://docs.microsoft.com/en-us/ef/core/cli/dotnet#dotnet-ef-migrations-add
4. On Windows, follow this --> https://docs.microsoft.com/en-us/ef/core/cli/powershell

To run EF Commands, the Data folder should be located in terminal window, otherwise, it won't work. 


COMMANDS USED:
dotnet ef [shows EF version]
dotnet ef migrations script [generates migration script 20211117235324_init.cs]
dotnet ef database update init --verbose [firts, drop DB and after running this, everthing is created based on migration file]
dotnet ef dbcontext scaffold "Data Source=localhost;Initial Catalog=Store;User Id=sa;Password=Apto201." Microsoft.EntityFrameworkCore.SqlServer [create models and context from DB]
