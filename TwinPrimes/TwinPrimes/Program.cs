using System;

namespace TwinPrimes
{
    class TwinPrimes
    {
        public static String input;
        public static int[] primes;


        static void Main(string[] args)
        {

            Console.WriteLine("How many digits do you want the twin prime numbers to be? (1 - 10) ");
            input = Console.ReadLine();
            Console.WriteLine("\n");

            while (Int32.Parse(input) < 1 || Int32.Parse(input) > 10)
            {
                Console.WriteLine("Invalid input, Please try again.");
                Console.WriteLine("How many digits do you want the twin prime numbers to be? (1 - 10) ");
                input = Console.ReadLine();
                Console.WriteLine("\n");
            }




            PrimeCalc(input);


            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void PrimeCalc(String a)
        {
            //may need to do recursion for this problem

            //Console.WriteLine(input);
            foreach (int j in primes)
            {

            }

        }
    }
}
