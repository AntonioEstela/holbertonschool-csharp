using System;

/// <summary>Multiplies two matrices and returns the resulting matrix</summary>
class MatrixMath
{
    /// <summary>Multiplies two matrices and returns the resulting matrix</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] err = {{-1}};
    
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return err;

        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int cols2 = matrix2.GetLength(1);
        double[,] NMatrix = new double[rows1, cols2];

        for (int x = 0; x < rows1; x++)
        {
            for (int y = 0; y < cols2; y++)
            {
                double n = 0; 
                for (int z = 0; z < cols1; z++)
                    n = n + matrix1[x, z] * matrix2[z, y];
                NMatrix[x, y] = n;
            }
        }
        return NMatrix;
    }
}
