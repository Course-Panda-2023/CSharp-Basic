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
            Console.Write("Hello panda!");
        }

        public static void Assignment2()
        {
            int gradeNum = 0;
            int gradeSum = 0;
            int highestGrade = 0;
            int lowestGrade = 100;
            int numOfFails = 0;

            bool loop = true;

            while (loop)
            {
                Console.WriteLine("give me a grade: ");
                int grade = int.Parse(Console.ReadLine());

                if (grade == -1)
                {
                    break;
                }
                else if (grade > 100)
                {
                    Console.WriteLine("grade bigger than 100, try another num");
                }
                else
                {
                    gradeSum += grade;
                    if (grade < 60)
                    {
                        numOfFails++;
                    }

                    if (grade > highestGrade)
                    {
                        highestGrade = grade;
                    }
                    else if (grade < lowestGrade)
                    {
                        lowestGrade = grade;
                    }
                    gradeNum++;
                }

            }
            Console.WriteLine("num of grades: " + gradeNum);
            Console.WriteLine("highest grade: " + highestGrade);
            Console.WriteLine("lowest grade: " + lowestGrade);
            Console.WriteLine("number of fails: " + numOfFails);
            double average = Convert.ToDouble(gradeSum / gradeNum);
            Console.WriteLine("grade average: " + average);
        }

        public static void Assignment3()
        {
            int num = 1;
            while (num < 1000)
            {
                if (num % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    if (num % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (num % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(num);
                    }
                }
                num++;
            }
        }

        public static void Assignment4()
        {
            bool loop = true;
            bool areNumsDividable = true;
            Console.WriteLine("give me a num to get divisor: ");
            int divNum = int.Parse(Console.ReadLine());
            Console.WriteLine("give me a num: ");
            while (loop)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == -1)
                {
                    break;
                }
                if (!(num % divNum == 0)) { 
                    areNumsDividable = false;
                }
                //Console.Write(",");
            }
            Console.WriteLine(areNumsDividable);
        }
    }
}
