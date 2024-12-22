dotnet new razor -o <ProjName> -f net7.0 --auth Individual

> create models

dotnet add package Microsoft.EntityFrameworkCore.Sqlite

> add DbContext Models DbSets

dotnet tool install --global dotnet-ef

dotnet ef migrations add v1
dotnet ef database update

dotnet tool install -g dotnet-aspnet-codegenerator

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

dotnet aspnet-codegenerator razorpage -m Student -dc MinimalCrud.Data.ApplicationDbContext -udl -outDir 
Pages/Students --referenceScriptLibraries --databaseProvider SQLite Index List


dotnet aspnet-codegenerator razorpage -m Premium -dc MinimalCrud.Data.ApplicationDbContext -udl -outDir Pages/Premiums --referenceScriptLibraries --databaseProvider SQLite Details Details

--- 
entire crud scenario

dotnet aspnet-codegenerator razorpage -m Student -dc MinimalCrudMvc.App.Data.ApplicationDbContext -udl -outDir Pages/Students --referenceScriptLibraries --databaseProvider SQLite -udl