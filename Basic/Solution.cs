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
            /*
             * Write code here
             */
        }

        public static void Assignment4()
        {
            /*
             * Write code here
             */
        }
    }
}
