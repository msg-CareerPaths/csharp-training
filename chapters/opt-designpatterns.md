## Design patterns

Design patterns are typical solutions to common problems in software design. Each pattern is like a blueprint that you can customize to solve a particular
design problem in your code.

**Creational Patterns:**  

**Singleton**  
 This pattern ensures that a class has just a single instance and provides a global access point to that instance.
 
 Example:  
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

**Abtract Factory**   
This pattern lets you produce families of related objects without specifying their concrete classes.  
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
        public PolicyDocument CreateDocument(PolicyApplication application)
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


**Prototype**  
Is a pattern that allows cloning objects, even complex ones, without coupling to their specific classes.  
Example:  
  
        interface ICloneable
            {
                public ICloneable Clone();
            }

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

            public ICloneable Clone()
            {
                return new Person(this.Name, this.Age, this.Address.Clone() as Address);
            }
        }
        class Address : ICloneable
        {
            public string Street { get; set; }
            public string City { get; set; }
            public string Country { get; set; }

            public Address(string street, string city, string country)
            {
                this.Street = street;
                this.City = city;
                this.Country = country;
            }

            public ICloneable Clone()
            {
                return new Address(this.Street, this.City, this.Country);
            }
        }
        
        //call example
        var person1 = new Person("John Doe", 30, new Address("123 Main St", "Anytown", "USA"));
        var person2 = person1.Clone() as Person;


**BuilderPattern:** 
The pattern allows you to produce different types and representations of an object using the same construction code.  
The Builder pattern suggests that you extract the object construction code out of its own class and move it to separate objects called builders.
Example:  

    public class Report
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public List<string> Sections { get; set; }

        public Report()
        {
            Sections = new List<string>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Title: ").AppendLine(Title);
            sb.Append("Author: ").AppendLine(Author);
            sb.Append("Date: ").AppendLine(Date.ToString());
            sb.Append("Sections:").AppendLine();
            foreach (string section in Sections)
            {
                sb.Append("\t- ").AppendLine(section);
            }
            return sb.ToString();
        }
    }

    public interface IReportBuilder
    {
        IReportBuilder SetTitle(string title);
        IReportBuilder SetAuthor(string author);
        IReportBuilder SetDate(DateTime date);
        IReportBuilder AddSection(string section);
        Report Build();
    }

    public class ReportBuilder : IReportBuilder
    {
        private Report report;

        public ReportBuilder()
        {
            report = new Report();
        }

        public IReportBuilder SetTitle(string title)
        {
            report.Title = title;
            return this;
        }

        public IReportBuilder SetAuthor(string author)
        {
            report.Author = author;
            return this;
        }

        public IReportBuilder SetDate(DateTime date)
        {
            report.Date = date;
            return this;
        }

        public IReportBuilder AddSection(string section)
        {
            report.Sections.Add(section);
            return this;
        }

        public Report Build()
        {
            return report;
        }
    }

    // Usage example:
    var reportBuilder = new ReportBuilder();
    var report = reportBuilder
        .SetTitle("Sales Report")
        .SetAuthor("John Doe")
        .SetDate(DateTime.Now)
        .AddSection("Summary")
        .AddSection("Sales by Region")
        .Build();


**Resources:**

 - [Design Patterns](https://refactoring.guru/design-patterns)
