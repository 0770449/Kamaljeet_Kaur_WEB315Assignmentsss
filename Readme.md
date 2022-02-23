dotnet new webapp -o KamalSelectedBag
code -r KamalSelectedBag
Added Project:Kamaljeet_Kaur__WEB315Assignments1
Change directory:  cd .\KamalSelectedBag\
Add NuGet packages and EF tools

dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer


dotnet-aspnet-codegenerator razorpage -m Bag -dc KamalSelectedBagContext -udl -outDir Pages/Bags --referenceScriptLibraries -sqlite
dotnet ef migrations add InitialCreate
dotnet ef database update
