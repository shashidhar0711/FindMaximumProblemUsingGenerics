using System;

namespace FindMaximumProblemUsingGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            /// To find maximum numbers by giving integer numbers
            int integerOutput = MaximumNumberCheck.MaximumIntegerNumber(33, 22, 11);
            Console.WriteLine("The maximum integer number is: " + integerOutput);

            /// To find maximum numbers by giving float numbers
            double floatOutput = MaximumNumberCheck.MaximumFloatNumber(3.3, 2.2, 1.1);
            Console.WriteLine("The maximum float number is: " + floatOutput);
        }
    }
}
