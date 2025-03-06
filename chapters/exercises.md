## Exercises

You should make exercises at the end of each chapter or subchapter where there is an Exercise indication.  
When doing exercises, you can add the new functionality by creating new controllers to the application.  

At the end, ideally, you should have a solution with 2 projects:  
 - One project will be a backend rest web api, which will expose more controllers and their corresponding services, for example:  
   - ProductInMemoryController - operations for saving products in memory.  
   - ProductCategoriesInMemoryController - operations for saving products categories in memory.  
   - ProductFileController - operations for saving products in files.  
   - ProductsEFController - operations for the products to be saved in a Sql Database using Entity Framework core.  
   - ProductCategoryMongoController - operations for the product categories which will be stored in MongoDb.  

 - A second test project where you will have a couple of unit tests.  
