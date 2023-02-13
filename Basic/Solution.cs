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
            int max = Helper.Constants.minimumGrade;
            int min = Helper.Constants.maximumGrade;
            const int failure = Helper.Constants.failure;
            int failGradesCount = 0;
            int gradesSum = 0;
            int gradesCount = 0;
            string input;
            int grade = 0;
            string keyToStop = Helper.Constants.keyToStop;
            Console.WriteLine("Enter grades. Press -1 to exit");

            do
            {
                input = Console.ReadLine();
                grade = Convert.ToInt32(input);
                if (!Helper.IsAValidGrade(grade)) continue;
                gradesSum += grade;
                if (grade > max)
                {
                    max = grade;
                }
                if (grade < min)
                {
                    min = grade;
                }
                if (grade < failure)
                {
                    ++failGradesCount;
                }
                ++gradesCount;
            } while (!input.Equals(keyToStop));
            double avg = (double) gradesSum / gradesCount;
            Console.WriteLine($"The average is {avg}");
            Console.WriteLine($"The maximum is {max}");
            Console.WriteLine($"The minimum is {min}");
            Console.WriteLine($"Failure count {failGradesCount}");
        }

        public static void Assignment3()
        {
            const int minRange = Helper.Constants.minRange;
            const int maxRange = Helper.Constants.maxRange;

            for (int i = minRange; i < maxRange; ++i)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                if (i % 5 != 0 && i % 3 != 0)
                {
                    Console.Write(i);
                }
                
                Console.WriteLine();
            }
        }

        public static void Assignment4()
        {
            string input;
            bool isAllDivided;
            int commonDivisor, number = 0;
            
            isAllDivided = true;
            Console.WriteLine("Enter a number that all be dived by this common divisor");
            input = Console.ReadLine();
            commonDivisor = Convert.ToInt32(input);
            number = 0;
            Console.WriteLine("Enter numbers. Press -1 to exit");

            do
            {
                input = Console.ReadLine();
                if (input is null) return;
                number = Convert.ToInt32(input);
                if (number == -1)
                {
                    Console.WriteLine(isAllDivided);
                    return;
                }
                if (number % commonDivisor != 0)
                {
                    isAllDivided = false;
                }
            } while (true);

            Console.WriteLine(isAllDivided);
        }
    }
}
