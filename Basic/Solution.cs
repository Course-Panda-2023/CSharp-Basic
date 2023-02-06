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
            string input;
            int number = 0;
            int sum = 0;
            int numbers = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            int FAILURE = 60;
            int count = 0;
            Console.WriteLine("Enter numbers. Press -1 to exit");
            while (number != -1)
            {
                input = Console.ReadLine();
                if (input is not null)
                {
                    number = Convert.ToInt32(input);
                    sum += number;
                    ++numbers;
                    if (number > max)
                    {
                        max = number;
                    }
                    if (number < min)
                    {
                        min = number;
                    }
                    if (number < FAILURE && number != -1)
                    {
                        ++count;
                    }
                }
            }
            double avg = sum / numbers;
            Console.WriteLine($"The average is {avg}, \nThe maximum is {max}\nThe minimum is {min}\nFailure count {count}");
        }

        public static void Assignment3()
        {
            const int MIN_RANGE = 0;
            const int MAX_RANGE = 1000;

            for (int i = MIN_RANGE; i < MAX_RANGE; ++i)
            {
                if (i % 5 == 0)
                {
                    if (i % 3  == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine("Buzz");
                    }
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        public static void Assignment4()
        {
            string input = Console.ReadLine();
            if (input is null)
            {
                return;
            }
            int div = Convert.ToInt32(input);
            int number = 0;
            Console.WriteLine("Enter numbers. Press -1 to exit");
            while (number != -1)
            {
                input = Console.ReadLine();
                if (input is not null)
                {
                    number = Convert.ToInt32(input);
                    if (number % div != 0)
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }
            Console.WriteLine("true");
        }
    }
}
