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
            List<double> grades = new List<double>();
            int newGrade = Convert.ToInt32(Console.ReadLine());

            while (newGrade != -1)
            {
                grades.Append(newGrade);
                newGrade = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine($"Average: {grades.Average()}");
            Console.WriteLine($"Maximum: {grades.Max()}");
            Console.WriteLine($"Maximum: {grades.Min()}");
            Console.WriteLine($"#Fails: {grades.Where(grade => grade < 60).Count()}");
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
