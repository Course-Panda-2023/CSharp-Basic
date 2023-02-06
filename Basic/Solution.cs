using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Solution
    {
        public static void Assignment1()
        {
            Console.WriteLine("Hello panda!");
        }

        public static void Assignment2()
        {
            int score = 0, avg = 0, max = 0;
            while (score != -1)
            {
                score = Console.Read();
                Console.Write(score);
            }
            
        }

        public static void Assignment3()
        {
            for (int i = 1; i < 1001; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                
                else { Console.WriteLine(i); }
            }
        }

        public static void Assignment4()
        {
            /*
             * Write code here
             */
        }
    }
}
