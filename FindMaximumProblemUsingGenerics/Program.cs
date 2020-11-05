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
            /// Intger array
            int[] intArray = { 33, 22, 11, 10 };
            /// Float array
            float[] floatArray = { 33.3f, 22.2f, 11.1f, 10.0f };
            /// String array
            string[] stringArray = { "Peach", "Apple", "Bannana", "Grapes" };

            /// Invoke the method and print maximum
            new MaximumNumberCheck.GenericMaximum<int>(intArray).PrintMax();
            new MaximumNumberCheck.GenericMaximum<float>(floatArray).PrintMax();
            new MaximumNumberCheck.GenericMaximum<string>(stringArray).PrintMax();
        }
    }
}