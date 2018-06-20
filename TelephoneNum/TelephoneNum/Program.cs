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

            
            




        }

        public static void Setup()
        {
            StringReader nums = new StringReader("Telephone Numbering Plan");
            String temp;
            String temp2;
            int i = 0;

            while ((temp = nums.ReadLine()) != null)
            {
                temp.Split(@"\s+");
                telephoneNums[i] = temp;
                i++;
            }
        }
    }
}
