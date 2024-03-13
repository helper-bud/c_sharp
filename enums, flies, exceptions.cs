enum Level 
{
  Low,
  Medium,
  High
}

Level myVar = Level.Medium;
Console.WriteLine(myVar); // medium 


// ---------- inside enum classes. 
class Program
{
  enum Level
  {
    Low,
    Medium,
    High
  }
  
  enum Months
{
  January,    // 0
  February,   // 1
  March,      // 2
  April,      // 3
  May,        // 4
  June,       // 5
  July        // 6
}
  static void Main(string[] args)
  {
    Level myVar = Level.Medium;
    Console.WriteLine(myVar); // Medium

  int myNum = (int) Months.April;
  Console.WriteLine(myNum); // 3
  // can be used based on swtich cases. 
  switch(myVar) 
  {
    case Level.Low:
      Console.WriteLine("Low level");
      break;
    case Level.Medium:
       Console.WriteLine("Medium level");
      break;
    case Level.High:
      Console.WriteLine("High level");
      break;
  }
  }
}
