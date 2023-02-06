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
            Console.WriteLine("hi");
            //comment
        }

        public static void Assignment2()
        {
            Console.WriteLine("welcome to question 2");
            int total = 0;
            int numGrades = 0;
            int maxGrade = 0;
            int minGrade = 100;
            int fails = 0;
            int newGrade = int.Parse(Console.ReadLine());
            Console.WriteLine("you entered the grade ", newGrade);
            while (newGrade != -1)
            {
                total += newGrade;
                numGrades++;
                maxGrade = Math.Max(maxGrade, newGrade);
                minGrade = Math.Min(minGrade, newGrade);
                if (newGrade < 60)
                {
                    fails++;
                }
                newGrade = int.Parse(Console.ReadLine());
                Console.WriteLine("you entered the grade ", newGrade);
            }
            Console.WriteLine("average: ");
            Console.WriteLine(total / numGrades);
            Console.WriteLine("max grade: ");
            Console.WriteLine(maxGrade);
            Console.WriteLine("min grade: ");
            Console.WriteLine(minGrade);
            Console.WriteLine("fails: ");
            Console.WriteLine(fails);
        }

        public static void Assignment3()
        {
            for (int i = 1; i <= 1000; i++)
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
                else
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine("Buzz");
                    }
                }
            }
        }

        public static void Assignment4()
        {
            bool areAllDividers = true;
            int divider = int.Parse(Console.ReadLine());
            int product = int.Parse(Console.ReadLine());
            while (product != -1)
            {
                if (product % divider != 0)
                {
                    areAllDividers = false;
                }
                product = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(areAllDividers);
        }
    }
}
