using FindMaximumProblemUsingGenerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaximumNumberCheckTest4
{
    [TestClass]
    public class MaximumCheckTest
    {
        /// <summary>
        /// Test Case 3.4
        /// Givens the integer to find maximum integer number it should return expected value.
        /// </summary>
        [TestMethod]
        public void GivenIntegerToFindMaximumIntegerNumber_ItShouldReturnExpectedValue()
        {
            /// Arrange
            int expected = 33;

            /// Act
            int integerOutput = new MaximumNumberCheck.GenericMaximum<int>(33, 22, 11).MaximumMethod();

            /// Assert
            Assert.AreEqual(expected, integerOutput);
        }

        /// <summary>
        /// Test Case 3.5
        /// Givens the float to find maximum float number it should return expected value.
        /// </summary>
        [TestMethod]
        public void GivenFloatToFindMaximumFloatNumber_ItShouldReturnExpectedValue()
        {
            /// Arrange
            float expected = 3.3f;

            /// Act
            float floatOutput = new MaximumNumberCheck.GenericMaximum<float>(3.3f, 2.2f, 1.1f).MaximumMethod();

            /// Assert
            Assert.AreEqual(expected, floatOutput);
        }

        /// <summary>
        /// Test Case 3.6
        /// Givens the string to find maximum string it should return expected value.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public void GivenStringToFindMaximumString_ItShouldReturnExpectedValue()
        {
            /// Arrange
            string expected = "peach";

            /// Act
            string stringOutput = new MaximumNumberCheck.GenericMaximum<string>("peach", "Apple", "Bannana").MaximumMethod();

            // Assert
            Assert.AreEqual(expected, stringOutput);
        }

    }
}
