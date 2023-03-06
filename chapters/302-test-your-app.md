## 3.2. Update and debug your app

**Goal:** Update,debug and test your aplication. 

**Required Reading:**

The .net core web api you've created in the previous chapter is using [Swagger](https://swagger.io/).  
Swagger can help you design, document your APIs at scale and will generate a starting test page for your application. 
This is a good starting point to do manual testing of your application.

Here is a preview of how an api that uses swagger looks like.
You can view all methods from a controller :

![Data Model](https://github.com/msg-CareerPaths/csharp-training/blob/main/resources/images/swagger1.png "Data Model")

, and you can test individual methods :

![Data Model](https://github.com/msg-CareerPaths/csharp-training/blob/main/resources/images/swagger2.png "Data Model")

Next you shoud check how to compile, run and debug your application:  
- [How to build your applicantion](https://learn.microsoft.com/en-us/visualstudio/ide/building-and-cleaning-projects-and-solutions-in-visual-studio?view=vs-2022)   
- [How to run you application](https://learn.microsoft.com/en-us/visualstudio/debugger/debugging-absolute-beginners?view=vs-2022&tabs=csharp#run-the-app)  
- [How to debug code](https://learn.microsoft.com/en-us/visualstudio/debugger/debugging-absolute-beginners?view=vs-2022&tabs=csharp#debug-the-app)  

**Exercise**:

You have a start-up sample [here](https://github.com/msg-CareerPaths/csharp-training/tree/main/resources/code/startup_project), that you can check and use as guide to update your project.   
Add new properties to the Product class (decimal Weight, decimal Price, string Description).  
Products  will be stored each in a list, which will be repopulated each time you start the project, so there is no persistance.  
Update the existing product controller to cover all CRUD operation for the products.    
Don't forget to update the Program.cs and inject the new product category service using [DI](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-7.0).    
At the end run, debug and  insert a breakpoint to test the application.  
(Optional) for testing you can use other tools like : [Postman](https://www.postman.com/) or [Curl](https://curl.se/docs/).

**Further Resources:**

 - [create a web API with ASP.NET Core controllers in VSCode](https://learn.microsoft.com/ro-ro/training/modules/build-web-api-aspnet-core/?WT.mc_id=dotnet-35129-website)
