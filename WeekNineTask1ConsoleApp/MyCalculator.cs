using System;
using System.Collections.Generic;

namespace WeekNineTask1ConsoleApp
{
    // declartion of addition,subtraction,Division,square and multilication
    public class MyCalculator 
    {
        //creating a list
        List<MyCalculator> myCalculators = new List<MyCalculator>();
        
        public double initialNumber1 { get; set; }

        public double initialNumber2 { get; set; }

        public string action { get; set; }

        public double results { get; set; }

        //method to return history message
        public override string ToString()
        {
            return $"{calcNum1} {calcOp} {calcNum2} = {calcResult}";
        }
        
        //declaring default value for result.
        static double result = 0;

        public static double Sum(double num1, double num2)
        {
            myCalculators.Add(new MyCalculator() { initialNumber1 = num1, initialNumber2 = num2, action = "+", results = result });
            result = num1 + num2;
            return result;
        }
        public static double Difference(double num1, double num2)
         {
            myCalculators.Add(new MyCalculator() { initialNumber1 = num1, initialNumber2 = num2, action = "-", results = result });
            result = num2 - num1;
            return result;
        }
        public static double Product(double num1, double num2)
        {
            myCalculators.Add(new MyCalculator() { initialNumber1 = num1, initialNumber2 = num2, action = "*", results = result });
            result = num2 * num1;
            return result;
        }
        public static double Division(double num1, double num2)
        {
            myCalculators.Add(new MyCalculator() { initialNumber1 = num1, initialNumber2 = num2, action = "/", results = result });
            result = num2 / num1;
            return result;
        }
        public static double Square(double num1, double num2)
        {
            myCalculators.Add(new MyCalculator() { initialNumber1 = num1, initialNumber2 = num2, action = "**", results = result });
            result = Math.Pow(num1, num2);
            return result;
        }

        public static void CheckHistory()
        {
            foreach (MyCalculator savedOperations in myCalculators)
            {
                Console.WriteLine(savedOperations);
            }
        }
    }
}
















