 ## CQRS

CQRS, or Command Query Responsibility Segregation, is a software architecture pattern that separates the processing of commands (i.e., requests that change data) from the processing of queries (i.e., requests that retrieve data) into separate components. This separation is intended to improve the performance, scalability, and maintainability of an application.

In a CQRS architecture, commands are handled by a command handler, which updates the application state or invokes domain logic to make changes to the system. Queries, on the other hand, are handled by a query handler, which retrieves data from a separate read model optimized for fast queries.

Separating the processing of commands and queries has several benefits. For example, it allows for better scalability and performance since the read and write operations can be optimized separately. It also improves the maintainability of the application since changes to the read and write operations can be made independently.

However, implementing a CQRS architecture can also introduce additional complexity, since it requires additional components and coordination between them. As such, CQRS is typically used in complex systems that require high scalability and performance, rather than in simpler applications.

Reading:
 - [What is CQRS pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/cqrs)
 - [Combining Clean Architecture and CQRS Principles in a .NET Core Application: A Practical Example](https://www.apriorit.com/dev-blog/783-web-clean-architecture-and-cqrs-in-net-core-apps)
 - [How to structure a .NET Solution (project separation & architecture)](https://www.youtube.com/watch?v=YiVqwoFMieg)