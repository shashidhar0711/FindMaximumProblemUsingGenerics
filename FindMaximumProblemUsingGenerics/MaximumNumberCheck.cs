using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumProblemUsingGenerics
{
    public class MaximumNumberCheck
    {
        /// <summary>
        /// Using generics class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class GenericMaximum<T> where T : IComparable
        {
            public T[] array;

            /// <summary>
            /// Initializes a new instance of the <see cref="GenericMaximum{T}"/> class.
            /// </summary>
            /// <param name="array">The array.</param>
            public GenericMaximum(T[] array)
            {
                this.array = array;
            }

            /// <summary>
            /// Sorts the specified values.
            /// </summary>
            /// <param name="values">The values.</param>
            /// <returns></returns>
            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;
            }

            /// <summary>
            /// Maximums the value.
            /// </summary>
            /// <param name="values">The values.</param>
            /// <returns></returns>
            public T MaxValue(params T[] values)
            {
                T[] sortedArray = Sort(this.array);

                return sortedArray[sortedArray.Length - 1];
            }

            /// <summary>
            /// Prints the maximum.
            /// </summary>
            public void PrintMax()
            {
                var max = MaxValue(this.array);
                Console.WriteLine("The maximum value is: " + max);

            }
        }
        
    }
}
