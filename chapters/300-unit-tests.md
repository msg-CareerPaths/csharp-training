## 3. Testing in .NET

Unit testing is used to test individual components or units of your program.
It is used to check if the code is working as expected.
The AAA(Arrange-Act-Assert) pattern is the most used pattern. to divide a test method in 3 sections.
 
 //arrange
 //This section is used to prepare the required data for the test : object creation,mocks setup

 //act
 //This this section you should call the tested code unit and collect the result

 //assert
 //here you should check the result and that the expectations were met

Goal: 
  - Understand unit tests
  - Create a unit test project
  - Implement unit tests.

Required Reading: 
  - [Testing in .NET](https://learn.microsoft.com/en-us/dotnet/core/testing/)
  - [Unit test basics](https://learn.microsoft.com/en-us/visualstudio/test/unit-test-basics?view=vs-2022)
  - [Install unit test frameworks](https://learn.microsoft.com/en-us/visualstudio/test/install-third-party-unit-test-frameworks?view=vs-2022)
  - [Code coverage](https://learn.microsoft.com/en-us/visualstudio/test/using-code-coverage-to-determine-how-much-code-is-being-tested?view=vs-2022&tabs=csharp)
  - [Best practices](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)

Exercices:
  - Create a xUnit test project for the previous application that you worked on.
  - Create the tests project in the same solution.
  - The test project name and folder structure, the test class and method names should respect the recomended naming conventions.
  
  - Add a test class for the ProductCategoryController and test the following:
    - Test if the GetAsync(int id) method returns a NotFound result if the given id does not esists in the controller gategories list.
	  - Test if the GetAsync(int id) method returns a product category result if a given input id param exists in the controller gategories list.
    
	- Use Mock package to mock repositories\services.Check this link for guidance: https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/testing?view=aspnetcore-7.0

Further Reading:
   - [Unit Testing with existing legacy code - using Mock](https://learn.microsoft.com/en-us/shows/visual-studio-toolbox/unit-testing-existing-code)
   - [Use stubs to isolate parts of your application from each other for unit testing](https://learn.microsoft.com/en-us/visualstudio/test/using-stubs-to-isolate-parts-of-your-application-from-each-other-for-unit-testing?view=vs-2022&tabs=csharp)
   - [Use shims to isolate your app for unit testing](https://learn.microsoft.com/en-us/visualstudio/test/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing?view=vs-2022&tabs=csharp)
   - [Fluent  Assertions](https://www.youtube.com/watch?v=MJhQCMnRggs)

	

  
