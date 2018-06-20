using System;
using System.IO;

namespace TelephoneNum
{
    class Program
    {
        public static String[] telephoneNums;
        public static StreamReader nums = new StreamReader(@"C:\Users\Ben\C-projects\TelephoneNum\TelephoneNumberingPlan.txt");
        public static String temp;
        public static String temp2;
        public static int counter = 0;

        static void Main(string[] args)
        {
            //Setup();

            ////test for textfile opening
            //while ((temp = nums.ReadLine()) != null)
            //{
            //    System.Console.WriteLine(temp);
            //    counter++;
            //}




            while ((temp = nums.ReadLine()) != null)
            {
                for (int i = 0; (temp = nums.ReadLine()) != null; i++)
                {
                    temp.Split(@"\s+");
                    telephoneNums[i] = temp;
                }
            }

            //for (int i = 0; i > telephoneNums.Length; i++)
            //{
            //    System.Console.WriteLine(telephoneNums[i]);
            //}

            System.Console.WriteLine("Please enter your phone number.");
            System.Console.ReadLine();



            System.Console.ReadKey();
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
