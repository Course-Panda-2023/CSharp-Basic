using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Solution
    {
        public static int FAIL_THRESH = 60;
        public static void Assignment1()
        {
            Console.WriteLine("Hello Panda");
        }

        public static void Assignment2()
        {
            float avg = 0;
            int high = 0;
            int low = 100;
            int count = 0;
            int fail_num = 0;
            int grade;
            do
            {
                grade = Convert.ToInt32(Console.ReadLine());
                if (grade != -1)
                {
                    avg += grade;
                    high = Math.Max(grade, high);
                    low = Math.Min(grade, low);
                    if (grade < FAIL_THRESH)
                    {
                        fail_num++;
                    } 
                    count++;
                }
            }
            while (grade != -1);
            avg /= count;

            Console.WriteLine($"Average is: {avg}");
            Console.WriteLine($"Low is: {low}");
            Console.WriteLine($"High is: {high}");
            Console.WriteLine($"Failed num is: {fail_num}");
        }

        public static void Assignment3()
        {
            for(int i=1; i<=1000; i++)
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
            bool allDivisible = true;
            Console.WriteLine("Enter division number");
            int diviseNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter all numbers, stop with -1");
            int num = 0; 
            do
            {
                if(num % diviseNum != 0)
                {
                    allDivisible = false;
                }
                num = Convert.ToInt32(Console.ReadLine());
            }
            while(num != -1);

            Console.WriteLine(allDivisible);
        }
    }
}
