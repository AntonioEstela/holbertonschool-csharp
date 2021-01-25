using System;

/// <summary>Matrix</summary>
class MatrixMath
{
    /// <summary>Transpose</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.Length == 0)
            return matrix;

        int rws = matrix.GetLength(0);
        int cls = matrix.GetLength(1);

        double[,] result = new double[cls, rws];

        for (int x = 0; x < rws; x++)
        {
            for (int y = 0; y < cls; y++)
                result[y, x] = matrix[x, y];
        }
        return result;
    }
}
