## 5. Security

Code access security is a mechanism that controls the access code to protect resources and operations. In NET Framework, code access security performs functions like defining permission, enabling administrators to configure security policy, allowing code to request the permissions it requires in order to run, granting permissions to each assembly that is loaded, based on the permissions requested by the code and it enables code to demand that its callers have specific permissions.  

Code access security is a mechanism that grants/denies access to resources within a method call. For example, code written by a person may be allowed to write to the disk while code from another one may be forbidden from accessing the disk. This control can be enforced even if the code written by both of them is used within a single application.  

Exercise: *nothing to do*.  

C# security vulnerabilities includes topics such as :
 - [ASP.NET Core security topics](https://learn.microsoft.com/en-us/aspnet/core/security/?view=aspnetcore-7.0)
 - [Authentication and authorization in ASP.NET](https://docs.microsoft.com/en-us/aspnet/web-api/overview/security/authentication-and-authorization-in-aspnet-web-api)
 - [Authentication](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/secure-net-microservices-web-applications/)
 - [Introduction to authorization in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/security/authorization/introduction?view=aspnetcore-7.0)
 - [XML vulnerabilities](https://pvs-studio.com/en/blog/posts/csharp/0918/)
 - [XSS basics of web security](https://learn.microsoft.com/en-us/aspnet/core/security/cross-site-scripting?view=aspnetcore-7.0)
 - [SQL injection](https://jonathancrozier.com/blog/preventing-sql-injection-in-c-sharp-applications)
 - [Regular expressions](https://docs.microsoft.com/en-us/archive/msdn-magazine/2010/may/security-briefs-regular-expression-denial-of-service-attacks-and-defenses)
 - [Other platform-related security issues](https://docs.microsoft.com/en-us/dotnet/standard/security/)
