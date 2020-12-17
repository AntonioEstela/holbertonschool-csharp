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
                int[,] result = new int[rows, columns];

                for (int row = 0; row < 2; row++)
                {
                    for (int column = 0; column < 3; column++)
                    {
                        result[row, column] = matrix[row, column] / num;
                    }
                }

                return result;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

        }
    }
}
