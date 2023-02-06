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
            int low = 100;
            int high = 0;
            int fail = 0;
            double avg = 0;
            int numOfGrades = 0;
            int grade = 0;
            while (grade != -1)
            {
                Console.WriteLine("enter grade, enter -1 to stop: ");
                string gradeStr = Console.ReadLine();
                grade = Convert.ToInt32(gradeStr);
                if (grade < 60)
                {
                    fail += 1;
                }
                if (grade >= 0 && grade <= 100)
                {
                    numOfGrades += 1;
                    avg += grade;
                    if (low > grade)
                    {
                        low = grade;
                    }
                    if (high < grade)
                    {
                        high = grade;
                    }
                }
                else
                {
                    Console.WriteLine("invalid grade ");
                }

            }
            if (numOfGrades != 0)
            {
                avg = avg / numOfGrades;
            }
            Console.WriteLine("avg: " + avg);
            Console.WriteLine("low: " + low);
            Console.WriteLine("high: " + high);
            Console.WriteLine("fail: " + fail);
        }

        public static void Assignment3()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Assignment4()
        {
            int num = 0;
            int numbers = 0;
            Console.WriteLine("enter number");
            string numString = Console.ReadLine();
            num = Convert.ToInt32(numString);
            bool flag = true;
            while (numbers != -1)
            {
                Console.WriteLine("enter number, enter -1 to stop: ");
                numString = Console.ReadLine();
                numbers = Convert.ToInt32(numString);
                if (numbers % num != 0 && numbers != -1)
                {
                    flag = false;
                }
            }
            Console.WriteLine(flag);
        }
    }
}
