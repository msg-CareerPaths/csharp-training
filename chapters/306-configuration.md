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
 
 [Learn more about configuration in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-7.0)

**Exercise:**

For this exercise you will load settings from the appsettings.json file.  
Update the appsettings.json by adding a new section called SqlSettings with 2 properties ConnectionString and ProductTableName, which you will be used later in the next chapters to connect to an sql server.  
Create the coresponding SqlSettings class were you will load the settings from the appsettings.json file.  
Update the Program.cs to load the SqlSettings from appsettings.json file, and log this information in log file.


**Further Resources:**

 - [How to Read AppSettings Values From a JSON File in .NET Core](https://code-maze.com/aspnetcore-read-appsettings-values-from-a-json-file/)




