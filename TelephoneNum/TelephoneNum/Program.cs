using System;
using System.IO;

namespace TelephoneNum
{
    class Program
    {
        
        public static String temp;
        public static String temp2;
        public static int counter = 0;

        static void Main(string[] args)
        {
            String[] telephoneNums = new String[12];
            var nums = File.ReadAllLines(@"C:\Users\Ben\C-projects\TelephoneNum\TelephoneNumberingPlan.txt");
            //Setup();

            ////test for textfile opening
            //while ((temp = nums.ReadLine()) != null)
            //{
            //    System.Console.WriteLine(temp);
            //    counter++;
            //}




            for (int i = 0; i < nums.Length; i++)
            {
                telephoneNums = nums[i].Split(@"\s+");
                Console.WriteLine(telephoneNums[0]);
            }

            //for (int i = 0; i > telephoneNums.Length; i++)
            //{
            //    System.Console.WriteLine(telephoneNums[i]);
            //}

            Console.WriteLine("Please enter your phone number.");
            Console.ReadLine();



            Console.ReadKey();
        }

        //public static void Setup()
        //{


        //    while ((temp = nums.ReadLine()) != null)
        //    {
        //        for (int i = 0; (temp = nums.ReadLine()) != null; i++) {
        //            temp.Split(@"\s+");
        //            telephoneNums[i] = temp;
        //        }
        //    }
        //}
    }
}
