## 2.2. Entity Framework
Goal: Understanding how and why Entity Framework can be used to automate all types of SQL database-related activities for an application, and how using the frameowrk developers can work at a higher level of abstraction when they deal with data and can create and maintain the data-oriented application with less code and database-related knowledege.

Required Reading: 
[Entity Framework Core] (https://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx)

Products api:
You should have an project which create/update an SQL Server database from code using EF Core migrations that mir

[Here](https://www.youtube.com/watch?v=SryQxUeChMc) you have an example how to get started with the entity framework core.
Update your existing project or create a new ASP NET CORE web project by adding all Models from the video guide.
You should watch the video until minute 11:05 to create models,context and add\update migrations.
Next step is to create a controller.
Check [this](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-7.0&tabs=visual-studio) article's "Scaffold a controller" paragraph.
You will use the SqlSConnectionString property from the SqlSettings class to configure the EF sql connection in the product context.

Build, run and debug the application and test it to see if records are persisted in the product table on the sql server.

Further Reading:
* [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
* [CRUD with a .NET 6 Web API & Entity Framework Core](https://www.youtube.com/watch?v=Fbf_ua2t6v4)
* [Compare and contrast ADO and Entity Framework](https://blog.devart.com/ado-net-vs-entity-framework.html)
* [Getting Started with Entity Framework Core](https://www.youtube.com/watch?v=SryQxUeChMc)
* [Working with an existing Database](https://www.youtube.com/watch?v=DCYVfLT5_QI)
* [Other Database Providers : SQLite , PostGresSQL , AzureCosmoDB](https://www.youtube.com/watch?v=moRmKo3nrN4)