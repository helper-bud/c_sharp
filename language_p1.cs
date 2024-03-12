namespace HelloWorld
  //  namespace is a way to organize and group related classes
{
  class Program
  {
    static void Main(string[] args) // represents an array of command-line arguments passed to the program when it is executed
    {
      Console.WriteLine("Hello World i am started!"); 
      Console.WriteLine(3 + 3);

    }
  }
}
// using System means that we can use classes from the System namespace.
// namespace is used to organize your code, and it is a container for classes and other namespaces.

/*
int - stores integers (whole numbers), without decimals, such as 123 or -123
double - stores floating point numbers, with decimals, such as 19.99 or -19.99
char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
string - stores text, such as "Hello World". String values are surrounded by double quotes
bool - stores values with two states: true or false
also exist long variable. 
long has 8 bytes, int 3 bytes. 
*/
int myNum = 5;
double myDoubleNum = 5.99D;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello";

const int myNum = 15;
myNum = 20; // error
/*
The const keyword is useful when you want a variable to always store the same value, 
so that others (or yourself) won't mess up your code. 
*/

float f1 = 35e3F; // 35000
double d1 = 12E4D; // 120000
Console.WriteLine(f1);
Console.WriteLine(d1);

// type casting 
double myDouble = 9.78;
int myInt = (int) myDouble;    // Manual casting: double to int
Console.WriteLine(myDouble);   // Outputs 9.78
Console.WriteLine(myInt);      // Outputs 9

// conversion 
int myInt = 10;
double myDouble = 5.25;
bool myBool = true;
Console.WriteLine(Convert.ToString(myInt));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

// user input 
string userName = Console.ReadLine();
Console.WriteLine("Username is: " + userName);
// Console.ReadLine() method returns a string. you cannot get information from another data type, such as int.
// to take it or convert the input into that : 
int age = Convert.ToInt32(Console.ReadLine()); //  now you can get the int input.
Console.WriteLine("Your age is: " + age); 

// all same operator as java
int x = 5;
int y = 3;
Console.WriteLine(x > y); // returns True because 5 is greater than 3
&& :	Logical and	Returns True if both statements are true.	Ex: x < 5 &&  x < 10
|| : 	Logical or	Returns True if one of the statements is true.	Ex:	x < 5 || x < 4
!	 : Logical not	Reverse the result, returns False if the result is true.	Ex:	!(x < 5 && x < 10)


// C# Math
Math.Max(5, 10);
Math.Sqrt(64);
Math.Abs(-4.7); // 4.7
Math.Round(9.99); // 10

// c# string 
string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
txt.Length;
txt.ToUpper();   // Outputs "HELLO WORLD"
txt.ToLower();   // Outputs "hello world"
string lastName = "Doe";
string name = $"My full name is: {txt} {lastName}";
Console.WriteLine(txt[1]);  // Outputs "A"
Console.WriteLine(myString.IndexOf("B"));  // Outputs "1"
string txt = "We are the so-called \"Vikings\" from the north.";
/*
to print single quote or double quote or slash. 
\'	-> '	Single quote
\" ->	"	Double quote
\\	-> \	Backslash
*/

// conditional statements
/*
Use if to specify a block of code to be executed, if a specified condition is true
Use else to specify a block of code to be executed, if the same condition is false
Use else if to specify a new condition to test, if the first condition is false
Use switch to specify many alternative blocks of code to be executed
*/
switch(expression) 
{
  case x:
    // code block
    break;
  case y:
    // code block
    break;
  default: // The default keyword is optional and specifies some code to run if there is no case match:
    // code block
    break;
}

// short hand ternary operator 
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result); // Good evening.

// loops 
int i = 0;
while (i < 5) 
{
  Console.WriteLine(i);
  i++;
}
// do while loops
int i = 0;
do 
{
  Console.WriteLine(i);
  i++;
}
while (i < 5);
// for 
for (int i = 0; i < 5; i++) 
{
  Console.WriteLine(i);
}
// for each loop 
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars) 
{
  Console.WriteLine(i);
}
// C# Continue
for (int i = 0; i < 10; i++) 
{
  if (i == 4) 
  {
    continue;
  }
  Console.WriteLine(i);
}

// arrays 
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars[0]);
Console.WriteLine(cars.Length);
// Create an array of four elements without specifying the size 
string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};
Array.Sort(cars);
foreach (string i in cars)
{
  Console.WriteLine(i);
}
int[] myNumbers = {5, 1, 8, 9};
      Console.WriteLine(myNumbers.Max());  // returns the largest value
      Console.WriteLine(myNumbers.Min());  // returns the smallest value
      Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

// multidimensional array
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
// The single comma [,] specifies that the array is two-dimensional. 
// A three-dimensional array would have two commas: int[,,].
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
Console.WriteLine(numbers[0, 2]);  // Outputs 2
// loop through the arryas
foreach (int i in numbers)
{
  Console.WriteLine(i);
} 
// with conventional method 
for (int i = 0; i < numbers.GetLength(0); i++) 
{ 
  for (int j = 0; j < numbers.GetLength(1); j++) 
  { 
    Console.WriteLine(numbers[i, j]); 
  } 
} 
