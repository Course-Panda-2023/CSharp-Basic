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
            int sumOfGrades = 0;
            int highestGrade = 0;
            int lowestGrade = 0;
            int amountOfFailures = 0;
            bool stopGettingGrades = false;
            int amountOfGrades = 0;
            int currentGrade;
            while (stopGettingGrades == false)
            {
                try
                {
                    Console.WriteLine("Enter a grade");
                    currentGrade = Int32.Parse(Console.ReadLine());
                    if (currentGrade >= 0 && currentGrade <= 100)
                    {
                        if (amountOfGrades == 0)
                        {
                            highestGrade= currentGrade;
                            lowestGrade = currentGrade;
                        }
                        else
                        {
                            if (currentGrade > highestGrade)
                            {
                                highestGrade = currentGrade;
                            }
                            if (currentGrade < lowestGrade)
                            {
                                lowestGrade = currentGrade;
                            }
                        }
                        if (currentGrade < 60)
                        {
                            amountOfFailures++;
                        }
                        sumOfGrades += currentGrade;
                        amountOfGrades++;
                    }
                    else if (currentGrade == -1)
                    {
                        if (amountOfGrades == 0)
                        {
                            Console.WriteLine("No grades were entered");
                        }
                        else
                        {
                            double avergeOfGrades = (double)sumOfGrades / amountOfGrades;
                            Console.WriteLine($"Averge: {avergeOfGrades}\n" +
                                $"Highest grade: {highestGrade}\n" +
                                $"Lowest grade: {lowestGrade}\n" +
                                $"Amount of failures: {amountOfFailures}");
                            stopGettingGrades = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid grade");
                    }
                }
                catch(Exception ex) 
                {
                    Console.WriteLine("Invalid grade");
                }
            }
        }

        public static void Assignment3()
        {
            for (int num = 1; num <= 1000; num++)
            {
                if (num % 3 == 0)
                {
                    Console.Write("Fizz");
                    if (num % 5 != 0)
                    {
                        Console.WriteLine("");
                    }
                }
                if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (num % 3 != 0 && num % 5 != 0)
                {
                    Console.WriteLine($"{num}");
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
