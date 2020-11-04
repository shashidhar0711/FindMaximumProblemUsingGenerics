using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumProblemUsingGenerics;

namespace MaximumNumberCheckTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test Case 1.1
        /// Givens the maximum number at first position it should return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaximumNumberAtFirstPosition_ItShouldReturnSameNumber()
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
        /// Givens the maximum number at second position it should return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaximumNumberAtSecondPosition_ItShouldReturnSameNumber()
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
        /// Givens the maximum number at third position it should return same number.
        /// </summary>
        [TestMethod]
        public void GivenMaximumNumberAtThirdPosition_ItShouldReturnSameNumber()
        {
            /// Arrange
            int expected = 33;

            /// Act
            int actual = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);

            /// Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
