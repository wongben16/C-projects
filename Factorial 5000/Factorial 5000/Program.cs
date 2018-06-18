using System;

namespace Factorial_5000
{
    class Program
    {
        public static int factor;  

        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number from 1 to 5000.");
            do
            {
                if (factor < 1 || factor > 5000)
                {
                    Console.WriteLine("Invalid input");
                }
                factor = Int32.Parse(Console.ReadLine());
            } while (factor < 1 || factor > 5000);

            if (factor > 100)
            {
                System.Numerics.BigInteger bigFactor = new System.Numerics.BigInteger(factor);
            }


        }
    }
}
