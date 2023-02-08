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

                if (currGrade < PASS_GRADE)
                {
                    numOfFails++;
                }
                if (highestGrade < currGrade)
                {
                    highestGrade = currGrade;
                }
                if (lowetGrade > currGrade)
                {
                    lowetGrade = currGrade;
                }

                Console.WriteLine("please enter a grade: ");
                currGrade = int.Parse(Console.ReadLine());
            }
            double gradeAvarage = Math.Round(gradeSum / gradeCounter, 2);
            Console.WriteLine($"Grade avarage is: {gradeAvarage} , the highest grade is: {highestGrade}, " +
                $"and the lowest grade is: {lowetGrade}. the number of fails is: {numOfFails}");
            
        }

        public static void Assignment3()
        {
            
            for (int currNum = 1; currNum <= 1000; currNum++)
            {
                if (currNum % 3 == 0 && currNum % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (currNum % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (currNum % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(currNum);
                }
            }
        }

        public static void Assignment4()
        {
            const int STOP_CONDITION_FLAG = -1;

            Console.WriteLine("Enter ultimate assignment number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter input to check: ");
            int currInput = int.Parse(Console.ReadLine());
            Boolean divides = true;

            while (currInput != STOP_CONDITION_FLAG)
            {
                if (currInput % firstNumber != 0)
                {
                    divides = false;
                    Console.WriteLine(divides);
                    break;
                }
                Console.WriteLine("Enter input to check: ");
                currInput = int.Parse(Console.ReadLine());
            }
            if (divides)
            {
                Console.WriteLine(divides);
            }
        }
    }
}
