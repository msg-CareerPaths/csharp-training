## 3.1.Net core Web API project

**Goal:** Create your first asp net core web api project.

**Exercise:**
> Create a new Web API using .Net Core.  
>To create the application open Visual Studio, choose Create a New Project, select ASP.NET Core Web API project and follow the steps:

> - Create and select the type of the project from File -> NewProject  
   ![WEBAPI](https://raw.githubusercontent.com/msg-CareerPaths/csharp-training/main/resources/images/webapi1.png)

> - Configure a project name and location:  
   ![WEBAPI2](https://raw.githubusercontent.com/msg-CareerPaths/csharp-training/main/resources/images/webapi2.png)
   
> - Specify additional information(Use the latest .Net Framework) :
 
   ![WEBAPI3](https://raw.githubusercontent.com/msg-CareerPaths/csharp-training/main/resources/images/webapi3.png)
   
> As a default project you will have a weather forecast example.  

> The .net core web api is using [Swagger](https://swagger.io/).Swagger can help you design, document your APIs at scale and will generate a starting test page for your application. 
> This is a good starting point to do manual testing of your application.

> Here is a preview of how an api that uses swagger looks like. You can view all methods from a controller :

>![SWAGGER](https://raw.githubusercontent.com/msg-CareerPaths/csharp-training/main/resources/images/swagger1.png)

>, and you can test individual methods :

>![SWAGGER](https://raw.githubusercontent.com/msg-CareerPaths/csharp-training/main/resources/images/swagger2.png)

> Check all the files from the project and get familiar with the structure and the classes.  
> Check the WeatherForecastController from the Controllers folders.  
> Open the Program.cs file to see how then application is created and started.  
> At the end, run, debug and  insert a breakpoint to test the application. 
> Test you app using swagger and then use postman to do the same tests.  
> You can also use [Curl](https://curl.se/docs/), Insomnia or other tool for testing the REST API

>You can use the following links and check how to compile, run, test and debug your application:  
> - [How to build your applicantion](https://learn.microsoft.com/en-us/visualstudio/ide/building-and-cleaning-projects-and-solutions-in-visual-studio?view=vs-2022)   
> - [How to run you application](https://learn.microsoft.com/en-us/visualstudio/debugger/debugging-absolute-beginners?view=vs-2022&tabs=csharp#run-the-app)  
> - [How to debug code](https://learn.microsoft.com/en-us/visualstudio/debugger/debugging-absolute-beginners?view=vs-2022&tabs=csharp#debug-the-app)  
> - [Postman- Sending your first request](https://learning.postman.com/docs/getting-started/sending-the-first-request/)
> - [Test a REST API with curl](https://www.baeldung.com/curl-rest)  

**Further Resources:**

 - [Create a web API with ASP.NET Core controllers in Visual Studio](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio)
