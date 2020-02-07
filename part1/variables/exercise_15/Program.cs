using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give a string:");
      string name = Console.ReadLine();
       Console.WriteLine("Give an integer:");
       string num = Console.ReadLine();
       int intValue = Convert.ToInt32(num);
       Console.WriteLine("Give a double:");
       string num2 = Console.ReadLine();
       double doubleValue = Convert.ToDouble(num2);
       Console.WriteLine("Give a boolean:");

       string truth = Console.ReadLine();
       bool booleanValue = System.Convert.ToBoolean(truth);
       Console.WriteLine ("Your string: " + name);
       Console.WriteLine ("Your integer: " + num);
       Console.WriteLine ("Your double: " + num2);
       Console.WriteLine ("Your boolean: " + truth);






            
       
            
            

    }
  }
}
