## 1.3. Configuration in ASP.NET Core

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

Goal: 
- Understand how configurations can be made in .net

Required Reading: 
- [Configuration in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-7.0)
- [Options pattern in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-7.0)

Products App:
- Update the appsettings.json file and add a new section called ApplicationSettings which will contain the UseFileStoring boolean property.
- Go to folder and add a new class called ApplicationSettings which will have a boolean property called UseFileStoring.
- Update the Program.cs so that ApplicationSettings.UseFileStoring is loaded and from appsettings.json.
