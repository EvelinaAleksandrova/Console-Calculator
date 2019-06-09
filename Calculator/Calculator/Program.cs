using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.BackgroundColor = ConsoleColor.Green;
            Console.Title = "Calculator";
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello,{name} this is your calculator!");

            Console.WriteLine("Enter ('+' , '-' ,'*' ,'/')");
            string symbol = Console.ReadLine();
            Console.WriteLine("Enter your First number.");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Second number.");
            double number2 = double.Parse(Console.ReadLine());
            double result = 0;

            switch (symbol)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case " - ":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("This is not correct format!");
                    return;
            }
            Console.WriteLine($"Your result is: {result}");

        }
    }
}
