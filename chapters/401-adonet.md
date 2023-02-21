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

Use the following links and checck how to use ado.net:
 - [Create Records... check the Create method from HomeController](https://www.yogihosting.com/create-records-ado-net-aspnet-core/)
 - [Read Records...check the Index method from HomeController](https://www.yogihosting.com/read-records-ado-net-aspnet-core/)
 - [Update Records ...check the Update method from HomeController](https://www.yogihosting.com/update-records-ado-net-aspnet-core/)
 - [Delete Records...check the Delete method from HomeController](https://www.yogihosting.com/delete-records-ado-net-aspnet-core/)
 - [SqlBulkCopy class of ADO.NET](https://www.yogihosting.com/sqlbulkcopy-class-of-ado-net/)

**Exercise:**

If you do not have an SQL Server installed, you will need to install it on your machine.
Here are 2 ways to install the SQL Server :
 - You can use the [SQL Server 2022 Developer](https://www.microsoft.com/en-us/sql-server/sql-server-downloads),
and the [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)

 - If you prefer docker desktop you can use [this](https://blog.devgenius.io/run-microsoft-sql-in-minutes-using-docker-desktop-4e31f5e23083) approach.
 
After installing the SQL Server create an new database with a table where you can save products.
You can create a new table by running the following script in the Sql Server Management Studio.

CREATE TABLE [dbo].[products_ado](  
	[ID] [int] IDENTITY(1,1) PRIMARY KEY,  
	[Name] [nvarchar](50) NULL,  
	[Description] [nvarchar](max) NULL,  
	[Price] [decimal](18, 2) NULL,  
	[Weight] [decimal](18, 2) NULL  
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]  
  
Next you should update the application so that products are stored in SQL database using ADO.Net.  
Create a new products controller and service.  
To set the SQL connection string and table name in the service class ,use the SqlSettings with the 2 properties ConnectionString and ProductTableName loaded from the appsettings.json file, which you already created in the exercise from a previous [chapter](https://github.com/msg-CareerPaths/csharp-training/blob/main/chapters/206-configuration.md).    

Build and run the application, call all methods and check to see if the product table is updated accordingly on the sql server.

**Further Reading:**

 - [How to Use ADO .NET in ASP MVC .NET 6 Core application](https://www.youtube.com/watch?v=QN4gKyCEzHA)
 - [ADO.NET Tutorial For Beginners and Professionals](https://dotnettutorials.net/lesson/what-is-ado-net/)