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
            const int FAIL = 60;
            do
            {
                Console.WriteLine("enter grade, enter -1 to stop: ");
                string gradeStr = Console.ReadLine();
                grade = Convert.ToInt32(gradeStr);
                if(grade >= 0 && grade <= 100)
                {
                    if (grade < FAIL)
                    {
                        fail++;
                    }
                    numOfGrades += 1;
                    avg += grade;
                    if (low > grade)
                    {
                        low = grade;
                    }
                    else if (high < grade)
                    {
                        high = grade;
                    }
                }
            }
            while (grade != -1);
            if (numOfGrades != 0)
            {
                avg /= numOfGrades;
            }
            Console.WriteLine($"avg: {avg}, low: {low}, high: {high}, fail: {fail}");
        }

        public static void Assignment3()
        {
            int repeat = 1000;
            int div1 = 3;
            int div2 = 5;
            for (int i = 1; i <= repeat; i++)
            {
                if (i % div1 == 0 && i % div2 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % div2 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % div1 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Assignment4()
        {
            int num= 0;
            int numbers = 0;
            Console.WriteLine("enter number");
            string numString = Console.ReadLine();
            num = Convert.ToInt32(numString);
            bool flag = true;
            while (numbers!=-1){
                if(numbers%num!=0){
                    flag=false;
                }
                Console.WriteLine("enter number, enter -1 to stop: ");
                numString = Console.ReadLine();
                numbers = Convert.ToInt32(numString);
            }
            Console.WriteLine(flag);
        }
    }
}
