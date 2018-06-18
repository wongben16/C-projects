using System;

namespace Factorial_5000
{
    class Program
    {
        public static int factor = 1;
        public static int temp;

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

            System.Numerics.BigInteger bigFactor = new System.Numerics.BigInteger(factor);

            temp = factor;

            while (temp != 1)
            {
                //Console.WriteLine(bigFactor + " * " + temp);
                bigFactor *= --temp;
              
            }

            Console.WriteLine("Your factorial equals to: " + bigFactor + ".");

            Console.ReadKey();
        }

    }
}
