using System;

namespace MyMath
{
    /// <summary>Provides some methods to work with matrices.</summary>
    public class Matrix
    {
        /// <summary>Divides all elements of a matrix.</summary>
        /// <returns>A new matrix containing divided elements.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;

            try
            {
                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);

                for (int row = 0; row < rows; row++)
                {
                    for (int column = 0; column < columns; column++)
                    {
                        matrix[row, column] = matrix[row, column] / num;
                    }
                }

                return matrix;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

        }
    }
}
