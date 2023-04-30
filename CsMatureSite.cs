
using System;

namespace CsMatureSite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to this Mature Site!");
            Console.WriteLine("This site is only for 18+. Please state your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18 ) 
            {
                Console.WriteLine("You are now entering this mature site.");
            }
            else
            {
                Console.WriteLine("You are not old enough to enter this mature site.");
            }

            Console.ReadKey();
        }
    }
}
