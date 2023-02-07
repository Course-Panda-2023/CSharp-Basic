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
            string input;
            int number = 0;
            int sum = 0;
            int numbers = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            int FAILURE = 60;
            int count = 0;
            Console.WriteLine("Enter numbers. Press -1 to exit");
            while (number != -1)
            {
                input = Console.ReadLine();
                if (input is not null)
                {
                    number = Convert.ToInt32(input);
                    sum += number;
                    ++numbers;
                    if (number > max)
                    {
                        max = number;
                    }
                    if (number < min)
                    {
                        min = number;
                    }
                    if (number < FAILURE && number != -1)
                    {
                        ++count;
                    }
                }
            }
            double avg = sum / numbers;
            Console.WriteLine($"The average is {avg}, \nThe maximum is {max}\nThe minimum is {min}\nFailure count  {count}");
        }

        public static void Assignment3()
        {
            const int MIN_RANGE = 0;
            const int MAX_RANGE = 1000;

            for (int i = MIN_RANGE; i < MAX_RANGE; ++i)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        Console.Write("Buzz");
                    }
                    else
                    {
                        Console.Write(i);
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Assignment4()
        {
            string input;
            bool isAllDivided;
            int commonDivisor, number = 0;
            Console.WriteLine("Enter a number that all be dived by this common divisor");
            input = Console.ReadLine();
            if (input is null)
            {
                return;
            }
            isAllDivided = true;
            commonDivisor = Convert.ToInt32(input);
            number = 0;
            Console.WriteLine("Enter numbers. Press -1 to exit");
            while (number != -1)
            {
                input = Console.ReadLine();
                
                if (input is not null)
                {
                    number = Convert.ToInt32(input);
                    if (number % commonDivisor != 0 && number != -1)
                    {
                        if (isAllDivided)
                        {
                            isAllDivided = false;
                        }   
                    }
                }
            }
            Console.WriteLine(isAllDivided ? "true" : "false");
        }
    }
}
