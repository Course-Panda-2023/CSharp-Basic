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
            /*
             * Write code here
             */
            Console.WriteLine("Hello panda!");
        }

        public static void Assignment2()
        {
            /*
             * Write code here
             */
            // Console.WriteLine("Enter grades:");
            double grade = Convert.ToDouble(Console.ReadLine()!);
            double avgGrade = 0;
            double maxGrade = 0;
            double minGrade = 101;
            int failNum = 0;
            int numGrades = 0;
            while (grade != -1) { 
                avgGrade += grade;
                if (grade > maxGrade)
                {
                    maxGrade = grade;
                }
                if (grade < minGrade)
                {
                    minGrade = grade;
                }
                if (grade < 60)
                {
                    failNum++;
                }
                numGrades++;
                grade = Convert.ToDouble(Console.ReadLine()!);
            }
            avgGrade /= numGrades;
            Console.WriteLine($"The average grade is: {avgGrade}\nThe maximal grade is: {maxGrade}\nThe minimal grade is: {minGrade}\nThe number of fails is: {failNum}");
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
