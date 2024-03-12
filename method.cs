class Program
{
  static void MyMethod() 
  {
    // code to be executed
  }
}
/*
MyMethod() is the name of the method.
static means that the method belongs to the Program class and not an object of the Program class.
*/


// calling from main method 
static void MyMethod() 
{ Console.WriteLine("I just got executed!"); }

static void MyMethod_2(string fname)  // you can provide multiple parameter.
{ Console.WriteLine(fname + " Refsnes"); }

static void Main(string[] args)
{
  MyMethod();
  MyMethod_2("Liam");
  MyMethod_2("Jenny");
  MyMethod_2("Anja");
}


// default parameter value 
static void MyMethod(string country = "Norway") 
{
  Console.WriteLine(country);
}
static void Main(string[] args)
{
  MyMethod("Sweden");
  MyMethod("India");
  MyMethod();
  MyMethod("USA");
}
static int MyMethod(int x) 
{
  return 5 + x;
}



// named arguments
static void MyMethod(string child1, string child2, string child3) 
{
  Console.WriteLine("The youngest child is: " + child3);
}
static void Main(string[] args)
{
  MyMethod(child3: "John", child1: "Liam", child2: "Liam");
}
