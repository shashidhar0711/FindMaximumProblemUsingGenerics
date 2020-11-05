using FindMaximumProblemUsingGenerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaximumNumberCheckTest5
{
    [TestClass]
    public class MaximumNumberCheckTest
    {
        /// <summary>
        /// Test Case 5.1
        /// Givens the maximum integer value at first position it should return expected value.
        /// </summary>
        [TestMethod]
        public void GivenMaximumIntegerValueAtFirstPosition_ItShouldReturnExpectedValue()
        {
            /// Arrange
            int[] intArray = { 33, 22, 11, 10 };
            int expected = 33;

            /// Act
            MaximumNumberCheck.GenericMaximum<int> findInteger = new MaximumNumberCheck.GenericMaximum<int>(intArray);
            int intgerOutput = findInteger.MaxValue();

            /// Assert
            Assert.AreEqual(expected, intgerOutput);
        }

        /// <summary>
        /// Test Case 5.2
        /// Givens the maximum float value at first position it should return expected value.
        /// </summary>
        [TestMethod]
        public void GivenMaximumFloatValueAtFirstPosition_ItShouldReturnExpectedValue()
        {
            /// Arrange
            float[] floatArray = { 33.3f, 22.2f, 11.1f, 10.0f };
            float expected = 33.3f;

            /// Act
            MaximumNumberCheck.GenericMaximum<float> findFloat = new MaximumNumberCheck.GenericMaximum<float>(floatArray);
            float floatOutput = findFloat.MaxValue();

            /// Assert
            Assert.AreEqual(expected, floatOutput);
        }

        /// <summary>
        /// Test Case 5.3
        /// Givens the maximum string value at first position it should return expected value.
        /// </summary>
        [TestMethod]
        public void GivenMaximumStringValueAtFirstPosition_ItShouldReturnExpectedValue()
        {
            /// Arrange
            string[] stringArray = {"Peach" , "Apple", "Bannana", "Grapes"};
            string expected = "Peach";

            /// Act
            MaximumNumberCheck.GenericMaximum<string> findString = new MaximumNumberCheck.GenericMaximum<string>(stringArray);
            string stringOutput = findString.MaxValue();

            /// Assert
            Assert.AreEqual(expected, stringOutput);
        }
    }
}
