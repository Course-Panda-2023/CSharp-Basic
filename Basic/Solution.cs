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
            Console.WriteLine("Hello Panda");
        }

        public static void Assignment2()
        {
            int grade = Convert.ToInt32(Console.ReadLine());
            int avg = grade;
            int high = grade;
            int low = grade;
            int count = 1;
            int fail_num = 0;
            if (grade < 60){
                fail_num += 1;
            } 

            while (grade != -1){
                grade = Convert.ToInt32(Console.ReadLine());
                avg += grade;
                if (grade > high){
                    high = grade;
                }
                if (grade < low){
                    low = grade;
                }
                if (grade < 60){
                fail_num += 1;
            } 
                count += 1;
            }
            avg = avg/count;

            Console.WriteLine("Average is: " + avg);
            Console.WriteLine("Low is: " + low);
            Console.WriteLine("High is: " + high);
            Console.WriteLine("Failed num is: " + fail_num);

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
