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
                }
            }
            double avg = sum / numbers;
            Console.WriteLine($"The average is {avg}, \nThe maximum is {max}\nThe minimum is {min}");
        }

        public static void Assignment3()
        {
            /*
             * Write code here
             */
        }

        public static void Assignment4()
        {
            /*
             * Write code here
             */
        }
    }
}
