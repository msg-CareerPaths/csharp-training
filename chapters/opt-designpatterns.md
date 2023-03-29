## Design patterns

Design patterns are typical solutions to common problems in software design. Each pattern is like a blueprint that you can customize to solve a particular
design problem in your code.

**Creational Patterns:**  

**Singleton**
 This pattern ensures that a class has just a single instance and provides a global access point to that instance.
 
 Example of singleton class and how to use it.
 
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
 
 Singleton s1 = Singleton.Instance;
 Singleton s2 = Singleton.Instance;
 Console.WriteLine(s1 == s2); // Output: True

**Factory Method**

The Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created. It is useful when you need to create an object, but you don't know the exact type of the object until runtime.
 
Example:

    public interface IInsurancePolicy {
        void CalculatePremium();
    }

    public class CarInsurancePolicy : IInsurancePolicy {
        public void CalculatePremium() {
            Console.WriteLine("Calculating premium for car insurance policy...");
        }
    }

    public class HomeInsurancePolicy : IInsurancePolicy {
        public void CalculatePremium() {
            Console.WriteLine("Calculating premium for home insurance policy...");
        }
    }

    public abstract class InsurancePolicyFactory {
        public abstract IInsurancePolicy CreatePolicy();
    }

    public class CarInsurancePolicyFactory : InsurancePolicyFactory {
        public override IInsurancePolicy CreatePolicy() {
            return new CarInsurancePolicy();
        }
    }

    public class HomeInsurancePolicyFactory : InsurancePolicyFactory {
        public override IInsurancePolicy CreatePolicy() {
            return new HomeInsurancePolicy();
        }
    }

    InsurancePolicyFactory factory = new CarInsurancePolicyFactory();
    IInsurancePolicy policy = factory.CreatePolicy();
    policy.CalculatePremium(); // Output: "Calculating premium for car insurance policy..."

    factory = new HomeInsurancePolicyFactory();
    policy = factory.CreatePolicy();
    policy.CalculatePremium(); // Output: "Calculating premium for home insurance policy..."

**Abtract Factory** pattern lets you produce families of related objects without specifying their concrete classes.

Example:  

    public interface IInsuranceFactory
    {
        PolicyApplication CreateApplication(string customerName, string policyType);
        PolicyDocument CreateDocument(PolicyApplication application);
    }

    public class HomeInsuranceFactory : IInsuranceFactory
    {
        public PolicyApplication CreateApplication(string customerName, string policyType)
        {
            return new HomeInsurancePolicyApplication(customerName);
        }
        public PolicyDocument CreateDocument(PolicyApplication application, PolicyQuote quote, PolicyPolicyholder policyholder, PolicyBeneficiary beneficiary)
        {
            return new AutoPolicyDocument(application);
        }
    }

    public class AutoInsuranceFactory : IInsuranceFactory
    {
        public PolicyApplication CreateApplication(string customerName, string policyType)
        {
            return new AutoPolicyApplication(customerName);
        }
        public PolicyDocument CreateDocument(PolicyApplication application)
        {
            return new AutoPolicyDocument(application);
        }
    }

    IPolicyFactory factory = new AutoInsuranceFactory();
    PolicyApplication application = factory.CreateApplication("John Smith", "Auto");
    PolicyDocument document = factory.CreateDocument(application);

    IPolicyFactory factory = new HomeInsuranceFactory();
    PolicyApplication application = factory.CreateApplication("John Smith", "Home");
    PolicyDocument document = factory.CreateDocument(application);

**Prototype** pattern allows cloning objects, even complex ones, without coupling to their specific classes.
 
  - Example :  
    
    // Define the prototype interface
    interface ICloneable
    {
        public ICloneable Clone();
    }

    // Concrete prototype class
    class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        // Constructor
        public Person(string name, int age, Address address)
        {
            this.Name = name;
            this.Age = age;
            this.Address = address;
        }

        // Implement the Clone method
        public ICloneable Clone()
        {
            return new Person(this.Name, this.Age, this.Address.Clone() as Address);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Address: {Address}";
        }
    }

    // Another concrete prototype class
    class Address : ICloneable
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        // Constructor
        public Address(string street, string city, string country)
        {
            this.Street = street;
            this.City = city;
            this.Country = country;
        }

        // Implement the Clone method
        public ICloneable Clone()
        {
            return new Address(this.Street, this.City, this.Country);
        }

        public override string ToString()
        {
            return $"{Street}, {City}, {Country}";
        }
    }
        
        // Create a person object
        var person1 = new Person("John Doe", 30, new Address("123 Main St", "Anytown", "USA"));
        
        // Clone the person object
        var person2 = person1.Clone() as Person;

        // Modify the cloned object's address
        person2.Address.City = "New York";

        // Print the original and cloned objects

     
     
**Resources:**

 - [Design Patterns](https://refactoring.guru/design-patterns)
