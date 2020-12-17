using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    /// <summary>Provides some testcases for Matrix class.</summary>
    public class MatrixTests
    {
        [Test]

        /// <summary>Tests when the matrix is divided by a positive integer</summary>
        public void Test_when_divisor_is_positive([Random(1, 9, 10)]int num)
        {
            int[,] myMatrix = new int[,] {
                {5, 10, 15},
                {20, 25, 30},
            };

            int[,] result = new int[2, 3];

            for (int row = 0; row < 2; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    result[row, column] = myMatrix[row, column] / num;
                }
            }

            Assert.AreEqual(MyMath.Matrix.Divide(myMatrix, num), result);
        }

        [Test]
        /// <summary>Tests when divisor is 0.</summary>
        public void Test_when_divisor_is_zero()
        {
            int[,] myMatrix = new int[,] {
                {5, 10, 15},
                {20, 25, 30},
            };

            Assert.AreEqual(MyMath.Matrix.Divide(myMatrix, 0), null);
        }
        [Test]

        /// <summary>Test when the matrix is null.</summary>
        public void Test_when_matrix_is_null()
        {
            int[,] myMatrix = null;
            Assert.AreEqual(MyMath.Matrix.Divide(myMatrix, 1), null);
        }

        [Test]

        /// <summary>Tests when the matrix is divided by a positive integer</summary>
        public void Test_when_divisor_is_negative([Random(-9, -1, 10)]int num)
        {
            int[,] myMatrix = new int[,] {
                {5, 10, 15},
                {20, 25, 30},
            };

            int[,] result = new int[2, 3];

            for (int row = 0; row < 2; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    result[row, column] = myMatrix[row, column] / num;
                }
            }

            Assert.AreEqual(MyMath.Matrix.Divide(myMatrix, num), result);
        }
    }
}