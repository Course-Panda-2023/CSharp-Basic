using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;








namespace Basic
{
    internal class Solution
    {
        public static void Assignment1()
        {
            Console.WriteLine("!panda Hello!");
        }

        public static void Assignment2()
        {
            int total = 0;
            int high = int.MinValue;
            int low = int.MaxValue;
            int count = 0;
            Console.WriteLine("enter number:");
            string num = Console.ReadLine();
            int intnum = Convert.ToInt32(num);
            while (intnum != -1)
            {
                if (intnum > high)
                {
                    high = intnum;
                }
                else if (intnum < low) 
                {
                    low = intnum; 
                }
                count++;
                total += intnum;
                num = Console.ReadLine();
                intnum = Convert.ToInt32(num);
            }
            Console.WriteLine((double)total / count);
        }

        public static void Assignment3()
        {

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) 
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0) 
                { 
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                { 
                    Console.WriteLine("Buzz");
                }
                else
                { 
                    Console.WriteLine(i); 
                }
            }
        }

        public static void Assignment4()
        {
            string num = Console.ReadLine();
            int baseNum = Convert.ToInt32(num);
            num = Console.ReadLine();
            int intnum = Convert.ToInt32(num);
            bool flag = true;
            while (intnum != -1)
            {
                if (intnum % baseNum != 0)
                {
                    flag = false;
                }
                num = Console.ReadLine();
                intnum = Convert.ToInt32(num);
            }
            Console.WriteLine(flag);
        }
    }
}
