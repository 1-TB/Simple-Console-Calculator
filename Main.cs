/* Jordan @1-TB */
using System.Text.RegularExpressions;
namespace Calculator;

public class Calculator {

  static void Main(string[] args)
  {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Title = "C# Calculator";
      string equation = "";
      while(equation != "stop")
      {
          Console.WriteLine("Please enter your calculation, for example 4+4\nthen press enter");
          equation = Console.ReadLine();
          string pattern = @"^(\d*\.\d+|\d+)([\+\-\*\/])(\d*\.\d+|\d+)$";
          Regex r = new Regex(pattern);
          if(r.IsMatch(equation.Replace(" ","")))
          {
              string[] parts;

              if(equation.Contains("+"))
              {
                  Console.Clear();
                  Console.WriteLine("This is an addition problem!");
                  parts = equation.Split("+");
                  Console.WriteLine($"{parts[0]} plus {parts[1]} equals {Calculation.Add(Convert.ToDouble(parts[0]),Convert.ToDouble(parts[1]))}");
              }
              if(equation.Contains("-"))
              {
                  Console.Clear();
                  Console.WriteLine("This is an subtraction problem!");
                  parts = equation.Split("-");
                  Console.WriteLine($"{parts[0]} minus {parts[1]} equals {Calculation.Subtract(Convert.ToDouble(parts[0]),Convert.ToDouble(parts[1]))}");
              }
              if(equation.Contains("*"))
              {
                  Console.Clear();
                  Console.WriteLine("This is a multiplication problem!");
                  parts = equation.Split("*");
                  Console.WriteLine($"{parts[0]} times {parts[1]} equals {Calculation.Multiply(Convert.ToDouble(parts[0]),Convert.ToDouble(parts[1]))}");
              }
              if(equation.Contains("/"))
              {
                  Console.Clear();
                  Console.WriteLine("This is a division problem!");
                  parts = equation.Split("/");
                  Console.WriteLine($"{parts[0]} divided by {parts[1]} equals {Calculation.Divide(Convert.ToDouble(parts[0]),Convert.ToDouble(parts[1]))}");
              }
          }else
          {
              Console.Clear();
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("Invalid entry...");
              Console.ForegroundColor = ConsoleColor.Blue;
             // Main(args);
          }
      }
      Console.Clear();
      Console.WriteLine("Stopped calculator");
  }


}