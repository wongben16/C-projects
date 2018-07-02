using System;
using System.IO;

namespace TelephoneNum
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] telephoneNums = new String[12];
            var nums = File.ReadAllLines(@"C:\Users\Ben\C-projects\TelephoneNum\TelephoneNumberingPlan.txt");
            char[] delimiters = { ' ', '\n'};
            
            //Setup();


            for (int i = 0; i < nums.Length; i++)
            {
                telephoneNums = nums[i].Split(delimiters);

                Console.WriteLine(telephoneNums[0]);
            }

            

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
