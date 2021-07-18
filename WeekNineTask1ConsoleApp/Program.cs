using System;

namespace WeekNineTask1ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        { 
            bool endApp = false;

    
            Console.WriteLine("Mycalculator program");
            Console.WriteLine("____________");

            string number1 = "";
            string number2 = "";

            //double result = 0;

            while (!endApp)
            {
                System.Console.WriteLine("Please enter the operation you want to perform");
                System.Console.WriteLine("Press + for Sum");
                System.Console.WriteLine("Press - for Differnce");
                System.Console.WriteLine("Press * for product");
                System.Console.WriteLine("Press / for division");
                System.Console.WriteLine("Press ** for square");
                string action_type = Console.ReadLine();

                Console.Write("Enter a number:  ");
                number1 = Console.ReadLine();

                double cleanNumber1 = 0;
                while (!double.TryParse(number1, out cleanNumber1))
                {
                     Console.WriteLine("Invalid input. Please enter an integer: ");
                     number1 = Console.ReadLine(); 
                }
                

                Console.Write("Enter another number:  ");
                number2 = Console.ReadLine();

                double cleanNumber2 = 0;
                while (!double.TryParse(number2, out cleanNumber2))
                {
                    Console.WriteLine("Invalid input. Please enter an integer: ");
                    number2 = Console.ReadLine();
                }

                //conditional statement to perform different operations
                switch (action_type)
                {
                    case "+":
                    {
                        Console.WriteLine($"{cleanNumber1} + {cleanNumber2} = " + MyCalculator.Sum(cleanNumber1, cleanNumber2));
                        break;
                    }


                    case "-":
                    {
                        Console.WriteLine($"{cleanNumber1} - {cleanNumber2} = " + MyCalculator.Difference(cleanNumber1, cleanNumber2));
                        break;
                    }

                    case "/":
                    {
                        if (num2 == 0)
                        {
                            Console.WriteLine("You can only divide by a non zero number");
                        }
                        else
                        {
                            Console.WriteLine($"{cleanNumber1} / {cleanNumber2} = " + MyCalculator.Division(cleanNumber1, cleanNumber2));
                        }
                        break;
                    }

                    case "*":
                    {
                        Console.WriteLine($"{cleanNumber1} * {cleanNumber2} = " + MyCalculator.Product(cleanNumber1, cleanNumber2));
                        break;
                    }

                    case "**":
                    {
                        Console.WriteLine($"{cleanNumber1} ** {cleanNumber2} = " + MyCalculator.Square(cleanNumber1, cleanNumber2));
                        break;
                    }

                    //default statement prompt when a user types in a wrong operator.
                    default:
                    {
                        Console.WriteLine("Invalid operator.");
                        break;
                    }
                }
                //Console.WriteLine("The result is " + result);
                Console.WriteLine("Press 'c' to check your calculation history.");
                if (Console.ReadLine() == "c")
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("CALCULATION HISTORY");
                    Console.WriteLine("---------------------------------");
                    MyCalculator.CheckHistory();
                }
                Console.WriteLine("Press any key to exit Application");
                endApp = true;
            }
        }
    }
}






















