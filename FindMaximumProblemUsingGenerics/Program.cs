using System;

namespace FindMaximumProblemUsingGenerics
{
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            int integerOutput = MaximumNumberCheck.MaximumIntegerNumber(80, 40, 20);
            Console.WriteLine("The maximum integer number is: " + integerOutput);
        }
    }
}
