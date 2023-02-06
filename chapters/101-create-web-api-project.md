## 1.1. Create Web API project
   For the first chapter please create a simple Web API using .Net Core.
   To create the application open Visual Studio, choose a Create a New Project, Select ASP.NET Core Web API project and follow the steps. Please check the following the images to select the right options: 
   ![Data Model](https://github.com/msg-CareerPaths/csharp-training/blob/main/Sources/Chapter1/Startup_Chapter/OnlineOrder/Startup_Chapter/ScreenShots/1.jpg)
   and 
   ![Data Model](https://github.com/msg-CareerPaths/csharp-training/blob/main/Sources/Chapter1/Startup_Chapter/OnlineOrder/Startup_Chapter/ScreenShots/2.jpg)

   You can also use this link as helpm you can omit the
   https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-7.0&tabs=visual-studio


   As a default project you will you probably have a weather forecast example.
   Here is a link where you 
   Navigate all the files from the project and get familiar with the structure.
   Check the WeatherForecastController from the Controllers folders.
   Open the Program.cs file to see how then application is created and started.
   Build and start the application.
   A swagger interface will be opened, play a bit and call the GetWeatherForecast method.

   As a start-up sample, you have in the project created with one class implemented.
   [https://github.com/msg-CareerPaths/csharp-training/tree/main/Sources/Chapter1/Startup_Chapter/OnlineOrder/Startup_Chapter/OnlineOrder] 
   
   Next you should update the project as follows :
    1.Rename the WeatherForecastController.cs to ProductController.cs
    2.Optionally you can delete tge WeatherForecast class .
    1.Create a new folder called Model where you will have all data models.
    2.Create a new controller called EmployeeController

   
   In the controller a list is created for the purpose of demonstration which is instantiated on the controller contructor.
   The list will be repopulated each time you start the project, so there is no persistance.

   Add methods to Getemployee ny id, update an employee and delete an employee from the employee list.
   You should create the rest of the data models and controllers.
   The classes structure are shown in below diagram: 
  ![Data Model](https://github.com/msg-CareerPaths/csharp-training/blob/main/diagrams/Chapter1.png "Data Model")
   
   Location, ProductCategory collection should be implemented as a generic "HashTable". ?????????????????????? 
   Add a controller class for Location and one controller for ProductCategory. 
   Stock will not have a controller. ????????????????????????????

Employee Application:
 
 > Register an account on GitHub and accept the training [GitHub Classroom Assignment](https://classroom.github.com/a/qiaU7uWM). This will create a new GitHub repository for you. Clone this repository locally and checkout the `develop` branch. During the course of the training, you will commit and push your work on this branch.
 > to "Visual Studio" and generate a new project ASP.NET Core Web API:
 > 
 > Go- Project name: `employeeapp`,
 > - Solution: `ro.msg.learning`,