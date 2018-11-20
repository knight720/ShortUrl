# ShortUrl

* ­º­¶ http://{host}
* µuºô§} http://{host}/{code}

# Enviornment

* Database  
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=?' -e 'MSSQL_PID=Express' -p 1433:1433 -d mcr.microsoft.com/mssql/server:latest

** Code First  
*** PowerShell  
Add-Migration InitialCreate  
Update-Database  
*** CLI  
dotnet ef migrations add InitialCreate  
dotnet ef database update  

** Database First  
Scaffold-DbContext "Server=localhost;atabase=UrlDB;User ID=?;Password=?;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models  

# Reference
[Develop .NET Core Apps in a Container](https://hub.docker.com/r/microsoft/dotnet/)

[C# GetHashCode()](http://www.30abysses.com/TWY/2016/11/21/index.html)

[ASP.NET Core Dependency Injection](https://blog.johnwu.cc/article/ironman-day04-asp-net-core-dependency-injection.html)

[Official images for Microsoft SQL Server on Linux for Docker Engine.](https://hub.docker.com/r/microsoft/mssql-server/)