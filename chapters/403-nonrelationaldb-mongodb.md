## 4.3. Non-relational database

**Goal:** Understanding the concept of a non-relational database and update project to integrate with MongoDB.

**Required Reading:** 

A non-relational database, also known as NoSQL (Not Only SQL) database, is a type of database that stores and retrieves data using non-tabular structures. Unlike relational databases, which use tables with predefined columns and rows to store data, non-relational databases use a variety of data models, including key-value, document, graph, and column-family.

Here are some examples of popular non-relational databases:  
 - MongoDB: A document-oriented database that stores data as BSON (Binary JSON) documents. MongoDB is widely used for web applications, real-time analytics, and caching.
 - Cassandra: A column-family database that is designed for high availability and scalability. It is used by companies such as Netflix, Twitter, and Apple.
 - Redis: A key-value store that is often used for caching and real-time messaging. It is known for its fast performance and support for advanced data types.
 - Neo4j: A graph database that is optimized for storing and querying graph data. It is commonly used for social networks, recommendation engines, and fraud detection.
 - Amazon DynamoDB: A fully managed NoSQL database that is designed for scalability and high availability. It is used by many companies to store and retrieve large amounts of data.


**Exercise:**

You need to have a MongoDb installed on your local machine.
Check [this](https://www.mongodb.com/docs/manual/tutorial/install-mongodb-on-windows/) article for help.  
Next, create a new class named ProductCategory with the following properties(string? Id,string Name,string description).   
Create a database called productsdb and a collection named categories that saves the product categories in mongodb.  
Create a new controller and service for the product categories.(Don't forget, the service must implement an interface).  
Update the project and add CRUD operations to the new controller.  
The MongoDB connections details,database name and collection name will be loaded from a new setting from the appsettings.json.  
You've allready made an similar exercise in this [chapter](https://github.com/msg-CareerPaths/csharp-training/blob/main/chapters/306-configuration.md).    
Build, run, debug and test the application.    
Check to see if data is persisted in the products collection from the mongodb.    

Use can use this link to see how to save data to [use a web API with ASP.NET Core and MongoDB](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-6.0&tabs=visual-studio) (ignore the authentication part).

**Further Resources:**

 - [Difference between a relational and a non-relational](https://www.integrate.io/blog/the-sql-vs-nosql-difference/).
