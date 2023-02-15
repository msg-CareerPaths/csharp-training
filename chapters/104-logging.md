## 1.4. Logging
Goal: Understand how logging libraries work and how to log the necessary information from your application.
The logging informations are vast so don't go to deep in the articles, just try to undestand how to create a nlog.file and update it to log information in log files.

Required Reading:
 - [Logging in .Net Overview](https://docs.microsoft.com/en-us/dotnet/core/extensions/logging?tabs=command-line)
 - [Logging providers in .Net](https://docs.microsoft.com/en-us/dotnet/core/extensions/logging-providers)
 - The most used method to log your data is in files on disk. This is achieved in .Net by using a third party provider. While there are multiple providers we will focus on NLog:
 - [Getting started with Nlog in ASP.NET Core 6](https://github.com/NLog/NLog/wiki/Getting-started-with-ASP.NET-Core-6)
 - [Nlog Configuration file](https://github.com/NLog/NLog/wiki/Configuration-file)
 - [Nlog ASP.NET Core 6 Example](https://github.com/NLog/NLog.Web/tree/master/examples/ASP.NET%20Core%206)

Exercise:
   Add a new nlog.config file to the application.
   Log some actions from the product controller like : Product get/create/edit/delete as will greatly assist in the support and debug of your application.
   It is your decision how you structure and what information goes into those logs to be as comprehensive as possible.
   You can play a bit and add some other logging where you think it whould be more usefull.
   Update the nlog.config file so log files to be saved in folder " logs/${shortdate} " , change the format(layout) of the log files names, and rerun the application to check the new folder/file formats.

Future Reading:
 - [Elastic Stack - Log Management System](https://www.elastic.co/what-is/elk-stack)
 - [Logging Best Practices](https://raygun.com/blog/c-sharp-logging-best-practices/)
 - [How to use structured logging](https://github.com/nlog/nlog/wiki/How-to-use-structured-logging)
 - [Use NLog configuration with appsettings.json](https://github.com/NLog/NLog.Extensions.Logging/wiki/NLog-configuration-with-appsettings.json)