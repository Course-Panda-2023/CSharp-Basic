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
            Console.WriteLine("Hello panda!");
        }

        public static void Assignment2()
        {
            int numberFails = 0;
            int gradeSum = 0;
            double gradeCount = 0;
            int maxGrade = 0;
            int minGrade = 0;
            Console.WriteLine("Enter Grades: ");
            int input = Convert.ToInt32(Console.ReadLine());
            while (input != -1)
            {
                if (input >= maxGrade)
                {
                    maxGrade = input;
                }
                if (input <= minGrade)
                {
                    minGrade = input;
                }
                gradeSum = gradeSum + input;
                if (input < 60)
                {
                    numberFails = numberFails + input;
                }
                gradeCount = gradeCount + 1;
                input = Convert.ToInt32(Console.ReadLine());
            }
            double gradeAverage = -1;
            if (gradeCount != 0)
            {
                gradeAverage = gradeSum / gradeCount;
                Console.WriteLine("Number of fails: " + numberFails + " Average: " + gradeAverage + " Minimum grade: " + minGrade + " Maximum grade: " + maxGrade);
            }
            else
            {
                Console.WriteLine("No grades entered");
            }
        }

        public static void Assignment3()
        {
            for (int i = 1; i <= 1000; i++)
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
            Console.WriteLine("Enter Divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array: ");
            int input = 0;
            bool flag = true;
            while (input != -1)
            {
                input = Convert.ToInt32(Console.ReadLine());
                if ((input % divisor != 0) && (input != -1))
                {
                    flag = false;
                }
            }
            Console.WriteLine(flag);
        }
    }
}
