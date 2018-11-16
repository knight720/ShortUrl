# ShortUrl

* ­º­¶ http://{host}
* µuºô§} http://{host}/{code}

# Enviornment

* Database  
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=yourStrong(!)Password' -e 'MSSQL_PID=Express' -p 1433:1433 -d mcr.microsoft.com/mssql/server:latest
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=P@ssw0rd' -e 'MSSQL_PID=Express' -p 1433:1433 -d mcr.microsoft.com/mssql/server:latest

# Reference
[Develop .NET Core Apps in a Container](https://hub.docker.com/r/microsoft/dotnet/)

[C# GetHashCode()](http://www.30abysses.com/TWY/2016/11/21/index.html)

[ASP.NET Core Dependency Injection](https://blog.johnwu.cc/article/ironman-day04-asp-net-core-dependency-injection.html)

[Official images for Microsoft SQL Server on Linux for Docker Engine.](https://hub.docker.com/r/microsoft/mssql-server/)