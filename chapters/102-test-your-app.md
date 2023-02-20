## 1.2. Test your app

Goal: 
   Debug and testing your aplication. 

- [How to compile and run your applicantion](https://docs.microsoft.com/en-us/visualstudio/ide/compiling-and-building-in-visual-studio?view=vs-2022)
- [How to debug code](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-debugger?view=vs-2022)

The products application built in the [ previous chapter](https://github.com/msg-CareerPaths/csharp-training/blob/main/chapters/101-create-web-api-project.mdChapter) has included the [Swagger](https://swagger.io/) middleware. 

Swagger can help you design, document your APIs at scale and will  generate a starting test page for your application. 
This is a good starting point to do manual testing of your application.

Here is a preview of how a backend api that uses swagger looks like.

You can view all methods from a controller :

![Data Model](https://github.com/msg-CareerPaths/csharp-training/blob/main/Sources/Chapter2/1.jpg "Data Model")

, and you can test individual methods :

![Data Model](https://github.com/msg-CareerPaths/csharp-training/blob/main/Sources/Chapter2/2.jpg "Data Model")

Exercise:
  You have a start-up sample [here] (https://github.com/msg-CareerPaths/csharp-training/tree/main/Sources/Chapter1/Startup_Chapter/OnlineOrder/Startup_Chapter/OnlineOrder), that you can use to build your ASP.NET Core Web API.
  
  Add new properties to the Product class like (decimal Price, string Description).
  Products and product categories  will be stored each in a list, which will be repopulated each time you start the project,
  so there is no persistance.
  If you want you can initiate the lists with some values on the classes contructors.
  Update the existing product controller to cover all CRUD operation for the products.
  Create a new class named ProductCategory with the following properties(string? Id,string Name,string description).
  Create a new controller and service for the product categories where you will expose all CRUD methods.
  Product category service will implement an interface called IProductCategoryService.
  At this stage you will have 2 controllers one for products and one for product categories.
  Don't forget to update the Program.cs and inject the new ProductCategoryService using [DI](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-7.0).
  At the end run, debug and  manual test the application with swagger.

  (Optional) for tetsing you can use other tools like : [Postman](https://www.postman.com/) or [Curl](https://curl.se/docs/).
