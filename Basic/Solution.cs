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
            int grade;
            int min = 100;
            int avr = 0;
            int max = 0;
            int num = 0;
            int numOfFailed = 0;
            Console.WriteLine("Enter your grade: ");
            grade = int.Parse(Console.ReadLine());
            while (grade >= 0)
            {
                avr += grade;
                num++;
                if (grade < 60)
                    numOfFailed++;
                if (max < grade)
                    max = grade;
                else if (min > grade)
                    min = grade;
                Console.WriteLine("Enter another grade: ");
                grade = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The average is: " + Math.Round((double)avr / (double)num, 2) + "\nMax: " + max + "\nMin: " + min + "\nFailed: " + numOfFailed);

        }

        public static void Assignment3()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 15 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else Console.WriteLine(i);
            }
        }

        public static void Assignment4()
        {
            int num = 0;
            Boolean divide3 = true;
            Console.WriteLine("Enter number");
            num = int.Parse(Console.ReadLine());
            while (num >= 0)
            {
                if (divide3 && num % 3 != 0)
                    divide3 = false;
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(divide3);

        }
    }
}
