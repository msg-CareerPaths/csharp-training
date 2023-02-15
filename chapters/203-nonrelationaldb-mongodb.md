## 2.3. Non-relational database

Goal: 
Understanding the __[difference between a relational and a non-relational](https://www.integrate.io/blog/the-sql-vs-nosql-difference/)__ database and adapting the OnlineShop Web Api to have persistence into a NoSql model database such as MongoDb.

Required Reading:
 - [Create a web API with ASP.NET Core and MongoDB](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-6.0&tabs=visual-studio)

Prerequisites:
You need to have a MongoDb install on your local machine.Check [this](https://www.mongodb.com/docs/manual/tutorial/install-mongodb-on-windows/) article for help.

Exercise: 
After installing the MongoDB ,create a database called productsdb and a collection named categories that saves the product categories in mongodb.
The MongoDB connections details,database name and collection name will be loaded from a new setting from the appsettings.json.(You've allready made an similar exercise in [1.3 Chapter](https://github.com/msg-CareerPaths/csharp-training/blob/main/chapters/103-configurations.md).
In the project add a new service,controller and interface that will be use to make CRUD operations on the mongo DB.
Build, run,debug  and test the application.
Check to see if operations made from the MongoDBController are persisted in the products collection from the mongodb.

Further Reading:
* [Build Your First .NET Core Application with MongoDB Atlas](https://www.mongodb.com/developer/languages/csharp/build-first-dotnet-core-application-mongodb-atlas/)
* [Create a RESTful API with .NET Core and MongoDB](https://www.mongodb.com/developer/how-to/create-restful-api-dotnet-core-mongodb/)