using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal static class Helper
    {
        public static void ManageAssignment(int assignmentNum, Action assignment, string correctRes)
        {
            Console.WriteLine($"Running assignment {assignmentNum}...");
            Console.WriteLine($"Wanted solution: {correctRes}");
            Console.Write($"Your solution: ");
            assignment();
        }

        public static class Constants
        {
            /**Assignment 2**/
            public const int failure = 100;
            public const int minimumGrade = 0;
            public const int maximumGrade = 100;
            public const string keyToStop = "-1";

            /**Assignment 3**/
            public const int minRange = 0;
            public const int maxRange = 1000;
        }

        public static bool IsAValidGrade(int grade)
        {
            return Constants.minimumGrade <= grade && grade <= Constants.maximumGrade;
        }
    }
}
