## 2.2. Entity Framework

**Goal:**

Understanding how and why Entity Framework can be used to automate all types of SQL database-related activities for an application, and how using the frameowrk developers can work at a higher level of abstraction when they deal with data and can create and maintain the data-oriented application with less code and database-related knowledege.

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

[Here](https://www.youtube.com/watch?v=SryQxUeChMc) you have an example how to get started with the entity framework core.
Add to your project all models from the video guide.
You should watch the video until minute 11:05 to create models,context and add\update migrations.
Next step is to create a new controller ProductsEFController.
Check [this](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-7.0&tabs=visual-studio) article's "Scaffold a controller" paragraph.
Use the SqlSConnectionString property from the SqlSettings class to configure the EF sql connection in the product context.

Build, run and debug the application and test it to see if records are persisted in the product table on the sql server.

**Further Resources:**

* [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
* [CRUD with a .NET 6 Web API & Entity Framework Core](https://www.youtube.com/watch?v=Fbf_ua2t6v4)
* [Compare and contrast ADO and Entity Framework](https://blog.devart.com/ado-net-vs-entity-framework.html)
* [Getting Started with Entity Framework Core](https://www.youtube.com/watch?v=SryQxUeChMc)
* [Working with an existing Database](https://www.youtube.com/watch?v=DCYVfLT5_QI)
* [Other Database Providers : SQLite , PostGresSQL , AzureCosmoDB](https://www.youtube.com/watch?v=moRmKo3nrN4)
