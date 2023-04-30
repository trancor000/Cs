

using System;

namespace CsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double a = 0;
                double b = 0;
                double calc = 0;

                Console.Write("Enter a number: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter a number: ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter a mathematical symbol: +, -, *, /");

                switch (Console.ReadLine())
                {
                    case "+":
                        calc = a + b;
                        Console.WriteLine(calc);
                        break;
                    case "-":
                        calc = a - b;
                        Console.WriteLine(calc);
                        break;
                    case "*":
                        calc = a * b;
                        Console.WriteLine(calc);
                        break;
                    case "/":
                        calc = a / b;
                        Console.WriteLine(calc);
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Console.WriteLine("Would you like to continue? (Y = yes, N = no): ");

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.Write("Thank you");
            Console.ReadKey();
        }
    }
}

