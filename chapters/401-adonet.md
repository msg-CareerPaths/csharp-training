## 4.1. ADO.NET

**Goal:** Understanding how to use ADO.NET to connect and make CRUD operation to an SQL Server database.

**Required Reading:**

The main components of ADO.NET are:  
 - Data Providers: A set of libraries that provide connectivity to specific databases. Examples include System.Data.SqlClient for SQL Server, System.Data.OracleClient for Oracle, and System.Data.OleDb for OLE DB-compliant data sources.  
 - Connection: A connection is a link between a .NET application and a database. Developers use the Connection class to establish and manage connections.  
 - Command: The Command class is used to execute SQL statements and stored procedures against a database.  
 - DataReader: The DataReader class provides a fast, read-only stream of data from a database. It is useful for retrieving large amounts of data quickly.  
 - DataSet: The DataSet class is an in-memory representation of a set of tables and relationships. It is useful for working with disconnected data, caching data, and updating data.  
 - DataAdapter: The DataAdapter class is used to populate a DataSet from a database and to update changes made to the DataSet back to the database.

Further, read this introduction [article](https://dotnettutorials.net/lesson/what-is-ado-net/) about ADO.NET.

**Exercise:**

If you do not have an SQL Server installed, you will need to install it on your machine.
Here are 2 ways to install the SQL Server :  
 - You can use the [SQL Server 2022 Developer](https://www.microsoft.com/en-us/sql-server/sql-server-downloads),  
 - If you prefer docker desktop you can use [this](https://blog.devgenius.io/run-microsoft-sql-in-minutes-using-docker-desktop-4e31f5e23083) approach.  

  For Sql Server management you can use :
 - The [SQL Server Data Tools](https://learn.microsoft.com/en-us/sql/ssdt/how-to-connect-to-a-database-and-browse-existing-objects?view=sql-server-ver16) from Visual Studio
 or   
 - [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)  
 
After installing the SQL Server create an new database with a table where you can save products.
You can create a new table by running this sql code in the preferred sql management tool:

	CREATE TABLE [dbo].[products_ado](  
		[ID] [int] IDENTITY(1,1) PRIMARY KEY,  
		[Name] [nvarchar](50) NULL,  
		[Description] [nvarchar](max) NULL,  
		[Price] [decimal](18, 2) NULL,  
		[Weight] [decimal](18, 2) NULL  
	) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]  
  
Next you should update the application so that products are stored in SQL database using ADO.Net.  
Create a new products controller and service.  
To set the SQL connection string and table name in the service class ,use the SqlSettings with the 2 properties ConnectionString and ProductTableName loaded from the appsettings.json file, which you already created in the exercise from a previous [chapter](https://github.com/msg-CareerPaths/csharp-training/blob/main/chapters/306-configuration.md).  
Use [Dependency Injection (DI) to access configuration]((https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-7.0#access-configuration-with-dependency-injection-di).) from a service.  
Add all CRUD operations for products.
Use the following links and check how to use ado.net for each operation:  
 - [Create Records... check the Create method code](https://www.yogihosting.com/create-records-ado-net-aspnet-core/)  
 - [Read Records...check the Index method code](https://www.yogihosting.com/read-records-ado-net-aspnet-core/)  
 - [Update Records ...check the Update method code](https://www.yogihosting.com/update-records-ado-net-aspnet-core/)  
 - [Delete Records...check the Delete method code](https://www.yogihosting.com/delete-records-ado-net-aspnet-core/)  

Build and run the application, call all methods and debug them to see how products are persisted in the sql server table.

**Further Resources:**
 
 - [SqlBulkCopy class of ADO.NET](https://www.yogihosting.com/sqlbulkcopy-class-of-ado-net/)
 - [How to Use ADO .NET in ASP MVC .NET 6 Core application](https://www.youtube.com/watch?v=QN4gKyCEzHA)
 - [ADO.NET Tutorial For Beginners and Professionals](https://dotnettutorials.net/lesson/what-is-ado-net/)
