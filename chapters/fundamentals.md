# Fundamentals

C# is a object-oriented and type-safe programming language. C# enables developers to build many types of applications that run in .NET.

C# programs run on .NET, a virtual execution system called the common language runtime (CLR) and a set of class libraries. The CLR is the implementation by Microsoft of the common language infrastructure (CLI), an international standard.

What is .NET?
.NET is a free, open-source development platform for building many kinds of apps, such as:

- Web apps, web APIs, and microservices
- Serverless functions in the cloud
- Cloud native apps
- Mobile apps
- Desktop apps
- Windows WPF(Windows Presentation Foundation)
- Windows Forms
- Universal Windows Platform (UWP)
- Games
- Internet of Things (IoT)
- Machine learning
- Console apps
- Windows services

## Types and variables

A type defines the structure and behavior of any data in C#. The declaration of a type may include its members, base type, interfaces it implements, and operations permitted for that type. A variable is a label that refers to an instance of a specific type.

There are two kinds of types in C#: **value types** and **reference types**. 

Variables of value types directly contain their data. With value types, the variables each have their own copy of the data, and it isn't possible for operations on one to affect the other (except for ref and out parameter variables).

Variables of reference types store references to their data, the latter being known as objects. With reference types, it's possible for two variables to reference the same object and possible for operations on one variable to affect the object referenced by the other variable. 

An identifier is a variable name. An identifier is a sequence of unicode characters without any whitespace. An identifier may be a C# reserved word, if it's prefixed by @. Using a reserved word as an identifier can be useful when interacting with other languages.

C#'s value types are further divided into simple types, enum types, struct types, nullable value types, and tuple value types. C#'s reference types are further divided into class types, interface types, array types, and delegate types.

- **Value types** (https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types)
  - Simple types
  - Enum types
  - Struct types
  - Nullable value types
  - Tuple value types
- **Reference types** (https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types)
  - Class types
  - Interface types
  - Array types
  - Delegate types

C# programs use type declarations to create new types. A type declaration specifies the name and the members of the new type. Six of C#'s categories of types are user-definable: class types, struct types, interface types, enum types, delegate types, and tuple value types. You can also declare record types, either record struct, or record class. Record types have compiler-synthesized members. You use records primarily for storing values, with minimal associated behavior. For more details about records visit: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record

- A **class** type defines a data structure that contains data members (fields) and function members (methods, properties, and others). Class types support single inheritance and polymorphism, mechanisms whereby derived classes can extend and specialize base classes.
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class

- A **struct** type is similar to a class type in that it represents a structure with data members and function members. However, unlike classes, structs are value types and don't typically require heap allocation. Struct types don't support user-specified inheritance, and all struct types implicitly inherit from type object.
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct

- An **interface** type defines a contract as a named set of public members. A class or struct that implements an interface must provide implementations of the interface's members. An interface may inherit from multiple base interfaces, and a class or struct may implement multiple interfaces.
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface

- A **delegate** type represents references to methods with a particular parameter list and return type. Delegates make it possible to treat methods as entities that can be assigned to variables and passed as parameters. Delegates are analogous to function types provided by functional languages. They're also similar to the concept of function pointers found in some other languages. Unlike function pointers, delegates are object-oriented and type-safe.
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates

## Object Oriented programming

- **Classes**, **structs**, and **records**
  Definition of a class, struct, or record—is like a blueprint that specifies what the type can do. An object is basically a block of memory that has been allocated and configured according to the blueprint. This article provides an overview of these blueprints and their features. The next article in this series introduces objects. https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop

- **Object** is basically a block of memory that has been allocated and configured according to the blueprint.
  https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/objects 

- **Inheritance** enables you to create new classes that reuse, extend, and modify the behavior defined in other classes.
  https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/inheritance

- **Polymorphism** is the ability of objects of different types to provide a unique interface for different implementations of methods
  https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/polymorphism