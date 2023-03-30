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

**Structural Patterns:**    
Structural design patterns explain how to assemble objects and classes into larger structures, while keeping these structures flexible and efficient.  

**Adapter**  
Using this pattern you will allow objects with incompatible interfaces to collaborate.  
Example:    

    // Define the Target interface
    interface IJsonConverter
    {
        string ConvertToJson();
    }

    // Define the Adaptee interface
    interface IXmlConverter
    {
        string ConvertToXml();
    }

    // Implement the Adaptee interface
    class XmlConverter : IXmlConverter
    {
        public string ConvertToXml()
        {
            // Implementation to convert XML to string
            return "<root><element>value</element></root>";
        }
    }

    // Implement the Adapter interface
    class XmlToJsonAdapter : IJsonConverter
    {
        private readonly IXmlConverter xmlConverter;

        public XmlToJsonAdapter(IXmlConverter xmlConverter)
        {
            this.xmlConverter = xmlConverter;
        }

        public string ConvertToJson()
        {
            // Implementation to convert XML to JSON using a third-party library
            string xmlString = xmlConverter.ConvertToXml();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString);
            string json = JsonConvert.SerializeXmlNode(xmlDoc);
            return json;
        }
    }
    // Usage example:
    IXmlConverter xmlConverter = new XmlConverter();
    IJsonConverter jsonConverter = new XmlToJsonAdapter(xmlConverter);
    string json = jsonConverter.ConvertToJson();
    Console.WriteLine(json);

**Bridge**  
Lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.  
Example :

    // Abstraction
    public abstract class Vehicle
    {
        protected IEngine engine;

        public Vehicle(IEngine engine)
        {
            this.engine = engine;
        }

        public abstract void Drive();
    }

    // Implementor
    public interface IEngine
    {
        void Start();
    }

    // Concrete Implementor
    public class GasolineEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Gasoline engine started.");
        }
    }

    // Concrete Implementor
    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Electric engine started.");
        }
    }

    // Refined Abstraction
    public class Car : Vehicle
    {
        public Car(IEngine engine) : base(engine)
        {
        }

        public override void Drive()
        {
            Console.Write("Driving a car... ");
            engine.Start();
        }
    }

    // Refined Abstraction
    public class Truck : Vehicle
    {
        public Truck(IEngine engine) : base(engine)
        {
        }

        public override void Drive()
        {
            Console.Write("Driving a truck... ");
            engine.Start();
        }
    }

    // Usage example:
    // Create a car with a gasoline engine
    Vehicle car = new Car(new GasolineEngine());
    car.Drive(); // Driving a car... Gasoline engine started.

    // Create a truck with an electric engine
    Vehicle truck = new Truck(new ElectricEngine());
    truck.Drive(); // Driving a truck... Electric engine started.
    
**Composite** is a structural design pattern that lets you compose objects into tree structures and then work with these structures as if they were individual objects.  Example:  

    // Component
    public abstract class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public abstract void Display(int depth);
    }

    // Leaf
    public class Developer : Employee
    {
        public Developer(string name) : base(name)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }
    }

    // Composite
    public class Manager : Employee
    {
        private List<Employee> _employees = new List<Employee>();

        public Manager(string name) : base(name)
        {
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);

            foreach (Employee employee in _employees)
            {
                employee.Display(depth + 2);
            }
        }
    }

    // Create leaf employees
    Developer developer1 = new Developer("John Doe");
    Developer developer2 = new Developer("Jane Doe");

    // Create composite manager and add leaf employees to it
    Manager manager = new Manager("Bob Smith");
    manager.AddEmployee(developer1);
    manager.AddEmployee(developer2);

    // Display the hierarchy
    manager.Display(0);

**Decorator** is a structural design pattern that lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors.  
Example:  

    // The base interface for an insurance policy.
    public interface IInsurancePolicy
    {
        decimal CalculatePremium();
    }

    // The base implementation of an insurance policy.
    public class BaseInsurancePolicy : IInsurancePolicy
    {
        public decimal CalculatePremium()
        {
            // Calculate the premium for the base policy.
            decimal premium = /* some calculation */;
            return premium;
        }
    }

    // A decorator that adds theft coverage to an insurance policy.
    public class TheftCoverageDecorator : IInsurancePolicy
    {
        private readonly IInsurancePolicy _basePolicy;

        public TheftCoverageDecorator(IInsurancePolicy basePolicy)
        {
            _basePolicy = basePolicy;
        }

        public decimal CalculatePremium()
        {
            // Calculate the premium for the base policy with theft coverage added.
            decimal premium = _basePolicy.CalculatePremium() + /* some calculation */;
            return premium;
        }
    }

    // Example usage:
    IInsurancePolicy basePolicy = new BaseInsurancePolicy();
    IInsurancePolicy policyWithTheftCoverage = new TheftCoverageDecorator(basePolicy);
    IInsurancePolicy policyWithFireAndTheftCoverage = new FireCoverageDecorator(policyWithTheftCoverage);
    decimal premium = policyWithFireAndTheftCoverage.CalculatePremium();


**Facade** is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.  
Example:  

    public class InsuranceFacade
    {
        private readonly CustomerRepository _customerRepository;
        private readonly PolicyRepository _policyRepository;
        private readonly ClaimRepository _claimRepository;

        public InsuranceFacade()
        {
            _customerRepository = new CustomerRepository();
            _policyRepository = new PolicyRepository();
            _claimRepository = new ClaimRepository();
        }

        public void CreateNewCustomer(string name, string address, string phone)
        {
            var customer = new Customer { Name = name, Address = address, Phone = phone };
            _customerRepository.Save(customer);
        }

        public void CreateNewPolicy(string policyNumber, string policyType, string customerId)
        {
            var policy = new Policy { PolicyNumber = policyNumber, PolicyType = policyType, CustomerId = customerId };
            _policyRepository.Save(policy);
        }

        public void CreateNewClaim(string claimNumber, string policyNumber, DateTime dateOfLoss, decimal amount)
        {
            var claim = new Claim { ClaimNumber = claimNumber, PolicyNumber = policyNumber, DateOfLoss = dateOfLoss, Amount = amount };
            _claimRepository.Save(claim);
        }
    }

    public class CustomerService
    {
        public void Save(Customer customer)
        {
            // Code to save customer to database
        }
    }

    public class PolicyService
    {
        public void Save(Policy policy)
        {
            // Code to save policy to database
        }
    }

    public class ClaimService
    {
        public void Save(Claim claim)
        {
            // Code to save claim to database
        }
    }

    // to use clients can simply use the InsuranceFacade methods to perform the necessary actions. 


**Flyweight** lets you fit more objects into the available amount of RAM by sharing common parts of state between multiple objects instead of keeping all of the data in each object.  
Here is an example of minimizing memory usage in a application, since we don't need to create a new Policy object for every policy number that is requested. Instead, we can reuse existing objects and only create new ones when necessary.  
Example :  

    public class PolicyFactory
    {
        private readonly Dictionary<string, Policy> _policies = new Dictionary<string, Policy>();

        public Policy GetPolicy(string policyNumber, string policyType)
        {
            var key = policyNumber + policyType;
            if (_policies.ContainsKey(key))
            {
                return _policies[key];
            }
            else
            {
                var policy = new Policy(policyNumber, policyType);
                _policies.Add(key, policy);
                return policy;
            }
        }
    }

    public class Policy
    {
        public string PolicyNumber { get; private set; }
        public string PolicyType { get; private set; }

        public Policy(string policyNumber, string policyType)
        {
            PolicyNumber = policyNumber;
            PolicyType = policyType;
        }
    }
    

**Proxy** is a structural design pattern that lets you provide a substitute or placeholder for another object. A proxy controls access to the original object, allowing you to perform something either before or after the request gets through to the original object.  

Example:  

    // The Subject interface declares common operations for both RealSubject and
    // the Proxy. As long as the client works with RealSubject using this
    // interface, you'll be able to pass it a proxy instead of a real subject.
    public interface ISubject
    {
        void Request();
    }

    // The RealSubject contains some core business logic. Usually, RealSubjects
    // are capable of doing some useful work which may also be very slow or
    // sensitive - e.g. correcting input data. A Proxy can solve these issues
    // without any changes to the RealSubject's code.
    class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }

    // The Proxy has an interface identical to the RealSubject.
    class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            this._realSubject = realSubject;
        }

        // The most common applications of the Proxy pattern are lazy loading,
        // caching, controlling the access, logging, etc. A Proxy can perform
        // one of these things and then, depending on the result, pass the
        // execution to the same method in a linked RealSubject object.
        public void Request()
        {
            if (this.CheckAccess())
            {
                this._realSubject.Request();

                this.LogAccess();
            }
        }

        public bool CheckAccess()
        {
            // Some real checks should go here.
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");

            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }

    public class Client
    {
        // The client code is supposed to work with all objects (both subjects
        // and proxies) via the Subject interface in order to support both real
        // subjects and proxies. In real life, however, clients mostly work with
        // their real subjects directly. In this case, to implement the pattern
        // more easily, you can extend your proxy from the real subject's class.
        public void ClientCode(ISubject subject)
        {
            // ...            
            subject.Request();
            // ...
        }
    }

    //how to use 
    Client client = new Client();

    Console.WriteLine("Client: Executing the client code with a real subject:");
    RealSubject realSubject = new RealSubject();
    client.ClientCode(realSubject);

    Console.WriteLine();

    Console.WriteLine("Client: Executing the same client code with a proxy:");
    Proxy proxy = new Proxy(realSubject);
    client.ClientCode(proxy);



**Resources:**

 - [Design Patterns](https://refactoring.guru/design-patterns)
