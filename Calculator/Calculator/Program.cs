using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue;
            int secondValue;
            string action;

            Console.WriteLine("Enter the first number");
            firstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            secondValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose the action: '+' '-' '*' '/'");
            action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;

                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;

                case "*":
                    Console.WriteLine(firstValue * secondValue);
                    break;

                case "/":
                    if (secondValue == 0)
                    {
                        Console.WriteLine("Enter correct number");
                    }
                    else
                    {
                        Console.WriteLine(firstValue / secondValue);
                    }
                    break;

                default:
                    Console.WriteLine("Unknown action");
                    break;
            }
        }
    }
}