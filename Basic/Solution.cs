using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Solution
    {
        public static void Assignment1()
        {
            Console.WriteLine("Hello Panda");
        }

        public static void Assignment2()
        {
            int grade = Convert.ToInt32(Console.ReadLine());
            float avg = 0;
            int high = grade;
            int low = grade;
            int count = 0;
            int fail_num = 0;

            while (grade != -1)
            {
                avg += grade;
                if (grade > high)
                {
                    high = grade;
                }
                if (grade < low)
                {
                    low = grade;
                }
                if (grade < 60)
                {
                fail_num++;
                } 
                count += 1;
                grade = Convert.ToInt32(Console.ReadLine());
            }
            avg = avg/count;

            Console.WriteLine("Average is: " + avg);
            Console.WriteLine("Low is: " + low);
            Console.WriteLine("High is: " + high);
            Console.WriteLine("Failed num is: " + fail_num);

        }

        public static void Assignment3()
        {
            for(int i=1; i<=1000; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine("Fizz");
                    }
                    
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
            /*
             * Write code here
             */
        }
    }
}
