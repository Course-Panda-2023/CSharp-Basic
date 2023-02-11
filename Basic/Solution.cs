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
            Console.Write("Hello Panda");
        }

        public static void Assignment2()
        {
            List<int> num_lst = new List<int>();
            Console.WriteLine("enter passing grade");
            {while (true)
                {
                    string? input;
                    int val;
                    Console.WriteLine("Enter an integer value");
                    input = Console.ReadLine(); // collecting console input
                    if (input == null)
                        {Console.Write("Invalid input");}

                    else{
                        val = Convert.ToInt32(input); // Converting to integer type
                        if (val < 0)
                            {break;}
                        Console.WriteLine("You entered: {0}", input);
                            {num_lst.Add(val);}
                    }
                    
                }
                int len_num_lst = num_lst.Count();
                for (int i = 0; i < len_num_lst; i++)
                {
                    if ((num_lst[i]) < passing_grade)
                        {fail_count=+1;}
                }
            }
                //public var lst_as_queryable = num_lst.AsQueryable();
                double avg = Queryable.Average(num_lst.AsQueryable());
                int top_grade = Queryable.Max(num_lst.AsQueryable());
                int low_grade = Queryable.Min(num_lst.AsQueryable());

                Console.WriteLine($"Grades: {num_lst}");
                Console.WriteLine($"Average grade: {avg}");
                Console.WriteLine($"Top grade: {top_grade}");
                Console.WriteLine($"Lowest grade: {low_grade}");
                Console.WriteLine($"Failed {fail_count} tests");
        }
        private static int fail_count = 0;
        private static int passing_grade = 60;

        public static void Assignment3()
        
        {
            for (int num = 1; num < 1001; num++)
            {
            string i_str = $"{num}";
            if ((num % 15) == 0)
                {Console.WriteLine("FizzBuzz");}

            else if ((num % 5) == 0)
                {Console.WriteLine("Buzz");}

            else if ((num % 3) == 0)
                {Console.WriteLine("Fizz");}

            else
                {Console.WriteLine(i_str);}
            }
            

        }

        public static void Assignment4()
        {
        List<int> num_lst = new List<int>();
        bool is_true = true;
        string? first_input = Console.ReadLine(); // collecting console input
        if (first_input == null)
            {Console.Write("Invalid input, please enter an integer value");}

        else
            {
                int first_val = Convert.ToInt32(first_input); // Converting to integer type
                while (true)
                {
                    string? input;
                    int val;
                    Console.WriteLine("Please enter an integer value");
                    input = Console.ReadLine(); // collecting console input
                    if (input == null)
                        {Console.Write("Invalid input, please enter an integer value");}

                    else
                    {
                        val = Convert.ToInt32(input); // Converting to integer type
                        if (val < 0)
                            {break;}
                        Console.WriteLine("You entered: {0}", input);
                        if (is_true)
                        {
                            if (val % first_val != 0)
                            {
                                is_true=false;
                            }
                        }
                    }
                }
                Console.WriteLine($"{is_true}");
                
            }
        }

    }
}
