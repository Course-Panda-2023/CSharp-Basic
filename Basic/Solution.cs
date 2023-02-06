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
            const int STOP_INPUT = -1;
            const int PASS_GRADE = 60;

            double gradeSum = 0;
            int highestGrade = 0;
            int lowetGrade = 0;
            int numOfFails = 0;
            int gradeCounter = 0;

            Console.WriteLine("please enter a grade: ");
            int currGrade = int.Parse(Console.ReadLine());

            while (currGrade != STOP_INPUT)
            {
                gradeCounter++;
                gradeSum += currGrade;
                highestGrade = highestGrade < currGrade ? currGrade : highestGrade;
                lowetGrade = lowetGrade > currGrade ? currGrade : lowetGrade;
                numOfFails = currGrade < PASS_GRADE ? numOfFails + 1 : numOfFails;
            }
            Console.WriteLine($"Grade avarage is: {Math.Round(gradeSum / gradeCounter, 2)} , the highest grade is: {highestGrade}, " +
                $"and the lowest grade is: {lowetGrade}. the number of fails is: {numOfFails}");
            
        }

        public static void Assignment3()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i%3==0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    Console.WriteLine("FizzBuzz");
                } else 
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
