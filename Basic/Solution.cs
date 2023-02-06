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
            int numofgrades = 0;
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
                    numofgrades += 1;
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
            if (numofgrades != 0)
            {
                avg = avg / numofgrades;
            }
            Console.WriteLine("avg: " + avg);
            Console.WriteLine("low: " + low);
            Console.WriteLine("high: " + high);
            Console.WriteLine("fail: " + fail);
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
