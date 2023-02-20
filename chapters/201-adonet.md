## 2.1. ADO.NET
Goal:   
Understanding how ADO.NET provides consistent access to data sources such as SQL Server and how data-sharing consumer applications can use ADO.NET to connect to these data sources and retrieve, handle, and update the data that they contain.

Required Reading: 
 - [Learn ADO.NET by building CRUD features in ASP.NET Core Application](https://www.yogihosting.com/ado-net-aspnet-core/)
 - [Create Records... go to the Create method from HomeController](https://www.yogihosting.com/create-records-ado-net-aspnet-core/)
 - [Read Records...go to the Index method from HomeController](https://www.yogihosting.com/read-records-ado-net-aspnet-core/)
 - [Update Records ...go to the Update method from HomeController](https://www.yogihosting.com/update-records-ado-net-aspnet-core/)
 - [Delete Records...go to the Delete method from HomeController](https://www.yogihosting.com/delete-records-ado-net-aspnet-core/)
 - [SqlBulkCopy class of ADO.NET](https://www.yogihosting.com/sqlbulkcopy-class-of-ado-net/)

Prerequisites:  
If you do not have an SQL Server installed, you will need to install it on your machine.
Here are 2 ways to install the SQL Server :
 - You can use the [SQL Server 2022 Developer](https://www.microsoft.com/en-us/sql-server/sql-server-downloads),
and the [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)

 - If you prefer docker desktop you can use this approach : https://blog.devgenius.io/run-microsoft-sql-in-minutes-using-docker-desktop-4e31f5e23083

Exercise:  
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
To set the SQL connection string and table name in the service class ,use the SqlSettings with the 2 properties ConnectionString and ProductTableName loaded from the appsettings.json file, which you already created in the exercise from [1.6 Chapter](https://github.com/msg-CareerPaths/csharp-training/blob/main/chapters/106-configuration.md).  

Build and run the application, call all methods and check to see if the product table is updated accordingly on the sql server.

Further Reading:
 - [How to Use ADO .NET in ASP MVC .NET 6 Core application](https://www.youtube.com/watch?v=QN4gKyCEzHA)
 - [ADO.NET Tutorial For Beginners and Professionals](https://dotnettutorials.net/lesson/what-is-ado-net/)
