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
            /// Giving integer numbers and, invoke Maximum Method to find maximum number
            int integerOutput = new MaximumNumberCheck.GenericMaximum<int>( 11, 22, 33 ).MaximumMethod();
            Console.WriteLine("Maximum of integer Number : " + integerOutput);

            /// Giving float numbers and, invoke Maximum Method to find maximum float number
            float floatOutput = new MaximumNumberCheck.GenericMaximum<float>(1.1f, 2.2f, 3.3f).MaximumMethod();
            Console.WriteLine("Maximum of float number : " + floatOutput);

            /// Giving stings and, invoke Maximum Method to find maximum string
            string stringOutput = new MaximumNumberCheck.GenericMaximum<string>("Apple", "Peach", "Bannana").MaximumMethod();
            Console.WriteLine("Maximum of strings : " + stringOutput);
        }
    }
}
