## 1.3. Configuration in ASP.NET Core
Goal: 
- Understand how configurations can be made in .net

Application configuration in ASP.NET Core is performed using one or more configuration providers. Configuration providers read configuration data from key-value pairs using a variety of configuration sources:
- Settings files, such as appsettings.json
- Environment variables
- Azure Key Vault
- Azure App Configuration
- Command-line arguments
- Custom providers, installed or created
- Directory files
- In-memory .NET 

For the online shop exercise you will load settings from the appsettings.json file.

Required Reading: 
- [Configuration in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-7.0)

Exercise:
- Update the appsettings.json file and add a new section called SqlSettings with 2 properties ConnectionString and ProductTableName which will be used in the next practices to connect to an sql server.
- On Program.cs create a local SqlSettings variable where you will load the SqlSettings ConnectionString and ProductTableName the appsettings.json file.(https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-7.0).
- Add a log information in the program.cs to log the SqlSettings settings.
