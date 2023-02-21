## 3.6. Configuration in ASP.NET Core

**Goal:** Understand how configurations can be made in .net.

**Required Reading:**

Application configuration in ASP.NET Core is performed using one or more configuration providers. Configuration providers read configuration data from key-value pairs using a variety of configuration sources:
- Settings files, such as appsettings.json
- Environment variables
- Azure Key Vault
- Azure App Configuration
- Command-line arguments
- Custom providers, installed or created
- Directory files
- In-memory .NET 

Check this link to lean more about [configuration in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-7.0)

**Exercise:**

For this exercise you will load settings from the appsettings.json file.  
Update the appsettings.json file and add a new section called SqlSettings with 2 properties ConnectionString and ProductTableName which will be used in the next practices to connect to an sql server.
Create a new class SqlSettings with 2 properties where to load the sql settings defined in the appsettings.json file. 
In Program.cs create a local SqlSettings variable where and load there settings from appsettings.json file.       
Add a log information in the program.cs to log ConnectionString and ProductTableName from SqlSettingssettings.  