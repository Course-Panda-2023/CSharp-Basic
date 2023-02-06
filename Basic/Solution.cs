using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
            int score = 0, sum = 0, min = Int32.MaxValue, max = 0, counter = 0, fails_conter = 0;
            double avg = 0;
            while (true)
            {                
                counter++;                
                score = Convert.ToInt32(Console.ReadLine());
                if (score == -1)
                { 
                    break;
                }
                sum  = sum + score;                
                if (score > max)
                {
                    max = score;
                }
                if (score < min)
                {
                    min = score;
                }
                if (score < 60)
                {
                    fails_conter++;
                }
            }
            avg = (double)sum / counter;            
            Console.WriteLine($"Max: {max}, Min: {min}, Avg: {avg}, Failed_num {fails_conter}");
            
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
