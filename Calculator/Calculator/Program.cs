using System;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";
            Console.WriteLine("Enter a color");
            string color = Console.ReadLine();
            color = color.ToLower();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else if (color == "magenta")
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }
            else if (color == "yellow")
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            else if (color == "white")
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            else if (color == "blue")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.WriteLine("The color can't set up.");
            }

            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello,{name} this is your calculator!");
            Thread.Sleep(2000);
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
                case "-":
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
