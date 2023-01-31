## 1.1. Create Web API project
   For the first chapter please create a simple Web API using .Net Core.
   To create the application open Visual Studio, choose a Create a New Project, Select ASP.NET Core Web API project and follow the steps. Please check the following the images to select the right options: 
   ![Data Model](https://github.com/msg-CareerPaths/csharp-training/blob/main/Sources/Chapter1/Startup_Chapter/OnlineOrder/Startup_Chapter/ScreenShots/1.jpg)
   and 
   ![Data Model](https://github.com/msg-CareerPaths/csharp-training/blob/main/Sources/Chapter1/Startup_Chapter/OnlineOrder/Startup_Chapter/ScreenShots/2.jpg)

   After you create the project please inspect all the classes that were made. 
   In the project create the Folder Model where you will put your data Model. 
   As a start-up sample, you have in the project created with one class implemented.[https://github.com/msg-CareerPaths/csharp-training/tree/main/Sources/Chapter1/Startup_Chapter/OnlineOrder/Startup_Chapter/OnlineOrder] 
   

   You should create the rest of the data models and controls. The classes are shown below diagram: 
  ![Data Model](https://github.com/msg-CareerPaths/csharp-training/blob/main/diagrams/Chapter1.png "Data Model")
   Location, ProductCategory collection should be implemented as a generic "HashTable". 
   Location, ProductCategory will have a controller. 
   Stock will not have a controller. 

Online Shop:
 
 > Register an account on GitHub and accept the training [GitHub Classroom Assignment](https://classroom.github.com/a/qiaU7uWM). This will create a new GitHub repository for you. Clone this repository locally and checkout the `develop` branch. During the course of the training, you will commit and push your work on this branch.
 >
 > Go to "Visual Studio" and generate a new project ASP.NET Core Web API:
 > - Project name: `shop`,
 > - Solution: `ro.msg.learning`,