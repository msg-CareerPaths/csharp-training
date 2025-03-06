## 4.2. Microsoft SQL Server connection using Entity Framework

**Goal:** Understanding how to use Entity Framework to connect and make CRUD operation to an SQL Server database.

**Required Reading:** 

Entity Framework (EF) is an object-relational mapping (ORM) framework for .NET applications. It is a part of the ADO.NET family of technologies and provides a high-level abstraction for working with databases. With EF, developers can work with data in terms of entities and relationships, rather than tables and SQL statements.

Entity Framework consists of several components:  
 - ObjectContext: The ObjectContext is the primary entry point for working with data using EF. It represents a connection to a database and provides methods for querying, updating, and saving data.
 - DbContext: DbContext is a simplified version of ObjectContext and provides a more intuitive and developer-friendly way to work with EF. It is the preferred way to work with EF in modern .NET applications.
 - Entity Data Model: The Entity Data Model (EDM) is a conceptual model that represents the structure of data in a database. It includes entities, relationships, and mappings between entities and database tables.
 - LINQ to Entities: EF supports Language-Integrated Query (LINQ) for querying data using a strongly-typed syntax.
 - Code First: Code First is a way to create database schemas from C# classes. It allows developers to define their data model using classes, and EF automatically creates the database schema based on these classes.
 - Database Migrations: EF allows developers to make changes to the database schema over time using database migrations. Migrations allow developers to update the database schema while preserving existing data.    

[Entity Framework](https://learn.microsoft.com/en-us/ef/core/) supports multiple database providers, including Microsoft SQL Server, Oracle, MySQL, PostgreSQL, and SQLite, among others. It is a powerful and flexible ORM that can significantly reduce the amount of code needed to work with databases in .NET applications.

**Exercise:**

If you do not have an SQL Server installed, you will need to install it on your machine.
Here are 2 ways to install the SQL Server :  
 - You can use the [SQL Server 2022 Developer](https://www.microsoft.com/en-us/sql-server/sql-server-downloads),
 - If you prefer docker desktop you can use [this](https://www.youtube.com/watch?v=fFpDf5si_Hw) approach.  

  For Sql Server management you can use :
 - The [SQL Server Data Tools](https://learn.microsoft.com/en-us/sql/ssdt/how-to-connect-to-a-database-and-browse-existing-objects?view=sql-server-ver16) from Visual Studio
 - [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)
   or
 - [Azure Data Studio](https://learn.microsoft.com/en-us/azure-data-studio/download-azure-data-studio?tabs=win-install%2Cwin-user-install%2Credhat-install%2Cwindows-uninstall%2Credhat-uninstall)
[Here](https://www.youtube.com/watch?v=SryQxUeChMc) you have an example how to get started with the entity framework core.  
Add and adapt to your project all models from the video guide.    
You should watch the video until minute 11:05 to create models,context and add\update migrations.  
Next,check [this](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-7.0&tabs=visual-studio#scaffold-a-controller) article's "Scaffold a controller" paragraph.   
At this point, you will now have a new product controller whick calls the product context for all CRUD operations.  
Use the SqlSConnectionString property from the SqlSettings class to configure the sql connection in the product order db context.  
Build, run and debug the application and test it to see if records are persisted in the product table on the sql server.  

**Further Resources:**

* [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
* [CRUD with a .NET 6 Web API & Entity Framework Core](https://www.youtube.com/watch?v=Fbf_ua2t6v4)
* [Compare and contrast ADO and Entity Framework](https://blog.devart.com/ado-net-vs-entity-framework.html)
* [Getting Started with Entity Framework Core](https://www.youtube.com/watch?v=SryQxUeChMc)
* [Working with an existing Database](https://www.youtube.com/watch?v=DCYVfLT5_QI)
* [Other Database Providers : SQLite , PostGresSQL , AzureCosmoDB](https://www.youtube.com/watch?v=moRmKo3nrN4)
* [Best Practices in Using the DbContext in EF Core](https://blog.devart.com/best-practices-in-using-the-dbcontext-in-ef-core.html)
