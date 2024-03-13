// creating class and object. 
class Car
{
  string color_1 = "red";
  string model;
  string color;
  int year;
  public void fullThrottle()    // method
  {
    Console.WriteLine("The car is going as fast as it can!"); 
  }
  static void Main(string[] args)
  {
    Car myObj1 = new Car();
    Car myObj2 = new Car();
    Console.WriteLine(myObj1.color_1);
    Console.WriteLine(myObj2.color_1);
    
    // using multiple parameter. 
    Car Ford = new Car();
    Ford.model = "Mustang";
    Ford.color = "red";
    Ford.year = 1969;
    
    // calling the method of the class
    myObj.fullThrottle(); 
  }
}

// ---------- constructor
class car {
  public string model;
  public car(string modelName){
    model = modelName; 
  }
  
  static void main(String[] args){
    Car ford = new Car("Mustang");
    Console.WriteLine(Ford.model);
  }
}

// ----------- access modifier 
/*
public : 	The code is accessible for all classes
private : 	The code is only accessible within the same class
protected	: The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter
internal	:The code is only accessible within its own assembly, 
          but not from another assembly. You will learn more about this in a later chapter
*/


// ------------- encapsulation 
class Person
{
  public string Name  // property
  { get; set; }
}
class Program
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    myObj.Name = "Liam";
    Console.WriteLine(myObj.Name);
  }
}

// ---------- inheritence 
class Vehicle  // base class (parent) 
{
  public string brand = "Ford";  // Vehicle field
  public void honk()             // Vehicle method 
  {                    
    Console.WriteLine("Tuut, tuut!");
  }
}

class Car : Vehicle  // derived class (child)
{
  public string modelName = "Mustang";  // Car field
}

// to access all the methods we have to use the child method
class Program
{
  static void Main(string[] args)
  {
    // Create a myCar object
    Car myCar = new Car();
    // Call the honk() method (From the Vehicle class) on the myCar object
    myCar.honk();
    // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
    Console.WriteLine(myCar.brand + " " + myCar.modelName);
  }
}


// polymorphism 
// C# provides an option to override the base class method, by adding the virtual keyword 
// to the method inside the base class, and by using the override keyword for each derived class methods:
class Animal  // Base class (parent) 
{
  public virtual void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myPig = new Pig();  // Create a Pig object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
}


// ------ abstraction
/*
Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
Abstract method: can only be used in an abstract class, 
and it does not have a body. The body is provided by the derived class (inherited from).
*/ 
// Abstract class
abstract class Animal
{
  // Abstract method (does not have a body)
  public abstract void animalSound();
  // Regular method
  public void sleep()
  {
    Console.WriteLine("Zzz");
  }
}

// Derived class (inherit from Animal)
class Pig : Animal
{
  public override void animalSound()
  {
    // The body of animalSound() is provided here
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Pig myPig = new Pig(); // Create a Pig object
    myPig.animalSound();  // Call the abstract method
    myPig.sleep();  // Call the regular method
  }
}


// ----------- interface
/*
Like abstract classes, interfaces cannot be used to create objects (in the example above, it is not possible to create an "IAnimal" object in the Program class)
Interface methods do not have a body - the body is provided by the "implement" class
On implementation of an interface, you must override all of its methods
Interfaces can contain properties and methods, but not fields/variables
Interface members are by default abstract and public
An interface cannot contain a constructor (as it cannot be used to create objects)
*/
// Interface
interface IAnimal 
{
  void animalSound(); // interface method (does not have a body)
}

// Pig "implements" the IAnimal interface
class Pig : IAnimal 
{
  public void animalSound() 
  {
    // The body of animalSound() is provided here
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Pig myPig = new Pig();  // Create a Pig object
    myPig.animalSound();
  }
}

// -------------- multiple interfaces. 
// c sharp doesn't support multiple inheritence , but support multilple
// interfaces.
interface IFirstInterface 
{
  void myMethod(); // interface method
}

interface ISecondInterface 
{
  void myOtherMethod(); // interface method
}

// Implement multiple interfaces
class DemoClass : IFirstInterface, ISecondInterface 
{
  public void myMethod() 
  {
    Console.WriteLine("Some text..");
  }
  public void myOtherMethod() 
  {
    Console.WriteLine("Some other text...");
  }
}

class Program 
{
  static void Main(string[] args)
  {
    DemoClass myObj = new DemoClass();
    myObj.myMethod();
    myObj.myOtherMethod();
  }
}

