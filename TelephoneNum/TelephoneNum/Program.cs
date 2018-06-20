using System;
using System.IO;

namespace TelephoneNum
{
    class Program
    {
        public static String[] telephoneNums;

        static void Main(string[] args)
        {


            Setup();

            System.Console.WriteLine("Please enter your phone number.");
            System.Console.ReadLine();



            System.Console.ReadKey();
        }

        public static void Setup()
        {
            StringReader nums = new StringReader("Telephone Numbering Plan");
            String temp;
            String temp2;

            while ((temp = nums.ReadLine()) != null)
            {
                for (int i = 0; (temp = nums.ReadLine()) != null; i++) {
                    temp.Split(@"\s+");
                    telephoneNums[i] = temp;
                }
            }
        }
    }
}
