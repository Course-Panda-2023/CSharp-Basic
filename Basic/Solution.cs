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
            List<int> numList = new List<int>();
            Console.WriteLine("enter passing grade");
            while (true)
                {
                    string? input;
                    int val;
                    Console.WriteLine("Enter an integer value");
                    input = Console.ReadLine(); // collecting console input
                    if (input == null) //validates input
                        {
                            Console.Write("Invalid input, please try again or type -1 to cancel");
                        }

                    else
                    {
                        val = Convert.ToInt32(input); // Converting to integer type
                        if (val == -1) // checks if -1 was inputed (exit condition)
                            {
                                break;
                                }

                        Console.WriteLine($"You entered: {input}");
                            {
                            numList.Add(val);
                            }
                    }
                    
                }
                int len_numList = numList.Count();
                for (int i = 0; i < len_numList; i++)
                {
                    if (numList[i] < passing_grade)
                        {
                        fail_count=+1;
                        }
                }
            
                //public var lst_as_queryable = numList.AsQueryable();
                double avg = Queryable.Average(numList.AsQueryable());
                int top_grade = Queryable.Max(numList.AsQueryable());
                int low_grade = Queryable.Min(numList.AsQueryable());

                Console.WriteLine($"Grades: {numList}");
                Console.WriteLine($"Average grade: {avg}");
                Console.WriteLine($"Top grade: {top_grade}");
                Console.WriteLine($"Lowest grade: {low_grade}");
                Console.WriteLine($"Failed {fail_count} tests");
        }
        private static int fail_count = 0;
        private const int passing_grade = 60;

        public static void Assignment3()
        
        {
            for (int num = 1; num < 1001; num++)
            {
            string i_str = $"{num}";
            if ((num % 15) == 0)
                {
                Console.WriteLine("FizzBuzz");
                }

            else if ((num % 5) == 0)
                {
                Console.WriteLine("Buzz");
                }

            else if ((num % 3) == 0)
                {
                Console.WriteLine("Fizz");
                }

            else
                {
                Console.WriteLine(i_str);
                }
            }
            

        }

        public static void Assignment4()
        {
        List<int> numList = new List<int>();
        bool returnValue = true;
        string? first_input = Console.ReadLine(); // collecting console input
        if (first_input == null)
            {Console.Write("Invalid input, please try again or type -1 to cancel");}
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
                        {Console.Write("Invalid input, please try again or type -1 to cancel");}
                    else
                    {
                        val = Convert.ToInt32(input); // Converting to integer type
                        if (val < 0)
                            {break;}
                        Console.WriteLine("You entered: {0}", input);

                        if (val % first_val != 0)
                            {
                                returnValue=false;
                            }
                        }
                    }
                }
                Console.WriteLine($"{returnValue}");
                
            }
        }

    }
