## Design patterns

Design patterns are typical solutions to common problems in software design. Each pattern is like a blueprint that you can customize to solve a particular
design problem in your code.

**Creational Patterns:**  

**Singleton**
 This pattern ensures that a class has just a single instance and provides a global access point to that instance.
 
   public sealed class Singleton {
      private static volatile Singleton instance;
      private static object syncRoot = new Object();

      private Singleton() { }

      public static Singleton Instance {
          get {
              if (instance == null) {
                  lock (syncRoot) {
                      if (instance == null) {
                          instance = new Singleton();
                      }
                  }
              }
              return instance;
          }
      }
  }
 
 


**Resources:**

 - [Design Patterns](https://refactoring.guru/design-patterns)
