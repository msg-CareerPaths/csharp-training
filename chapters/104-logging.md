## 1.4. Logging
Goal: Understand how logging libraries work and how to log the necessary information from your application

Required Reading:

 - [Logging in .Net Overview](https://docs.microsoft.com/en-us/dotnet/core/extensions/logging?tabs=command-line)
 - [Logging providers in .Net](https://docs.microsoft.com/en-us/dotnet/core/extensions/logging-providers)
 - The most used method to log your data is in files on disk. This is achieved in .Net by using a third party provider. While there are multiple providers we will focus on NLog:
   - [Getting started with Nlog in ASP.NET Core 6](https://github.com/NLog/NLog/wiki/Getting-started-with-ASP.NET-Core-6)
   - [How to start logging with NLog](https://betterstack.com/community/guides/logging/net/how-to-start-logging-with-nlog)
   - [Nlog Configuration file](https://github.com/NLog/NLog/wiki/Configuration-file)
   - [Nlog ASP.NET Core 6 Example](https://github.com/NLog/NLog.Web/tree/master/examples/ASP.NET%20Core%206)

Online Shop: Logging important actions (Order Product, Product create/edit/delete and so on) will greatly assist in the support and development of your application.
   
   - you need to identify and log all the important actions in your application
   
   - it is your decision how you structure and what information goes into those logs to be as comprehensive as possible

Future Reading:
 - [Logging Best Practices](https://raygun.com/blog/c-sharp-logging-best-practices/)
 - [How to use structured logging](https://github.com/nlog/nlog/wiki/How-to-use-structured-logging)
 - [Use NLog configuration with appsettings.json](https://github.com/NLog/NLog.Extensions.Logging/wiki/NLog-configuration-with-appsettings.json)