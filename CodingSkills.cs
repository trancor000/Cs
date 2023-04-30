
using System;

namespace CodingSkills
{
    class Program
    {
        static void Main(string[] args)
        {
            Skills skills1 = new Skills("Nathan", 24, "Junior");
            Skills skills2 = new Skills("Matthew", 30, "Senior");
            Skills skills3 = new Skills("Clarice", 22, "Senior");

            skills1.Review();
            skills2.Review();
            skills3.Review();

            Console.ReadKey();
        }
    }

    class Skills
    {
        String name;
        int age;
        String developerLevel;

        public Skills(String name, int age, String developerLevel)
        {
            this.name = name;
            this.age = age;
            this.developerLevel = developerLevel;
        }

        public void Review()
        {
            Console.WriteLine($"Your name is {name}, your age is {age}, and your developer level is {developerLevel}.");
        }
    }
}
