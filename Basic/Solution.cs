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
            const int FailedGrade = 60;

            Console.WriteLine("Please enter a grade: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int maxGrade = num;
            int minGrade = num;
            int amountOfGrades = 0;
            int amountOfFails = 0;

            while (num != -1)
            {
                sum += num;
                amountOfGrades++;
                if (maxGrade < num)
                    maxGrade = num;
                else if (minGrade > num)
                    minGrade = num;
                if (num < FailedGrade)
                    amountOfFails++;

                Console.WriteLine("Please enter a grade: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Grade average: {(sum / amountOfGrades)}");
            Console.WriteLine($"Highest grade: {maxGrade}");
            Console.WriteLine($"Lowest grade: {minGrade}");
            Console.WriteLine($"Amount Of Fails: {amountOfFails}");
        }

        public static void Assignment3()
        {
            for (int i = 1; i <= 1000 ; i++)
            {
                if (i % 3 == 0)
                    Console.Write("Fizz");
                if (i % 5 == 0)
                    Console.Write("Buzz");
                else if (i % 3 != 0)
                    Console.Write(i);
                Console.WriteLine();
            }
        }

        public static void Assignment4()
        {
            Console.WriteLine("Please enter a series of numbers: ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int num = 0;
            bool result = true;
            while (num != -1)
            {
                if (num % divisor != 0)
                    result = false;
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(result);
        }
    }
}
