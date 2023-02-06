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

            // Console.WriteLine("Enter grades");
            double grade = 0;
            double avr = 0;
            double maxGrd = 0;
            double minGrd = 101;
            int numOfFails = 0;
            int numOfGrades = 0;
            while (grade != -1) {
                grade = Convert.ToDouble(Console.ReadLine());
                if (grade == -1) 
                {
                    break;
                }
                avr = avr + grade;
                if (grade > maxGrd)
                {
                    maxGrd = grade;
                }
                if (grade < minGrd ) 
                {
                    minGrd = grade;
                }
                if (grade < 60)
                {
                    numOfFails++;
                }
                numOfGrades++;
            }
            avr = avr / numOfGrades;
            Console.WriteLine($" The mean grade is: { avr }\n The highest grade is: { maxGrd }\n The lowest grade is: { minGrd }\n The numbers of fails is: { numOfFails } ");
        }

        public static void Assignment3()
        {
            for (int i=1; i<=1000; i++) {
                if (i % 5 == 0 && i % 3 == 0) 
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ( i % 5 ==0)
                {
                    Console.WriteLine("Buzz");
                }
                else if ( i % 3 == 0 )
                {
                    Console.WriteLine("Fizz");
                }
                else
                    Console.WriteLine(i); 
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
