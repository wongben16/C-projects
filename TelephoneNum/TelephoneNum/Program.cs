using System;
using System.IO;
using System.Linq;

namespace TelephoneNum
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] telephoneNums = new String[12];
            var nums = File.ReadAllLines(@"C:\Users\Ben\C-projects\TelephoneNum\TelephoneNumberingPlan.txt");
            Scanner phone = new Scanner(@"C:\Users\Ben\C-projects\TelephoneNum\TelephoneNumberingPlan.txt");
            char[] delimiters = { ' ', '\n'};

            //Setup();


            //for (int i = 0; i < nums.Length; i++)
            //{
            //    telephoneNums = nums[i].Split(delimiters);

            //    Console.WriteLine(telephoneNums[0]);
            //}


            //nums = nums[0].Split("       ");
            foreach (String i in nums)
            {
                //i.Split("       ")
                Console.WriteLine(i);
                i.Trim();
                
                //Console.WriteLine(nums[i+1]);
            }

            

            Console.WriteLine("Please enter your phone number.");
            Console.ReadLine();



            Console.ReadKey();
        }

       
    }

    class Scanner : System.IO.StringReader
    {
        String currentWord;

        public Scanner(String source) : base(source)
        {
            readNextWord();
        }

        private void readNextWord()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            char nextChar;
            int next;
            do
            {
                next = this.Read();
                if (next < 0)
                {
                    break;
                }
                nextChar = (char)next;
                if (char.IsWhiteSpace(nextChar))
                {
                    break;
                }
                sb.Append(nextChar);
            } while (true);
            while ((this.Peek() >= 0) && (char.IsWhiteSpace((char)this.Peek())))
            {
                this.Read();
            }
            if (sb.Length > 0)
            {
                currentWord = sb.ToString();
            }
            else
            {
                currentWord = null;
            }
        }

        public bool hasNextInt()
        {
            if (currentWord == null)
            {
                return false;
            }

            int dummy;
            return int.TryParse(currentWord, out dummy);
        }

        public int nextInt()
        {
            try
            {
                return int.Parse(currentWord);
            }
            finally
            {
                readNextWord();
            }
        }

        public bool hasNextDouble()
        {
            if (currentWord == null)
            {
                return false;
            }
            double dummy;
            return double.TryParse(currentWord, out dummy);
        }

        public double nextDouble()
        {
            try
            {
                return double.Parse(currentWord);
            }
            finally
            {
                readNextWord();
            }
        }

        public bool hasNext()
        {
            return currentWord != null;
        }

    }
}
