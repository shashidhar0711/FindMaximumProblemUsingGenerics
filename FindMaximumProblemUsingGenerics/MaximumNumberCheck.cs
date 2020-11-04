using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumProblemUsingGenerics
{
    public class MaximumNumberCheck
    {
        /// <summary>
        /// To find Maximum Value using generic 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class GenericMaximum<T> where T : IComparable
        {
            public T firstValue, secondValue, thirdValue;

            /// <summary>
            /// Initializes a new instance of the <see cref="GenericMaximum{T}"/> class.
            /// </summary>
            /// <param name="firstValue">The first value.</param>
            /// <param name="secondValue">The second value.</param>
            /// <param name="thirdValue">The third value.</param>
            public GenericMaximum(T firstValue, T secondValue, T thirdValue)
            {
                this.firstValue = firstValue;
                this.secondValue = secondValue;
                this.thirdValue = thirdValue;
            }

            /// <summary>
            /// Maximums the value.
            /// </summary>
            /// <param name="firstValue">The first value.</param>
            /// <param name="secondValue">The second value.</param>
            /// <param name="thirdValue">The third value.</param>
            /// <returns></returns>
            /// <exception cref="System.Exception">All three values are same</exception>
            public static T MaximumValue(T firstValue, T secondValue, T thirdValue)
            {
                if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                {
                    return firstValue;
                }
                if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                {
                    return secondValue;
                }
                if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                {
                    return thirdValue;
                }

                throw new Exception("All three values are same");
            }

            /// <summary>
            /// Maximums the method.
            /// </summary>
            /// <returns></returns>
            public T MaximumMethod()
            {
                T max = GenericMaximum<T>.MaximumValue(this.firstValue, this.secondValue, this.thirdValue);
                return max;
            }
        }
        
    }
}
