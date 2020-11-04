using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumProblemUsingGenerics;

namespace MaximumNumberCheckTest1
{
    [TestClass]
    public class FindMaximumTest
    {
        /// <summary>
        /// Test Case 1.1
        /// Givens the maximum integer number at first position it should return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaximumIntegerNumberAtFirstPosition_ItShouldReturnSameNumber()
        {
            /// Arrange
            int expected = 33;

            /// Act
            int actual = MaximumNumberCheck.MaximumIntegerNumber(33, 22, 11);

            /// Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test Case 1.2
        /// Givens the maximum integer number at second position it should return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaximumIntegerNumberAtSecondPosition_ItShouldReturnSameNumber()
        {
            /// Arrange
            int expected = 33;

            /// Act
            int actual = MaximumNumberCheck.MaximumIntegerNumber(11, 33, 22);

            /// Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test case 1.3
        /// Givens the maximum integer number at third position it should return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaximumIntegerNumberAtThirdPosition_ItShouldReturnSameNumber()
        {
            /// Arrange
            int expected = 33;

            /// Act
            int actual = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);

            /// Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test Case 2.1
        /// Givens the maximum float number at first position it should return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaximumFloatNumberAtFirstPosition_ItShouldReturnSameNumber()
        {
            /// Arrange
            double expected = 3.3;

            /// Act
            double actual = MaximumNumberCheck.MaximumFloatNumber(3.3, 2.2, 1.1);

            /// Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test Case 2.2
        /// Givens the maximum float number at second position it should return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaximumFloatNumberAtSecondPosition_ItShouldReturnSameNumber()
        {
            /// Arrange
            double expected = 3.3;

            /// Act
            double actual = MaximumNumberCheck.MaximumFloatNumber(1.1, 3.3, 2.2);

            /// Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test case 2.3
        /// Givens the maximum float number at third position it should return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaximumFloatNumberAtThirdPosition_ItShouldReturnSameNumber()
        {
            /// Arrange
            double expected = 3.3;

            /// Act
            double actual = MaximumNumberCheck.MaximumFloatNumber(1.1, 2.2, 3.3);

            /// Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
