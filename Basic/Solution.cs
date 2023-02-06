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
            double currGrade = Convert.ToDouble(Console.ReadLine());
            double sumGrades = 0, minGrade = 0, maxGrade = 0, fails = 0, numGrades = 0;

            while (currGrade != -1)
            {
                numGrades += 1;
                
                if (currGrade < 60) { fails += 1; }

                sumGrades += currGrade;
                minGrade = Math.Min(minGrade, currGrade);
                maxGrade = Math.Max(maxGrade, currGrade);
                
                currGrade = Convert.ToDouble(Console.ReadLine());
            }
            
            Console.WriteLine($"Average: {sumGrades / numGrades}");
            Console.WriteLine($"Maximum: {maxGrade}");
            Console.WriteLine($"Maximum: {minGrade}");
            Console.WriteLine($"#Fails: {fails}");
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
