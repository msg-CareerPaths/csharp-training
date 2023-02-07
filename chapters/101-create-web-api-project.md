## 1.1. Create Web API project
   For the first chapter please create a simple Web API using .Net Core.
   To create the application open Visual Studio, choose a Create a New Project, Select ASP.NET Core Web API project and follow the steps. Please check the following the images to select the right options: 
   ![Data Model](https://github.com/msg-CareerPaths/csharp-training/blob/main/Sources/Chapter1/Startup_Chapter/OnlineOrder/Startup_Chapter/ScreenShots/1.jpg)
   and 
   ![Data Model](https://github.com/msg-CareerPaths/csharp-training/blob/main/Sources/Chapter1/Startup_Chapter/OnlineOrder/Startup_Chapter/ScreenShots/2.jpg)

   As a default project you will you probably have a weather forecast example.
   Check all the files from the project and get familiar with the structure and the classes.
   Check the WeatherForecastController from the Controllers folders.
   Open the Program.cs file to see how then application is created and started.
   Build and start the application.

   As a start-up sample, you have in the project created with one class implemented.
   [https://github.com/msg-CareerPaths/csharp-training/tree/main/Sources/Chapter1/Startup_Chapter/OnlineOrder/Startup_Chapter/OnlineOrder] 
   
   For the moment the products  will be stored in a list in the productservice.
   The same with the product category list, you will have a list defined in the product category service.
   The lists will be repopulated each time you start the project, so it`s there is no persistance.
   If you want you can initiate the lists to have some on the application startup.

   Add methods to cover all CRUD operation for the products.
   You should create the rest of the data models and add a new controller for the product categeories.
   The classes structure are shown in below diagram: 
  ![Data Model](https://github.com/msg-CareerPaths/csharp-training/blob/main/diagrams/Chapter1.png "Data Model")
 
Products App:
   1. Add methods to cover all CRUD operation for the products.
   2. Create a new class called ProducCategory in the model folder.
   3. Add a new property of type ProducCategory to the product class.
   4. Create a new product category controller and service.
      The product category list will be stored in the service, similar with the product list.


  > Register an account on GitHub and accept the training [GitHub Classroom Assignment](https://classroom.github.com/a/qiaU7uWM). This will create a new GitHub repository for you. Clone this repository locally and checkout the `develop` branch. During the course of the training, you will commit and push your work on this branch.
 > to "Visual Studio" and generate a new project ASP.NET Core Web API:
 > 
 > Go- Project name: `productsapp`,
 > - Solution: `ro.msg.learning`,