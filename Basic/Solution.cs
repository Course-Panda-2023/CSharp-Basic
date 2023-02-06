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
            Console.WriteLine("Please enter grade: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = num;
            int max = num;
            int min = num;
            int counter = 1;
            int amountOFFails = num < 60 ? 1 : 0;
            while (num != -1)
            {
                Console.WriteLine("Please enter grade: ");
                num = Convert.ToInt32(Console.ReadLine());
                if(num != -1)
                {
                    sum += num;
                    counter++;
                    max = max < num ? num : max;
                    min = min > num ? num : min;
                    amountOFFails += num < 60 ? 1 : 0;
                }
            }
            Console.WriteLine("Grade average: " + (sum / counter));
            Console.WriteLine("Highest grade: " + max);
            Console.WriteLine("Lowest grade: " + min);
            Console.WriteLine("Amount Of Fails: " + amountOFFails);

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
            int div = Convert.ToInt32(Console.ReadLine());
            int num = 0;
            bool result = true;
            while (num != -1)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num % div != 0 && num != -1)
                    result = false;
            }
            Console.WriteLine(result);
        }
    }
}
