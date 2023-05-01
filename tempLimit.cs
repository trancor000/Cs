
using System;

namespace tempLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            Limit limit = new Limit(90);

            limit.Temp = 1000;

            Console.WriteLine(limit.Temp);

            Console.ReadKey();
        }
    }

    class Limit
    {
        private int temp;

        public Limit(int temperature) 
        {
            Temp = temp;
        }

        public int Temp
        {
            get { return temp; }
            set
            {
                if (value > 100)
                {
                    temp = 100;
                }
                else
                {
                    temp = value;
                }
            }
        }
    }
}
