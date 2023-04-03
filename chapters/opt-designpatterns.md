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

    // Facade class for the e-commerce application
    public class EcommerceFacade
    {
        private readonly ProductCatalog _productCatalog;
        private readonly ShoppingCart _shoppingCart;
        private readonly PaymentGateway _paymentGateway;

        public EcommerceFacade()
        {
            _productCatalog = new ProductCatalog();
            _shoppingCart = new ShoppingCart();
            _paymentGateway = new PaymentGateway();
        }

        // Method for adding a product to the shopping cart
        public void AddToCart(int productId, int quantity)
        {
            var product = _productCatalog.GetProductById(productId);
            _shoppingCart.AddToCart(product, quantity);
        }

        // Method for checking out and processing payment
        public bool Checkout(string creditCardNumber, string expiryDate)
        {
            var totalAmount = _shoppingCart.GetTotalAmount();
            var paymentSuccessful = _paymentGateway.ProcessPayment(creditCardNumber, expiryDate, totalAmount);

            if (paymentSuccessful)
            {
                _shoppingCart.EmptyCart();
            }

            return paymentSuccessful;
        }
    }

    // Example usage of the EcommerceFacade class
    var ecommerce = new EcommerceFacade();

    // Add a product to the shopping cart
    ecommerce.AddToCart(1234, 2);

    // Checkout and process payment
    var paymentSuccessful = ecommerce.Checkout("1234-5678-9012-3456", "12/24");

    if (paymentSuccessful)
    {
        Console.WriteLine("Payment successful. Order confirmed!");
    }
    else
    {
        Console.WriteLine("Payment failed. Please try again.");
    }


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

     // Interface for the MusicStreamingService
     public interface IMusicStreamingService
     {
         void PlaySong(string songName);
     }

     // Real MusicStreamingService class that implements IMusicStreamingService
     public class MusicStreamingService : IMusicStreamingService
     {
         public void PlaySong(string songName)
         {
             Console.WriteLine($"Playing song: {songName}");
         }
     }

     // Proxy MusicStreamingService class that also implements IMusicStreamingService
     public class ProxyMusicStreamingService : IMusicStreamingService
     {
         private MusicStreamingService musicStreamingService = new MusicStreamingService();

         public void PlaySong(string songName)
         {
             if (IsSongRestricted(songName))
             {
                 Console.WriteLine("Song is restricted in your region.");
                 return;
             }

             musicStreamingService.PlaySong(songName);
         }

         // Check if a song is restricted based on the user's location
         private bool IsSongRestricted(string songName)
         {
             // Code to check if the song is restricted based on the user's location
             return false; // for example purposes, always returning false
         }
     }

     // Main class
     class MainClass
     {
         static void Main()
         {
             // Create a proxy object of the MusicStreamingService
             IMusicStreamingService musicStreamingService = new ProxyMusicStreamingService();

             // Call the PlaySong method on the proxy object
             musicStreamingService.PlaySong("Shape of You"); // This song is not restricted
             musicStreamingService.PlaySong("Hello"); // This song is restricted in some regions
         }
     }
    
**Behavioral Patterns:**  

**Chain of Responsibility**  lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.  
It’s mostly relevant when your code operates with chains of objects, such as filters, event chains, hierahical aprroval, etc.  

Example :  
    
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    public abstract class Approver 
    {
        protected Approver successor;
        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }
        public abstract void ProcessRequest(int ammount);
    }

    public class VicePresident : Approver
    {
        public override void ProcessRequest(int ammount)
        {
            if (amount < 25000.0)
            {
                Console.WriteLine("Approved by VicePresident.");
            }
            else if (successor != null)
            {
                successor.ProcessRequest(purchase);
            }
        }
    }

    public class President : Approver
    {
        public override void ProcessRequest(int ammount)
        {
            if (Amount >= 100000)
            {
                Console.WriteLine("{0} approved request# {1}");
            }
            else
            {
                Console.WriteLine("Request requires an executive meeting!");
            }
        }
    }

    //usage
    Approver sam = new VicePresident();
    Approver john = new President();
    sam.SetSuccessor(john);

    sam.ProcessRequest(1000);
    sam.ProcessRequest(100000);
    

**Command** turns a request into a stand-alone object that contains all information about the request. This transformation lets you pass requests as a method arguments, delay or queue a request’s execution, and support undoable operations.
You this pattern when you want to :
 - to parametrize objects with operations.
 - to queue operations, schedule their execution, or execute them remotely.
 - to implement reversible operations.
Example:  
    
       // Receiver class    
       class InsurancePolicy
       {
           public string PolicyHolder { get; set; }
           public string PolicyNumber { get; set; }
           public double CoverageAmount { get; set; }

           public void CreatePolicy()
           {
               Console.WriteLine($"Policy {PolicyNumber} created for {PolicyHolder} with coverage of {CoverageAmount}.");
           }

           public void CancelPolicy()
           {
               Console.WriteLine($"Policy {PolicyNumber} cancelled for {PolicyHolder}.");
           }
       }

       // Command interface  
       interface IInsuranceCommand
       {
           void Execute();
       }

       // Concrete command for creating a policy  
       class CreatePolicyCommand : IInsuranceCommand
       {
           private readonly InsurancePolicy _policy;

           public CreatePolicyCommand(InsurancePolicy policy)
           {
               _policy = policy;
           }

           public void Execute()
           {
               _policy.CreatePolicy();
           }
       }

       // Concrete command for cancelling a policy  
       class CancelPolicyCommand : IInsuranceCommand
       {
           private readonly InsurancePolicy _policy;

           public CancelPolicyCommand(InsurancePolicy policy)
           {
               _policy = policy;
           }

           public void Execute()
           {
               _policy.CancelPolicy();
           }
       }

       // Invoker class  
       class InsurancePolicyInvoker
       {
           private IInsuranceCommand _command;

           public void SetCommand(IInsuranceCommand command)
           {
               _command = command;
           }

           public void ExecuteCommand()
           {
               _command.Execute();
           }
       }

       // Client code
       class Program
       {
           static void Main(string[] args)
           {
               var policy = new InsurancePolicy
               {
                   PolicyHolder = "John Doe",
                   PolicyNumber = "12345",
                   CoverageAmount = 100000
               };

               var createCommand = new CreatePolicyCommand(policy);
               var cancelCommand = new CancelPolicyCommand(policy);

               var invoker = new InsurancePolicyInvoker();

               invoker.SetCommand(createCommand);
               invoker.ExecuteCommand();

               invoker.SetCommand(cancelCommand);
               invoker.ExecuteCommand();
           }
       }
      


**Iterator** lets you traverse elements of a collection without exposing its underlying representation (list, stack, tree, etc.).
You this pattern:
- when your collection has a complex data structure under the hood, but you want to hide its complexity from clients
- to reduce duplication of the traversal code across your app.
- you want your code to be able to traverse different data structures or when types of these structures are unknown beforehand.
Example :  

        //Define the InsurancePolicy class
         public class InsurancePolicy
         {
             public int PolicyNumber { get; set; }
             public string PolicyHolderName { get; set; }
             public double PremiumAmount { get; set; }
             public string PolicyType { get; set; }

             public InsurancePolicy(int policyNumber, string policyHolderName, double premiumAmount, string policyType)
             {
                 PolicyNumber = policyNumber;
                 PolicyHolderName = policyHolderName;
                 PremiumAmount = premiumAmount;
                 PolicyType = policyType;
             }
         }

         // Define the InsurancePolicyCollection class to implement the IEnumerable interface
         public class InsurancePolicyCollection : IEnumerable
         {
             private ArrayList _policyList = new ArrayList();

             // Add policies to the collection
             public void AddPolicy(InsurancePolicy policy)
             {
                 _policyList.Add(policy);
             }

             // Remove policies from the collection
             public void RemovePolicy(InsurancePolicy policy)
             {
                 _policyList.Remove(policy);
             }

             // GetEnumerator method to return the iterator object
             public IEnumerator GetEnumerator()
             {
                 return new InsurancePolicyIterator(_policyList);
             }
         }

         // Define the InsurancePolicyIterator class to implement the IEnumerator interface
         public class InsurancePolicyIterator : IEnumerator
         {
             private ArrayList _policyList;
             private int _currentIndex = -1;

             public InsurancePolicyIterator(ArrayList policyList)
             {
                 _policyList = policyList;
             }

             // MoveNext method to move to the next policy in the collection
             public bool MoveNext()
             {
                 _currentIndex++;
                 if (_currentIndex < _policyList.Count)
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             }

             // Reset method to reset the iterator to the beginning of the collection
             public void Reset()
             {
                 _currentIndex = -1;
             }

             // Current property to return the current policy object
             public object Current
             {
                 get
                 {
                     return _policyList[_currentIndex];
                 }
             }
         }

         // Use the InsurancePolicyCollection and InsurancePolicyIterator classes
         public class Program
         {
             static void Main(string[] args)
             {
                 InsurancePolicyCollection policyCollection = new InsurancePolicyCollection();

                 policyCollection.AddPolicy(new InsurancePolicy(1001, "John Doe", 5000.00, "Auto"));
                 policyCollection.AddPolicy(new InsurancePolicy(1002, "Jane Smith", 7500.00, "Home"));
                 policyCollection.AddPolicy(new InsurancePolicy(1003, "Bob Johnson", 10000.00, "Life"));

                 // Loop through the policies in the collection using the iterator
                 foreach (InsurancePolicy policy in policyCollection)
                 {
                     Console.WriteLine("Policy Number: {0}", policy.PolicyNumber);
                     Console.WriteLine("Policy Holder Name: {0}", policy.PolicyHolderName);
                     Console.WriteLine("Premium Amount: {0}", policy.PremiumAmount);
                     Console.WriteLine("Policy Type: {0}", policy.PolicyType);
                     Console.WriteLine();
                 }

                 Console.ReadLine();
             }
         }


**Mediator** lets you reduce chaotic dependencies between objects. The pattern restricts direct communications between the objects and forces them to collaborate only via a mediator object. 
When to use:
 - when it’s hard to change some of the classes because they are tightly coupled to a bunch of other classes.
 - when you can’t reuse a component in a different program because it’s too dependent on other components.
 - when you find yourself creating tons of component subclasses just to reuse some basic behavior in various contexts.
 Example :  

       // Mediator interface
       public interface IChatRoom
       {
           void SendMessage(string message, IUser user);
       }

       // Concrete mediator class
       public class ChatRoom : IChatRoom
       {
           private readonly List<IUser> _users = new List<IUser>();

           public void SendMessage(string message, IUser user)
           {
               foreach (var u in _users)
               {
                   if (u != user)
                   {
                       u.ReceiveMessage(message);
                   }
               }
           }

           public void AddUser(IUser user)
           {
               _users.Add(user);
           }
       }

       // Colleague interface
       public interface IUser
       {
           void SendMessage(string message);
           void ReceiveMessage(string message);
       }

       // Concrete colleague class
       public class User : IUser
       {
           private readonly IChatRoom _chatRoom;
           private readonly string _name;

           public User(IChatRoom chatRoom, string name)
           {
               _chatRoom = chatRoom;
               _name = name;
           }

           public void SendMessage(string message)
           {
               _chatRoom.SendMessage(message, this);
           }

           public void ReceiveMessage(string message)
           {
               Console.WriteLine($"{_name} received message: {message}");
           }
       }

       // Client code
       public class Program
       {
           static void Main(string[] args)
           {
               // Client code
               var chatRoom = new ChatRoom();
               var user1 = new User(chatRoom, "Alice");
               var user2 = new User(chatRoom, "Bob");
               var user3 = new User(chatRoom, "Charlie");

               chatRoom.AddUser(user1);
               chatRoom.AddUser(user2);
               chatRoom.AddUser(user3);

               user1.SendMessage("Hi everyone!");
               user2.SendMessage("Hey Alice!");
               user3.SendMessage("Nice to meet you all!");
           }
       }

**Memento** lets you save and restore the previous state of an object without revealing the details of its implementation.
Use this pattern when:
 - you want to produce snapshots of the object’s state to be able to restore a previous state of the object.
 - when direct access to the object’s fields/getters/setters violates its encapsulation.

**Observer**(Event-Subscriber, Listener) is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing.  
Use when:
 - changes to the state of one object may require changing other objects, and the actual set of objects is unknown beforehand or changes dynamically.
 - some objects in your app must observe others, but only for a limited time or in specific cases.

**State**lets an object alter its behavior when its internal state changes. It appears as if the object changed its class.
Use:
 - when you have a lot of duplicate code across similar states and transitions of a condition-based state machine.
 - when you have a class polluted with massive conditionals that alter how the class behaves according to the current values of the class’s fields.
 - when you have an object that behaves differently depending on its current state, the number of states is enormous, and the state-specific code changes frequently. 

**Strategy** lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.
Applicability:
 -  you want to use different variants of an algorithm within an object and be able to switch from one algorithm to another during runtime.
 -  you have a lot of similar classes that only differ in the way they execute some behavior.
 - to isolate the business logic of a class from the implementation details of algorithms that may not be as important in the context of that logic.
 - your class has a massive conditional statement that switches between different variants of the same algorithm.
 
 **Template Method** defines the skeleton of an algorithm in the superclass but lets subclasses override specific steps of the algorithm without changing its structure.
 Applicability : 
  - you want to let clients extend only particular steps of an algorithm, but not the whole algorithm or its structure.
  - you have several classes that contain almost identical algorithms with some minor differences. As a result, you might need to modify all classes when the algorithm changes.

**Visitor** lets you separate algorithms from the objects on which they operate.
Use:
 - when you need to perform an operation on all elements of a complex object structure (for example, an object tree).
 - to clean up the business logic of auxiliary behaviors.
 - when a behavior makes sense only in some classes of a class hierarchy, but not in others.
 
**Resources:** 

 - [Design Patterns](https://refactoring.guru/design-patterns)
