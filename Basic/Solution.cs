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
            Console.WriteLine("Hello Panda!");
        }

        public static void Assignment2()
        {
            int i = 1;
            int failed = 0;
            Console.WriteLine("Enter number");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int worstGrade = inputNumber;
            int bestGrade = inputNumber;
            double avg = inputNumber;
            while (inputNumber != -1)
            {
                Console.WriteLine("Enter number");
                inputNumber = Convert.ToInt32(Console.ReadLine());
                if (inputNumber != -1)
                {
                    avg += inputNumber;
                    if (worstGrade > inputNumber)
                        worstGrade = inputNumber;
                    if (bestGrade < inputNumber)
                        bestGrade = inputNumber;
                    if (inputNumber < 60)
                        failed++;
                    i++;
                }
            }
            Console.WriteLine("Average: " + avg / i);
            Console.WriteLine("Best Grade: " + bestGrade);
            Console.WriteLine("Worst Grade: " + worstGrade);
            Console.WriteLine("Number of fails: " + failed);
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
                else { Console.WriteLine(i); }
            }
        }

        public static void Assignment4()
        {
            bool flag = true;
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == -1)
            {
                flag = false;
                Console.WriteLine(flag);
            }
            else
            {
                while (number != -1)
                {
                    if (number % 3 != 0)
                    {
                        flag = false;
                    }
                    number = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(flag);
            }
        }
    }
}
