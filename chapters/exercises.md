## 6. Exercises

Goal: You should make exercises at the end of each chapter or subchapter where there is an Exercise indication.
You should have enought articles and links in each chapter to implement each exercise.

Advise: Group the logic into service classes which implement interfaces and expose service logic through controllers.
Use the swagger helper page of the projects to test the API.

At the end, ideally, you should have a solution with 2 projects.
One project will be a web api rest api, which will expose more controllers and their coresponding services, for example:
ProductInMemoryController - operations for saving products in memory.
ProductCategoriesInMemoryController - operations for saving products categories in memory.
ProductFileController - operations to save products in files.
ProductADOSqlController -  operations for the products to be saved in  a Sql Database using ADO.Net
ProductsEFController - operations for the products to be saved in  a Sql Database using Entity Framework core.
ProductCategoryMongoController - operations for the product categories which will be stored in MongoDb.

A test project where you will have a couple of unit tests.

  > Register an account on GitHub and accept the training [GitHub Classroom Assignment](https://classroom.github.com/a/EqvB8FNL). This will create a new GitHub repository for you. Clone this repository locally and checkout the `develop` branch. During the course of the training, you will commit and push your work on this branch.
  > On this repo you will create you app from scratch.
