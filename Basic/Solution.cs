using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
            int score = 0, sum = 0, min = 100, max = 0;
            int counter = 0, failsCounter = 0;
            const int failThreshold = 60;
            double avg = 0;
            score = Convert.ToInt32(Console.ReadLine());
            while (score != -1)
            {                           
                sum  = sum + score;                
                if (score > max)
                {
                    max = score;
                }
                else if (score < min)
                {
                    min = score;
                }
                if (score < failThreshold)
                {
                    failsCounter++;
                }
                score = Convert.ToInt32(Console.ReadLine());
                counter++;
            }
            avg = (double)sum / counter;            
            Console.WriteLine($"Max: {max}, Min: {min}, Avg: {avg}, Failed_num: {failsCounter}");
            
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
            int num = 0, fisrtNum = 0, counter = 0;
            bool status = true;
            num = Convert.ToInt32(Console.ReadLine());
            fisrtNum = num;
            while (num != -1)
            {               
                if(num % fisrtNum != 0)
                {
                    status = false;
                }
                num = Convert.ToInt32(Console.ReadLine());
                counter++;
            }
           if(!status)
            {
                Console.WriteLine($"false");
                return;
            }
           Console.WriteLine($"true");
        }
    }
}
