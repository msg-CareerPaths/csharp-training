## 5. Testing in .NET

**Goal:** Understand unit tests,create and implement unit tests.
 
**Required Reading:**

Testing is an essential part of the software development process, and .NET provides several tools and frameworks to support different types of testing, as follows:
 - Unit Testing: Unit testing is the process of testing individual units or components of an application in isolation. The most popular unit testing framework for .NET is NUnit, which allows developers to write automated tests in C# or VB.NET.
 - Integration Testing: Integration testing is the process of testing the interactions between different components of an application. The most popular integration testing framework for .NET is xUnit, which allows developers to write tests that cover multiple components of an application.
- UI Testing: UI testing is the process of testing the user interface of an application. The most popular UI testing framework for .NET is Selenium, which allows developers to write automated tests that simulate user interactions with a web browser.
- Performance Testing: Performance testing is the process of testing an application's performance under different conditions, such as high traffic or large data sets. The most popular performance testing tool for .NET is Apache JMeter, which allows developers to test web applications, web services, and databases.
- Load Testing: Load testing is the process of testing an application's performance under different loads. The most popular load testing tool for .NET is LoadRunner, which allows developers to simulate user traffic and measure the application's response time and throughput.
- Code Analysis: Code analysis tools such as ReSharper and SonarQube help developers identify potential issues in their code and ensure that it adheres to best practices and coding standards.

.NET also provides built-in testing tools such as Visual Studio Test Explorer and MSTest, which allow developers to run and debug tests directly from within the IDE. Overall, testing is an essential part of the software development process, and .NET provides a variety of tools and frameworks to support different types of testing.

Unit testing is used to test individual components or units of your program.
It is used to check if the code is working as expected.
The AAA(Arrange-Act-Assert) pattern is the most used pattern. to divide a test method in 3 sections.
 
 	//arrange  
 	//This section is used to prepare the required data for the test : object creation,mocks setup  

 	//act  
 	//This this section you should call the tested code unit and collect the result  

 	//assert  
 	//here you should check the result and that the expectations were met  

**Required Reading:**
  - [Testing in .NET](https://learn.microsoft.com/en-us/dotnet/core/testing/)
  - [Unit test basics](https://learn.microsoft.com/en-us/visualstudio/test/unit-test-basics?view=vs-2022)
  - [Install unit test frameworks](https://learn.microsoft.com/en-us/visualstudio/test/install-third-party-unit-test-frameworks?view=vs-2022)
  - [Code coverage](https://learn.microsoft.com/en-us/visualstudio/test/using-code-coverage-to-determine-how-much-code-is-being-tested?view=vs-2022&tabs=csharp)
  - [Best practices](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)

**Exercices:**

Create a xUnit test project for the previous application that you worked on, by adding a new tests project in the same solution.  
The test project name and folder structure,test class and method names should respect the recomended naming conventions.  
Add a test class for the ProductCategoryController and test the following:   
 - Test if the GetAsync(int id) method returns a NotFound result if the given id does not exists in the categories list.  
 - Test if the GetAsync(int id) method returns a product category result if a given input id param exists in the categories list.     

Use [Mock](https://softchris.github.io/pages/dotnet-moq.html#creating-our-first-mock) package to mock repositories\services.


**Further Resources:**

 - [Unit Testing with existing legacy code - using Mock](https://learn.microsoft.com/en-us/shows/visual-studio-toolbox/unit-testing-existing-code)  
 - [Use stubs to isolate parts of your application from each other for unit testing](https://learn.microsoft.com/en-us/visualstudio/test/using-stubs-to-isolate-parts-of-your-application-from-each-other-for-unit-testing?view=vs-2022&tabs=csharp)    
 - [Use shims to isolate your app for unit testing](https://learn.microsoft.com/en-us/visualstudio/test/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing?view=vs-2022&tabs=csharp)  
 - [Fluent  Assertions](https://www.youtube.com/watch?v=MJhQCMnRggs)    
